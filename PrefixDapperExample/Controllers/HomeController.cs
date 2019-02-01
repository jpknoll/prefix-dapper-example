using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PrefixDapperExample.Data;

namespace PrefixDapperExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ExampleDbContext _dbContext;

        public HomeController(ExampleDbContext dbContext)
        {
            _dbContext = dbContext;

            var dbinit = new DbInitializer(dbContext);
            dbinit.Initialize();
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> AsyncExample()
        {
            // this one logs
            var results1 = await _dbContext.Orders.ToListAsync();

            // this one doesn't
            var results2 = await _dbContext.Database.GetDbConnection().QueryAsync("select * from orders");

            return Json(results2);
        }

        public async Task<IActionResult> SyncExample()
        {
            // this one logs
            var results1 = await _dbContext.Orders.ToListAsync();

            // so does this one
            var results2 = _dbContext.Database.GetDbConnection().Query("select * from orders");

            return Json(results2);
        }
    }
}
