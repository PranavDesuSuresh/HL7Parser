using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;
using HL7Parser.Business;
using HL7Parser.Business.Entities;
using HL7Parser.Models;

namespace HL7Parser.Services.Controllers
{
    public class PidController : ApiController
    {
        private IHl7Pid pidManager;
        public PidController()
        {
            if (pidManager == null)
                this.pidManager = new PidHandler();
        }

        [HttpPost]
        [ResponseType(typeof(PostResponse))]
        public IHttpActionResult AddPid(Hl7Pid pid)
        {
            if (pid != null)
                return this.Ok(pidManager.SetPid(pid));

            throw new ApiException(HttpStatusCode.BadRequest
                , "PID information cannot be empty"
                , "Request information is not valid");

        }

        [HttpGet]
        [ResponseType(typeof(GetPidResponse))]
        public IHttpActionResult GetPid(int id)
        {
            if (id != 0)
            {
                return this.Ok(pidManager.GetPid(id));
            }

            throw new ApiException(HttpStatusCode.BadRequest
                , "PID information cannot be empty"
                , "Request information is not valid");

        }
    }
}