using BIT.Data.DbHelper;
using BIT.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BIT.Controllers
{
    public class JoinController : Controller
    {
        private readonly ApplicationDbContext _context;
        #region Constructor

        public JoinController(ApplicationDbContext context)
        {
            _context = context;
        }

        #endregion

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Create()
        {




            return View();


        }



        [HttpPost]
        public async Task<ActionResult<Pax>> Create(Pax employee)
        {
            _context.Pax.Add(employee);
            await _context.SaveChangesAsync();

            return RedirectToAction("Create");
        }









    }
}
