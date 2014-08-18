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
    public class ConsultantController : ApiController
    {

        #region Fields

        private readonly IConsultant _consultantService;


        #endregion

        #region Methods

        public ConsultantController(IConsultant consultant)
        {
            _consultantService = consultant;
        }


        // GET api/provider/1
        public ConsultantModel Get(int id)
        {
            if (id <= 0)
            { return new ConsultantModel(); }

            return _consultantService.GetConsultant(id);
        }


        // GET api/provider
        public IQueryable<ConsultantModel> Get()
        {
            return _consultantService.GetAllConsultants().AsQueryable();
        }



        // POST api/provider

        public IHttpActionResult Post([FromBody]ConsultantModel consultant)
        {
            try
            {


                _consultantService.Insert(consultant);
                return StatusCode(HttpStatusCode.NoContent);
                  
            }
            catch (Exception ex)
            {
                return InternalServerError();
            }

        }

        // PUT api/provider/5
        public IHttpActionResult Put(int id, [FromBody]ConsultantModel consultant)
        {
            try
            {
                if (consultant.Id < 0)
                { return BadRequest(); }

                _consultantService.Update(consultant);
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

                var isEntityExists = _consultantService.GetConsultant(id);

                if (isEntityExists == null)
                {
                    return NotFound();
                }

                _consultantService.Delete(id);
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
