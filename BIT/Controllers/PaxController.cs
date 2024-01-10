using BIT.Data.DbHelper;
using BIT.Data.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace BIT.Controllers
{
    public class PaxController : Controller  
    {
        private readonly IUnitOfWork _unitOfWork;
        
        #region Constructor

        public PaxController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        #endregion
        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            List<Pax> objPaxList = _unitOfWork.Pax.GetAll().ToList();
            return View(objPaxList);
        }


        public IActionResult Create()
        {




            return View();


        }



        [HttpPost]

        public IActionResult Create(Pax obj)
        {
            _unitOfWork.Pax.Add(obj);
            _unitOfWork.SaveChanges();
            TempData["success"] = "Category created successfully";
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Pax?  paxFromDb = _unitOfWork.Pax.Get(u => u.Id == id);
            if (paxFromDb == null)
            {
                return NotFound();
            }

            return View(paxFromDb);

        }
        [Authorize(Roles = "Admin")]
        [HttpPost]

        public IActionResult Edit(Pax pax)
        {

            _unitOfWork.Pax.Update(pax);
            _unitOfWork.SaveChanges();
            TempData["success"] = "Pax updates successfully";
            return RedirectToAction("Index");


          
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Pax? paxFromDb = _unitOfWork.Pax.Get(u => u.Id == id);

            if (paxFromDb == null)
            {
                return NotFound();
            }
            return View(paxFromDb);
        }




        [Authorize(Roles = "Admin")]
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int? id)
        {
            Pax obj = _unitOfWork.Pax.Get(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();
            }

            _unitOfWork.Pax.Remove(obj);
            _unitOfWork.SaveChanges();
            TempData["success"] = "Pax deleted successfully";
            return RedirectToAction("Index");
        }




    }
}
