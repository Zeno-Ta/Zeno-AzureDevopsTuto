using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AzureDevopsTuto.Models;
using AzureDevopsTuto.Models.BD;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AzureDevopsTuto.Controllers
{
    public class EtudiantController : Controller
    {
        private DBContext _bd;

        public EtudiantController()
        {
            _bd = new DBContext();
        }
        
        // GET: Etudiant
        public ActionResult Index()
        {
            return View(_bd.Etudiants);
        }

        // GET: Etudiant/Details/5
        public ActionResult Details(int id)
        {
            IEtudiant etudiant = _bd.Etudiants.FirstOrDefault(x => x.ID == id);

            return View(etudiant);
        }

        // GET: Etudiant/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Etudiant/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            IEtudiant etudiant = new Etudiant
            {
                ID = Convert.ToInt32(collection["ID"]),
                Nom = collection["Nom"],
                Matricule = collection["Matricule"],
            };

            try
            {
                _bd.Etudiants.Add(etudiant);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Etudiant/Edit/5
        public ActionResult Edit(int id)
        {
            IEtudiant etudiant = _bd.Etudiants.FirstOrDefault(x => x.ID == id);

            return View(etudiant);
        }

        // POST: Etudiant/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            IEtudiant etudiant = _bd.Etudiants.FirstOrDefault(x => x.ID == id);

            try
            {
                etudiant.Nom = collection["Nom"];

                etudiant.Matricule = collection["Matricule"];

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Etudiant/Delete/5
        public ActionResult Delete(int id)
        {
            IEtudiant etudiant = _bd.Etudiants.FirstOrDefault(x => x.ID == id);

            return View(etudiant);
        }

        // POST: Etudiant/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            IEtudiant etudiant = _bd.Etudiants.FirstOrDefault(x => x.ID == id);

            try
            {
                _bd.Etudiants.Remove(etudiant);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}