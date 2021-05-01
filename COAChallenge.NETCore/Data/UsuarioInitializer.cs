using COAChallenge.NETCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COAChallenge.NETCore.Data
{
    public static class UsuarioInitializer
    {
        public static void Initialize(UsuarioContext context)
        {
            context.Database.EnsureCreated();
            // Se fija si hay algun usuario en la base de datos
            if (context.Usuarios.Any())
            {
                return;  
            }

            //Si no existe entonces usa estos datos de prueba para inicializarla

            var usuarios = new Usuario[]
            {
                new Usuario{Username="MicaScapino",Nombre="Micaela Scapino",Email="micascapinomdq@gmail.com",Telefono="2235272107"},
                new Usuario{Username="Fonso",Nombre="Alfonso Perurno",Email="alfonsoelperro@gmail.com",Telefono="2235135107"},
                new Usuario{Username="Cosme",Nombre="Cosme Fulanito",Email="fulano@gmail.com",Telefono="22123577517"}
            };
            foreach (Usuario u in usuarios)
            {
                context.Usuarios.Add(u);
            }
            context.SaveChanges();
        }

    }
}
