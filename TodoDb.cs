using Microsoft.EntityFrameworkCore;

//  DbContext is a class provided by Entity Framework Core that represents a session with the database, 
// allowing you to query and manipulate data.
public class TodoDb: DbContext
{
    public TodoDb(DbContextOptions<TodoDb> options)
        : base(options) {}
    
    public DbSet<Todo> Todos => Set<Todo>();
}