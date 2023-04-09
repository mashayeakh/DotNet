using BLL;
using BEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNetCore.Cors;

namespace FinalProject.Controllers
{
    public class ProductController : ApiController 
    {
        //add, fetch all products

        [Route("api/Product/AllProducts")]
        [HttpGet]
        public List<ProductModel> AllProducts()
        {
            //this controller does not have any headache on how the data will be coming
            //it will go to ProductService in BLL and 
            //ProductService (GetAll) will let you go to the DAL through ProductRe3po
            //and ProductRepo is a Class of DAL where all the db opertion has been done
            return ProductService.GetAll();
        }

        [Route("api/Product/AllNames")]
        [HttpGet]
        public List<string> AllNames()
        {
            return ProductService.GetNames();
        }


        [Route("api/Product/Delete/{id}")]
        [HttpDelete]
        public void Delete(int id)
        {
            ProductService.Delete(id);
        }

        [Route("api/Product/Add")]
        [HttpPost]
        public void Add(ProductModel p)
        {
            ProductService.Add(p);
        }

         [Route("api/Product/edit")] //a particular product editing
        [HttpPost]

        public void Edit(ProductModel e)
        {
            ProductService.Edit(e);
        }
    }
}
