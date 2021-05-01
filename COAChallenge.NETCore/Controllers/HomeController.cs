using COAChallenge.NETCore.Data;
using COAChallenge.NETCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace COAChallenge.NETCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly UsuarioContext _context;
        public HomeController(UsuarioContext context)
        {
            _context = context;
        }
        //LIST EVERY USER IN THE DB
        public IActionResult Index()
        {
            List<Usuario> lista = _context.Usuarios.ToList();
            return View(lista);
        }

        //GET CREATE NEW USER
        public IActionResult Create()
        {
            Usuario nuevoUsuario = new Usuario();

            return View("Create",nuevoUsuario);
        }
        
        //POST CREATE
        [HttpPost]
        [ActionName("Create")]
        public IActionResult CreateConfirmed(Usuario usuario)
        {
            //Verificamos si los datos que vamos a enviar a la db son validos.
            if (!ModelState.IsValid)
            {
                return View("Create", usuario);
            }
            else
            {
                _context.Usuarios.Add(usuario);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        //GET Delete
        public ActionResult Delete(int id)
        {
            Usuario usuario = _context.Usuarios.Find(id);
            //Verifica que existe ese usuario en la db
            if (usuario == null)
            {
                //return HttpNotFound();
            }
            return View("Delete", usuario);
        }

        //POST Delete
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Usuario usuario = _context.Usuarios.Find(id);
            _context.Usuarios.Remove(usuario);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        //GET Edit
        public ActionResult Edit(int id)
        {
            Usuario usuario = _context.Usuarios.Find(id);
            //Verifica que existe ese usuario en la db
            if (usuario == null)
            {
                //return HttpNotFound();
            }
            return View("Edit", usuario);
        }

        //POST Edit
        [HttpPost]
        [ActionName("Edit")]
        public ActionResult EditConfirmed(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(usuario).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(usuario);

        }
    }

}  
