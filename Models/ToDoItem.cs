namespace ToDoList.Models
{
    public class ToDoItem
    {
        //public int Id { get; set; } //sql server key
        public string id { get; set; } = Guid.NewGuid().ToString(); //cosmos document id
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } =string.Empty;
        public bool IsCompleted {  get; set; }
    }
}
