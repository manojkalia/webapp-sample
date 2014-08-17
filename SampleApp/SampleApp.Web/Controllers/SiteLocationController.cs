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
    public class SiteLocationController : ApiController
    {

        #region Fields

        private readonly ISiteLocation _siteLocationService;


        #endregion

        #region Methods

        public SiteLocationController(ISiteLocation sitelocation)
        {
            _siteLocationService = sitelocation;
        }


        // GET api/provider/1
        public SiteLocationModel Get(int id)
        {
            if (id <= 0)
            { return new SiteLocationModel(); }

            return _siteLocationService.GetSiteLocation(id);
        }


        // GET api/provider
        public IQueryable<SiteLocationModel> Get()
        {
            return _siteLocationService.GetAllSiteLocations().AsQueryable();
        }



        // POST api/provider

        public IHttpActionResult Post([FromBody]SiteLocationModel sitelocation)
        {
            try
            {
                _siteLocationService.Insert(sitelocation);
                return StatusCode(HttpStatusCode.NoContent);
                  
            }
            catch (Exception ex)
            {
                return InternalServerError();
            }

        }

        // PUT api/provider/5
        public IHttpActionResult Put(int id, [FromBody]SiteLocationModel sitelocation)
        {
            try
            {
                if (sitelocation.Id < 0)
                { return BadRequest(); }

                _siteLocationService.Update(sitelocation);
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

                var isEntityExists = _siteLocationService.GetSiteLocation(id);

                if (isEntityExists == null)
                {
                    return NotFound();
                }

                _siteLocationService.Delete(id);
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
