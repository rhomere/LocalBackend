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
    public class MunicipalityController : TableController<Municipality>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            MobileServiceContext context = new MobileServiceContext();
            DomainManager = new EntityDomainManager<Municipality>(context, Request);
        }

        // GET tables/Municipality
        public IQueryable<Municipality> GetAllMunicipality()
        {
            return Query(); 
        }

        // GET tables/Municipality/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<Municipality> GetMunicipality(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Municipality/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<Municipality> PatchMunicipality(string id, Delta<Municipality> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/Municipality
        public async Task<IHttpActionResult> PostMunicipality(Municipality item)
        {
            Municipality current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Municipality/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteMunicipality(string id)
        {
             return DeleteAsync(id);
        }
    }
}
