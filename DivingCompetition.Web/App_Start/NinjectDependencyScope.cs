using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Web.Http.Dependencies;
using Ninject;
using Ninject.Syntax;

namespace DivingCompetition.Web
{
    public class NinjectDependencyScope : IDependencyScope
    {
        private IResolutionRoot _resolutionRoot;

        internal NinjectDependencyScope(IResolutionRoot resolutionRoot)
        {
            Contract.Assert(resolutionRoot != null);

            this._resolutionRoot = resolutionRoot;
        }

        public void Dispose()
        {
            var disposable = _resolutionRoot as IDisposable;
            if (disposable != null)
                disposable.Dispose();

            _resolutionRoot = null;
        }

        public object GetService(Type serviceType)
        {
            if (_resolutionRoot == null)
                throw new ObjectDisposedException("this", "This scope has already been disposed");

            return _resolutionRoot.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            if (_resolutionRoot == null)
                throw new ObjectDisposedException("this", "This scope has already been disposed");

            return _resolutionRoot.GetAll(serviceType);
        }
    }
}