﻿using Microsoft.AspNetCore.Mvc;
using teamProject.Models;
using teamProject.Repository;

namespace teamProject.Controllers
{
    public class GovernerateController : Controller
    {
         IRepositoryGeneric<Governerate> repo;

        public GovernerateController(IRepositoryGeneric<Governerate> repo)
        {
            this.repo = repo;
        }
        public List<Governerate> All()
        {
          return repo.GetAll();
        }
        public IActionResult Index()
        {
            return View("Index", All());
        }
        [HttpGet]
        public IActionResult Delete(int id) 
        {
            repo.Delete(id);
            repo.Save();
            return RedirectToAction("Index", All());
        }

        [HttpPost]
        public IActionResult SaveNew(Governerate governerateRequest)
        {
           repo.Add(governerateRequest);
            repo.Save();
            return RedirectToAction("Index",All());
        }
        [HttpGet]
        public IActionResult Edit(int id) 
        {
            Governerate governerate =repo.GetById(id);
            return View("Edit",governerate);
        }

        [HttpPost]
        public IActionResult SaveEdit(Governerate governerateRequest) 
        {
            Governerate governerate;
            if (ModelState.IsValid) 
            {
                 governerate =repo.GetById(governerateRequest.Id);
                governerate.Name = governerateRequest.Name;
                governerate.Code = governerateRequest.Code;
                repo.Save();
                return RedirectToAction("Index",All());
            }
            return View("Edit",governerateRequest);
        }


    }
}
