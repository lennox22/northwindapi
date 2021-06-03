using APIexercieses.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIexercieses.Controllers
{
    [Route("orderdetails")]
    [ApiController]
    public class orderdetailController : ControllerBase
    {
        /*
        *      URL Paths:
        * 
        *      Get/orderdetails - return all orderdetails
        *      Get/orderdetail{id} - return a single orderdetail by id
        *      post /orderdetail - create an orderdetail
        *      put /orderdetail - update an existing orderdetail
        *      delete /orderdetail/{id{ - delete a single orderdetail by id
        * 
        */
        [HttpGet]
        public List<orderdetail> ReadAllOD()
        {
            return DAL.ReadAllOD();
        }
        [HttpGet("{odid}")]
        public orderdetail ReadOneOD(int odid)
        {
            return DAL.ReadOneOD(odid);
        }
        [HttpPost]
        public int CreateOD(orderdetail od)
        {
            return DAL.CreateOD(od);
        }
        [HttpPost("{odid}")]
        public int UpdateOD(orderdetail od)
        {
            int odid = DAL.UpdateOD(od);
            return odid;
        }
        [HttpDelete]
        public bool DeleteOD(int odid)
        {
            bool deleted = DAL.DeleteOD(odid);
            return deleted;
        }
    }
}
