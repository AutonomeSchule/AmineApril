using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public string Index()
        {
            return "Amine Heute würde ich fertig sein";
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome(string name)
        {
            return "Jetzt beginnen wir : " + name;
        }

        // 
        // Get/Amine probe

        public string Einladung(string vorname, string ort)
        {
            return "Lieber "+ vorname + ", Herzlich Willkommen in der " + ort ;
        }


        public int a(int d)
        {
            int c = 2*b(4)+d; 
            return c;
        }


        public int b(int a)
        {
            return 6+a;
        }


    }
}
