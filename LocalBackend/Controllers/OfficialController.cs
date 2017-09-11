using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.Azure.Mobile.Server;
using LocalBackend.DataObjects;
using LocalBackend.Models;

namespace LocalBackend.Controllers
{
    public class OfficialController : TableController<Official>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            MobileServiceContext context = new MobileServiceContext();
            DomainManager = new EntityDomainManager<Official>(context, Request);
        }

        // GET tables/Official
        public IQueryable<Official> GetAllOfficial()
        {
            return Query(); 
        }

        // GET tables/Official/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<Official> GetOfficial(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Official/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<Official> PatchOfficial(string id, Delta<Official> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/Official
        public async Task<IHttpActionResult> PostOfficial(Official item)
        {
            Official current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Official/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteOfficial(string id)
        {
             return DeleteAsync(id);
        }
    }
}
