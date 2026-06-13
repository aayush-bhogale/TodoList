//using ToDoList.Models;

//namespace ToDoList.Repositories
//{
//    public class InMemoryToDoRepository : ITodoRepository
//    {
//        private readonly List<ToDoItem> _items = new();
//        private int _nextId = 1;


//        public List<ToDoItem> GetAll()
//        {
//            return _items;
//        }
//        public void Add(ToDoItem item)
//        {
//            item.Id=_nextId++;  
//            _items.Add(item);
//        }

//        public void Update(ToDoItem item)
//        {
//            var existing = GetById(item.Id);

//            if (existing != null)
//            {
//                existing.Title = item.Title;
//                existing.Description = item.Description;
//                existing.IsCompleted = item.IsCompleted;
//            }
//        }

//        public void Delete(int id)
//        {
//            var item = GetById(id);
//            if (item != null)
//            {
//                _items.Remove(item);
//            }
//        }

//        public ToDoItem? GetById(int id)
//        {
//            return _items.FirstOrDefault(x => x.Id == id);
//        }
//    }
//}
