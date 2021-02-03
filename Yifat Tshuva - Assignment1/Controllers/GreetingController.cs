using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Yifat_Tshuva___Assignment1.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// This method returns the string "Hello World!" when receiving a POST request. 
        /// <example>POST api/Greeting</example>
        /// </summary>
        /// <returns>"Hello World!"</returns>

        public string Post()
        {
            return "Hello World!";
        }


        /// <summary>
        /// This method returns the string “Greetings to {id} people!” where id is an integer value when receiving a GET request. 
        /// <example>GET api/Greeting/{id}</example>
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        /// returns the string "Greetings to" +" "+ id + " "+ "people!";
        /// GET api/Greeting/3 --> "Greetings to 3 people!"
        /// GET api/Greeting/6 --> "Greetings to 6 people!"
        /// GET api/Greeting/0 --> "Greetings to 0 people!"</returns>

        public string GET(int id)

        {
            return "Greetings to" + " " + id + " " + "people!";
        }
    }
}
