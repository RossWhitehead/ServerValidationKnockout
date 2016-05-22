using System.Web.Http;
using System.Web.Http.Description;
using ServerValidationKnockout.Models;

namespace ServerValidationKnockout.Controllers
{
    public class ProductsController : ApiController
    {
        private ServerValidationKnockoutDbContext db = new ServerValidationKnockoutDbContext();

        // POST: api/Products
        [ResponseType(typeof(Product))]
        public IHttpActionResult PostProduct(Product product)
        {
            // Adding some model errors to demo the functionality
            ModelState.AddModelError("product.Name", "Product name is already in use");
            ModelState.AddModelError("General", "General error 1");
            ModelState.AddModelError("General", "General error 2");

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Products.Add(product);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = product.ProductId }, product);
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