using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }
        public DbSet<Proyecto> Proyectos { get; set; }
        public DbSet<Tarea> Tareas { get; set; }
    }
}
