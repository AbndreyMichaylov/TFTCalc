using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TFTCalc.DataBaseContexts;
using TFTCalc.Models;
using static TFTCalc.Controllers.Utils.CustomActionResults;

namespace TFTCalc.Controllers
{
    [Route("/")]
    public class IndexController : Controller
    {
        private TftDbContext _context;
        public IndexController(TftDbContext tftDbContext)
        {
            _context = tftDbContext;
        }

        [Route("/")]
        [Produces("application/json")]
        public IActionResult Index()
        {
            ComboItem resultItem;

            List<Hero> heroes = new List<Hero>();
            heroes.Add(_context.Hero.Where(x => x.Name == "Гарен").First());
            heroes.Add(_context.Hero.Where(x => x.Name == "Гарен").First());
            heroes.Add(_context.Hero.Where(x => x.Name == "Грейвз").First());

            string result = "";
            foreach (var hero in heroes)
            {
                result += hero.Name + " имеет аттрибуты: ";
                var attrs = _context.Hero.Where(x => x.Name == hero.Name).Include(x => x.Attributes).ToList();
                var b = attrs.First().Attributes;
                foreach (var attr in b)
                {
                    result += attr.Name + ", ";
                }
                result += "\n";
            }
            return Content(result);
        }
    }
}
