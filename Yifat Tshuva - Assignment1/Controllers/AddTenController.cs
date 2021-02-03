using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Yifat_Tshuva___Assignment1.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// This method returns 10 more than the integer input {id} when receiving a GET request. 
        /// <example>GET api/AddTen/{id}</example>
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        /// GET api/AddTen/21 --> 31
        /// GET api/AddTen/0 --> 10
        /// GET api/AddTen/-9 --> 1</returns>
        public int Get(int id)
        {
            return (id + 10);

        }
    }
}
