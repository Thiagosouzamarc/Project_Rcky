using Microsoft.EntityFrameworkCore;
using Rcky_crud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rcky_crud.Data
{
    public class DataContexto : DbContext
    {
        public DataContexto(DbContextOptions options) : base(options) { }

        public DbSet<Funcionario> Funcionarios { get; set; }
        
    }
}
