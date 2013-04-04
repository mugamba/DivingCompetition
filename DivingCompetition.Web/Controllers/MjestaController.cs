using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DivingCompetition.Model;
using System.Linq;

namespace DivingCompetition.Web.Controllers
{
    public class MjestaController : ApiController
    {
        private readonly IMjestoRepository _mjestoRepository;

        public MjestaController(IMjestoRepository mjestoRepository)
        {
            _mjestoRepository = mjestoRepository;
        }

        // GET api/mjesta
        public IQueryable<Mjesto> Get()
        {
            return _mjestoRepository.Query();
        }

        // GET api/mjesta/5
        public Mjesto Get(Int32 id)
        {
            return _mjestoRepository.GetById(id);
        }

        // POST api/mjesta
        public HttpResponseMessage Post(Mjesto mjesto)
        {
            _mjestoRepository.Add(mjesto);
            NhSession.Current.Flush();
            var response = Request.CreateResponse(HttpStatusCode.Created, mjesto);

            response.Headers.Location =
               new Uri(Url.Link(WebApiConfig.ControllerOnly, null) + String.Format("/{0}",mjesto.Id));
            return response;
        }

        // PUT api/mjesta/5
        public HttpResponseMessage Put(Mjesto mjesto)
        {
            _mjestoRepository.Update(mjesto);
            NhSession.Current.Flush();
            return new HttpResponseMessage(HttpStatusCode.NoContent);
        }

        // DELETE api/mjesta/5
        public HttpResponseMessage Delete(Int32 id)
        {
            _mjestoRepository.Remove(NhSession.Current.Get<Mjesto>(id));
            NhSession.Current.Flush();
            return new HttpResponseMessage(HttpStatusCode.NoContent);
        }

    }
}
