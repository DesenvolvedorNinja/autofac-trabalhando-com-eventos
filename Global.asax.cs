using Autofac;
using Autofac.Integration.Wcf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace AutofacDemoWCF
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            var builder = new ContainerBuilder();

            // Register your service implementations.
            builder.RegisterType<AutofacDemoWCF.Service1>();
            builder.RegisterType<Soma>().As<ICalculo>().InstancePerLifetimeScope().OnActivating(c => Debug.Write("OnActivating: Soma")).OnActivated(c => Debug.Write("OnActivated: Soma")).OnRelease(c => Debug.Write("OnRelease: Soma"));
            builder.RegisterType<DoLog>().AsSelf().SingleInstance().OnActivating(c => Debug.Write("OnActivating: DoLog")).OnActivated(c => Debug.Write("OnActivated: DoLog")).OnRelease(c => Debug.Write("OnRelease: DoLog"));
            
            // Set the dependency resolver.
            AutofacHostFactory.Container = builder.Build();
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}