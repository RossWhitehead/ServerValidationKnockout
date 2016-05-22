using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ServerValidationKnockout.Models;

namespace ServerValidationKnockout.Controllers
{
    public class ProductCategoriesController : ApiController
    {
        private ServerValidationKnockoutDbContext db = new ServerValidationKnockoutDbContext();

        // GET: api/ProductCategories
        public IQueryable<ProductCategory> GetProductCategories()
        {
            return db.ProductCategories;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}