﻿using System.Web.Http.Dependencies;
using Ninject;

namespace DivingCompetition.Web
{
    public class NinjectDependencyResolver : NinjectDependencyScope, IDependencyResolver
    {
        private readonly IKernel kernel;

        public NinjectDependencyResolver(IKernel kernel)
            : base(kernel)
        {
            this.kernel = kernel;
        }

        public IDependencyScope BeginScope()
        {
            return new NinjectDependencyScope(kernel.BeginBlock());
        }
    }
}