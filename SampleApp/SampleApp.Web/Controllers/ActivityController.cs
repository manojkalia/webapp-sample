using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SampleApp.Core.Interfaces.Services;
using SampleApp.Entities.Models;

namespace SampleApp.Web.Controllers
{
    public class ActivityController : ApiController
    {
        #region Fields

        private readonly IActivity _activityService;


        #endregion

        public ActivityController(IActivity activity)
        {
            _activityService = activity;
        }

        // GET api/<controller>/5
        public ActivityModel Get(int id)
        {
            if (id <= 0)
            { return new ActivityModel(); }

            return _activityService.GetActivity(id);
        }

        // GET api/activities
        public IQueryable<ActivityModel> Get()
        {
            return _activityService.GetAllActivities().AsQueryable();
        }

        // POST api/<controller>
        public IHttpActionResult Post([FromBody]ActivityModel activity)
        {
            try
            {
                _activityService.Insert(activity);
                return StatusCode(HttpStatusCode.NoContent);
            }
            catch (Exception ex)
            {
                return InternalServerError();
            }
        }

        // PUT api/<controller>/5
        public IHttpActionResult Put(int id, [FromBody]ActivityModel activity)
        {
            try
            {
                if (activity.Id < 0)
                { return BadRequest(); }

                _activityService.Update(activity);
                return StatusCode(HttpStatusCode.NoContent);

            }
            catch (Exception ex)
            {
                return InternalServerError();
            }
        }

        // DELETE api/<controller>/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                if (id <= 0)
                {
                    return BadRequest();
                }

                var isEntityExists = _activityService.GetActivity(id);

                if (isEntityExists == null)
                {
                    return NotFound();
                }

                _activityService.Delete(id);
                return StatusCode(HttpStatusCode.NoContent);
            }
            catch (Exception ex)
            {
                return InternalServerError();
            }
        }
    }
}