using COAChallenge.NETCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COAChallenge.NETCore.Data
{
    public class UsuarioContext : DbContext
    {
        

        public static string DbConnectionString = "dbUsers";

        public UsuarioContext(DbContextOptions<UsuarioContext> options) : base (options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }

    }
}
