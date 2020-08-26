using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    public class TodoContext : DbContext
    {
        //injecting the class// generic type/ of type TodoContext
        public TodoContext(DbContextOptions<TodoContext> options) // 
            : base(options)// passing it to base calling the const parent and passing the option
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
