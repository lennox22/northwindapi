using APIexercieses.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIexercieses.Controllers
{
    [Route("category")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        /*
        *      URL Paths:
        * 
        *      Get/category - return all categories
        *      Get/category{id} - return a single category by id
        *      post /category - create an category
        *      put /category - update an existing category
        *      delete /category/{id{ - delete a single category by id
        * 
        */
        [HttpGet]
        public List<category> ReadAllCats()
        {
            return DAL.ReadAllCats();
        }
        [HttpGet("{catid}")]
        public category ReadOneCat(int catid)
        {
            return DAL.ReadOneCat(catid);
        }
        [HttpPost]
        public int CreateCat(category cat)
        {
            return DAL.CreateCat(cat);
        }
        [HttpPost("{catid}")]
        public int UpdateCat(category cat)
        {
            int catid = DAL.UpdateCat(cat);
            return catid;
        }
        [HttpDelete]
        public bool DeleteCat(int catid)
        {
            bool deleted = DAL.DeleteCat(catid);
            return deleted;
        }
    }
}
