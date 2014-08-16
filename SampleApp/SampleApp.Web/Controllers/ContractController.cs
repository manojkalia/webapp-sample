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
    public class ContractController : ApiController
    {

        #region Fields

        private readonly IContract _contractService;


        #endregion

        #region Methods

        public ContractController(IContract contract)
        {
            _contractService = contract;
        }


        // GET api/provider/1
        public ContractModel Get(int id)
        {
            if (id <= 0)
            { return new ContractModel(); }

            return _contractService.GetContract(id);
        }


        // GET api/provider
        public IQueryable<ContractModel> Get()
        {
            return _contractService.GetAllContracts().AsQueryable();
        }



        // POST api/provider

        public IHttpActionResult Post([FromBody]ContractModel contract)
        {
            try
            {
                _contractService.Insert(contract);
                return StatusCode(HttpStatusCode.NoContent);
                  
            }
            catch (Exception ex)
            {
                return InternalServerError();
            }

        }

        // PUT api/provider/5
        public IHttpActionResult Put(int id, [FromBody]ContractModel contract)
        {
            try
            {
                if (contract.Id < 0)
                { return BadRequest(); }

                _contractService.Update(contract);
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

                var isEntityExists = _contractService.GetContract(id);

                if (isEntityExists == null)
                {
                    return NotFound();
                }

                _contractService.Delete(id);
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
