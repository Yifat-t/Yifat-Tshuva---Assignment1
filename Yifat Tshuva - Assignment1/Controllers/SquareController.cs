using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Yifat_Tshuva___Assignment1.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// This method returns the square of the integer input {id} when receiving a GET request. 
        /// <example>GET api/square/{id}</example>
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        /// GET api/NumberMachine/2 --> 4
        /// GET api/NumberMachine/-2 --> 4
        /// GET api/NumberMachine/10 --> 100</returns>


        public IEnumerable<int> GET(int id)
        {
            return new int[] { id * id };
        }

    }
}
