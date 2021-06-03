using APIexercieses.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIexercieses.Controllers
{
    [Route("shipper")]
    [ApiController]
    public class shipperController : ControllerBase
    {
        /*
        *      URL Paths:
        * 
        *      Get/shippers - return all shippers
        *      Get/shipper{id} - return a single shipper by id
        *      post /shipper - create an shipper
        *      put /shipper - update an existing shipper
        *      delete /shipper/{id{ - delete a single shipper by id
        * 
        */
        [HttpGet]
        public List<shipper> ReadAllShipper()
        {
            return DAL.ReadAllShipper();
        }
        [HttpGet("{shipid}")]
        public shipper ReadOneShipper(int shipid)
        {
            return DAL.ReadOneShipper(shipid);
        }
        [HttpPost]
        public int CreateShipper(shipper ship)
        {
            return DAL.CreateShipper(ship);
        }
        [HttpPost("{shipid}")]
        public int UpdateShipper(shipper ship)
        {
            int shipid = DAL.UpdateShipper(ship);
            return shipid;
        }
        [HttpDelete]
        public bool DeleteShipper(int shipid)
        {
            bool deleted = DAL.DeleteShipper(shipid);
            return deleted;
        }
    }
}
