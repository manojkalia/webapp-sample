using System.Collections.Generic;
using System.Web.Http;
using SampleApp.Core.Interfaces.Services;
using SampleApp.Entities.Models;
using System.Linq;
using System.Web;
using System.Net;
using System;

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
            if (id <= 0)
            { return new ProviderModel(); }

            return _providerService.GetProvider(id);
        }


        // GET api/provider
        public IQueryable<ProviderModel> Get()
        {
            return _providerService.GetAllProviders().AsQueryable();
        }



        // POST api/provider

        public IHttpActionResult Post([FromBody]ProviderModel provider)
        {
            try
            {
                

                _providerService.Insert(provider);
                return StatusCode(HttpStatusCode.NoContent);
                  
            }
            catch (Exception ex)
            {
                return InternalServerError();
            }

        }

        // PUT api/provider/5
        public IHttpActionResult Put(int id, [FromBody]ProviderModel provider)
        {
            try
            {
                if (provider.Id < 0)
                { return BadRequest(); }

                _providerService.Update(provider);
                return StatusCode(HttpStatusCode.NoContent);

            }
            catch (Exception ex)
            {
                return InternalServerError();
            }
        }

        // DELETE api/provider/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                if (id <= 0)
                {
                    return BadRequest();
                }

                var isEntityExists = _providerService.GetProvider(id);

                if (isEntityExists == null)
                {
                    return NotFound();
                }

                _providerService.Delete(id);
                return StatusCode(HttpStatusCode.NoContent);
            }
            catch (Exception ex)
            {
                return InternalServerError();
            }
        }


        #endregion
    }
}
