using System.Collections.Generic;
using System.Web.Http;
using SampleApp.Core.Interfaces.Services;
using SampleApp.Entities.Models;

namespace SampleApp.Web.Controllers
{
    public class ProviderController : ApiController
    {

        #region Fields

        private readonly IProvider _providerService;


        #endregion

        #region Methods

        public ProviderController(IProvider provider)
        {
            _providerService = provider;
        }


        // GET api/provider/1
        public ProviderModel Get(int id)
        {
            return _providerService.GetProvider(id);
        }


        // GET api/provider
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

       

        // POST api/provider
        public void Post([FromBody]string value)
        {
        }

        // PUT api/provider/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/provider/5
        public void Delete(int id)
        {
        }

        #endregion
    }
}
