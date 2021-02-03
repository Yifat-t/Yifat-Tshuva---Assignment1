using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Yifat_Tshuva___Assignment1.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// This method returns the value of a string which has an input {id}, and applies four mathematical operations to it when receiving a GET request. 
        /// <example>GET api/NumberMachine/{id}</example>
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        /// GET api/NumberMachine/10 --> 98
        /// GET api/NumberMachine/-5 --> 104
        /// GET api/NumberMachine/30 --> 100</returns>

        public IEnumerable<int> GET(int id)
        {
            return new int[] { 100 - 4 * (2 + 3) / id };
        }
    }
}
