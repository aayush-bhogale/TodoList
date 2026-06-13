using Microsoft.Azure.Cosmos;
using ToDoList.Models;

namespace ToDoList.Repositories
{
    public class CosmosTodoRepository : ITodoRepository
    {
        private readonly Container _container;

        public CosmosTodoRepository(IConfiguration configuration)
        {
            var client = new CosmosClient(
                configuration["CosmosDb:Endpoint"],
                configuration["CosmosDb:Key"]);

            var database = client.GetDatabase(
                configuration["CosmosDb:DatabaseName"]);

            _container = database.GetContainer(
                configuration["CosmosDb:ContainerName"]);
        }

        public void Add(ToDoItem item)
        {
            _container.CreateItemAsync(
                item,
                new PartitionKey(item.id))
                .Wait();
        }

        public List<ToDoItem> GetAll()
        {
            var query = _container.GetItemQueryIterator<ToDoItem>();

            var results = new List<ToDoItem>();

            while (query.HasMoreResults)
            {
                var response = query.ReadNextAsync().Result;
                results.AddRange(response);
            }

            return results;
        }

        public ToDoItem? GetById(string id)
        {
            try
            {
                var response = _container.ReadItemAsync<ToDoItem>(
                    id,
                    new PartitionKey(id))
                    .Result;

                return response.Resource;
            }
            catch
            {
                return null;
            }
        }

        public void Update(ToDoItem item)
        {
            _container.UpsertItemAsync(
                item,
                new PartitionKey(item.id))
                .Wait();
        }

        public void Delete(string id)
        {
            _container.DeleteItemAsync<ToDoItem>(
                id,
                new PartitionKey(id))
                .Wait();
        }
    }
}
