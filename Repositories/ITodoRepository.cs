using ToDoList.Models;

namespace ToDoList.Repositories
{
    public interface ITodoRepository//here all actions are written. This is the interface
    {
        List<ToDoItem> GetAll();
        void Add(ToDoItem item);
        void Update(ToDoItem item);
        void Delete(int id);
        ToDoItem? GetById(int id);
    }
}
