using docker_compose_demos.Entity;
using Microsoft.EntityFrameworkCore;

namespace docker_compose_demos.Context;

public class TodoContext:DbContext
{
    public TodoContext(DbContextOptions<TodoContext> options)
        : base(options) { }

    public DbSet<Todo> Todos => Set<Todo>();
}