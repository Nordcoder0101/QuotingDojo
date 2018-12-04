using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuotingDojo.Models;

namespace QuotingDojo.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost("quotes")]
        public IActionResult CreateQuote(Quote quote)
        {
            if(ModelState.IsValid)
            {
                System.Console.WriteLine("*!*!*!*!*!*!*!*!Pingalingadingdong*!*!*!*!*!*!*!*");
                string query = $"INSERT INTO Quote(author, quote, created_at) VALUES ('{quote.Author}', '{quote.Content}', Now())";
                DbConnector.Execute(query);
                return RedirectToAction("GetAndShowQuotes");
            }
            else
            {
                return View("Index");
            }
        }

        [HttpGet("getquotes")]
        public IActionResult GetAndShowQuotes()
        {
            List<Dictionary<string, object>> AllQuotes = DbConnector.Query("SELECT * FROM Quote");

            return View(AllQuotes);
        }

        [HttpGet("delete/{id}")]
        public IActionResult DeleteQuote(int id)
        {
            string query = $"DELETE FROM Quote WHERE id ={id}";
            DbConnector.Execute(query);
            return RedirectToAction("GetAndShowQuotes");
        }
        
    }

    
}
