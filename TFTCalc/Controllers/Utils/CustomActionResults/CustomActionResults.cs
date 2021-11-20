using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace TFTCalc.Controllers.Utils
{
    public class CustomActionResults
    {
        public static IActionResult HtmlView(string filename)
        {
            var text = File.ReadAllText($"Views/{filename}.html");
            return new ContentResult() { Content = text, ContentType = "text/html" };
        }
    }
}
