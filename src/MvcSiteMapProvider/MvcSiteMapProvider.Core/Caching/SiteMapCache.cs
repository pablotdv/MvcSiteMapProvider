using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcSiteMapProvider.Caching
{
    public class SiteMapCache
        : MicroCache<ISiteMap>, ISiteMapCache
    {
        public SiteMapCache(
            ICacheProvider<ISiteMap> cacheProvider
            ) : base(cacheProvider)
        {
        }
    }
}
