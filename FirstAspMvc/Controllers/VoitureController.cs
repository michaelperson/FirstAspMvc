using GarageOO.DAL.Repositories;
using GarageOO.Models.Concretes;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FirstAspMvc.Controllers
{
    public class VoitureController : Controller
    {
        public IActionResult Index()
        {
            VoitureRepository repo = new VoitureRepository(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TFGarage;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            //demander la liste des voitures de la db
            List<Voiture> MesVoitures = repo.GetAll().ToList();


            return View(MesVoitures);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken] //CRSF
        public IActionResult Create( Voiture model)
        {
            VoitureRepository repo = new VoitureRepository(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TFGarage;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            if(repo.Add(model))
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }
    }
}
