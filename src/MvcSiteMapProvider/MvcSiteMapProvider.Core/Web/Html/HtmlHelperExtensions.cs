﻿using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcSiteMapProvider.Web.Html
{
    /// <summary>
    /// IHtmlHelperExtensions class
    /// </summary>
    public static class HtmlHelperExtensions
    {
        /// <summary>
        /// Creates a new MvcSiteMapProvider IHtmlHelper.
        /// </summary>
        /// <param name="helper">The helper.</param>
        /// <returns>
        /// A <see cref="MvcSiteMapHtmlHelper"/> instance 
        /// </returns>
        public static MvcSiteMapHtmlHelper MvcSiteMap(this IHtmlHelper helper)
        {
            return new MvcSiteMapHtmlHelper(helper, SiteMaps.Current);
        }

        /// <summary>
        /// Creates a new MvcSiteMapProvider IHtmlHelper.
        /// </summary>
        /// <param name="helper">The helper.</param>
        /// <param name="siteMap">The SiteMap.</param>
        /// <returns>
        /// A <see cref="MvcSiteMapHtmlHelper"/> instance
        /// </returns>
        public static MvcSiteMapHtmlHelper MvcSiteMap(this IHtmlHelper helper, ISiteMap siteMap)
        {
            return new MvcSiteMapHtmlHelper(helper, siteMap);
        }

        /// <summary>
        /// Creates a new MvcSiteMapProvider IHtmlHelper.
        /// </summary>
        /// <param name="helper">The helper.</param>
        /// <param name="siteMapCacheKey">The SiteMap Cache Key.</param>
        /// <returns>
        /// A <see cref="MvcSiteMapHtmlHelper"/> instance
        /// </returns>
        public static MvcSiteMapHtmlHelper MvcSiteMap(this IHtmlHelper helper, string siteMapCacheKey)
        {
            ISiteMap siteMap = SiteMaps.GetSiteMap(siteMapCacheKey);
            if (siteMap == null)
                throw new UnknownSiteMapException();
            return MvcSiteMap(helper, siteMap);
        }

    }
}
