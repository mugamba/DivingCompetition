using NHibernate.Context;
using System.Web;

namespace DivingCompetition
{
    //IHttpModule is run at application start, configured in config file under modules
    public class NhibernateSessionModule : IHttpModule
    {
        public void Init(HttpApplication context)
        {
            context.BeginRequest += (sender, args) =>
                                       {
                                           var session = NhSession.SessionFactory.OpenSession();
                                           CurrentSessionContext.Bind(session);
                                       };
            context.EndRequest += (sender, args) => 
                CurrentSessionContext.Unbind(NhSession.SessionFactory);
        }

        public void Dispose()
        {}
    }
}