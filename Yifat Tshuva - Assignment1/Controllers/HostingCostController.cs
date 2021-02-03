using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Yifat_Tshuva___Assignment1.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        /// This method returns an output of 3 strings which describe the total hosting cost when receiving a GET request. 
        /// <example>GET api/HostingCost/{id}</example>
        /// </summary>
        /// <param name="id"></param>
        /// <returns>{ firstRow, secondRow, thirdRow } </returns>


        public IEnumerable<string> Get(int id)
        {

            double numberOfFortnights = Math.Floor((id / 14.00) + 1);
            double totalcost = (numberOfFortnights) * 5.50 * 1.13;
            string totalcostFormat = String.Format("{0:0.00}", totalcost);
            string Total = String.Format("{0:0.00}", totalcost);
            double HST = (numberOfFortnights * 5.50 * 0.13);
            string HSTFormat = String.Format("{0:0.00}", HST);

            string firstRow = numberOfFortnights + " fortnights at $5.50/FN = " + numberOfFortnights * 5.50 + " CAD";
            string secondRow = "HST 13% = " + HSTFormat + " CAD";
            string thirdRow = "Total = " + totalcostFormat + " CAD";

            return new string[3] { firstRow, secondRow, thirdRow };

        }
    }
}
