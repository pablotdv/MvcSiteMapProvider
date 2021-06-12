using Microsoft.AspNetCore.Http;
using System;
using System.Text;

namespace MvcSiteMapProvider.Caching
{
    /// <summary>
    /// The default cache key generator. This class generates a unique cache key for each 
    /// DnsSafeHost.
    /// </summary>
    public class SiteMapCacheKeyGenerator
        : ISiteMapCacheKeyGenerator
    {
        public SiteMapCacheKeyGenerator(
            IHttpContextAccessor mvcContextFactory
            )
        {
            if (mvcContextFactory == null)
                throw new ArgumentNullException("mvcContextFactory");
            this.mvcContextFactory = mvcContextFactory;
        }

        protected readonly IHttpContextAccessor mvcContextFactory;

        #region ISiteMapCacheKeyGenerator Members

        public virtual string GenerateKey()
        {
            var builder = new StringBuilder();
            builder.Append("sitemap://");
            builder.Append(this.GetHostName());
            builder.Append("/");

            return builder.ToString();
        }

        #endregion

        protected virtual string GetHostName()
        {
            var context = this.mvcContextFactory.HttpContext;
            var request = context.Request;

            return request.Host.Value;
        }
    }
}
