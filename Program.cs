using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Rezdy.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Rezdy
{
    class Program
    {
        static void Main(string[] args)
        {

           CRUD crud = new CRUD();
           crud.PostDB();
           

           

        }
    }
}
