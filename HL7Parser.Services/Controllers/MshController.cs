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
    public class MshController : ApiController
    {
        private IHl7Msh mshManager;
        public MshController()
        {
            if(mshManager==null)
                this.mshManager = new MshHandler();
        }

        [HttpPost]
        [ResponseType(typeof(PostResponse))]
        public IHttpActionResult AddMsh(SetMshRequest msh)
        {
            if (msh != null)
                return this.Ok(mshManager.SetMsh(msh.Params));

            throw new ApiException(HttpStatusCode.BadRequest
                , "PID information cannot be empty"
                , "Request information is not valid");

        }

        [HttpGet]
        [ResponseType(typeof(GetMshResponse))]
        public IHttpActionResult GetMsh(int id)
        {
            if (id != 0)
            {
                return this.Ok(mshManager.GetMsh(id));
            }

            throw new ApiException(HttpStatusCode.BadRequest
                , "MSH information cannot be empty"
                , "Request information is not valid");

        }
    }
}