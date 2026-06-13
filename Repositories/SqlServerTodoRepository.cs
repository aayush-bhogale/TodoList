//using ToDoList.Data;
//using ToDoList.Models;

//namespace ToDoList.Repositories
//{
//    public class SqlServerTodoRepository : ITodoRepository
//    {
//        private readonly TodoDBContext _context;//Dbcontext injected via DI
//        public SqlServerTodoRepository(TodoDBContext context)
//        {
//            _context = context;
//        }
//        public void Add(ToDoItem item)
//        {
//            _context.TodoItems.Add(item);
//            _context.SaveChanges();
//        }

//        public void Delete(int id)
//        {
//            var existing = _context.TodoItems.FirstOrDefault(x => x.Id == id);
//            if (existing != null)
//            {
//                _context.TodoItems.Remove(existing);
//                _context.SaveChanges();
//            }
//        }

//        public List<ToDoItem> GetAll()
//        {
//            return _context.TodoItems.ToList();
//        }

//        public ToDoItem? GetById(int id)
//        {
//            return _context.TodoItems.FirstOrDefault(x => x.Id == id);
//        }

//        public void Update(ToDoItem item)
//        {
//            var existing = _context.TodoItems.FirstOrDefault(x => x.Id == item.Id);
//            if (existing != null)
//            {
//                existing.Title = item.Title;
//                existing.Description = item.Description;
//                existing.IsCompleted = item.IsCompleted;
//                _context.SaveChanges();
//            }
//        }
//    }
//}
