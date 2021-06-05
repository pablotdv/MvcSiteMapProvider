using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;

namespace MvcSiteMapProvider.Web.Html
{
    /// <summary>
    /// MvcSiteMapHtmlHelper class
    /// </summary>
    public class MvcSiteMapHtmlHelper
    {
        /// <summary>
        /// Gets or sets the HTML helper.
        /// </summary>
        /// <value>The HTML helper.</value>
        public IHtmlHelper HtmlHelper { get; protected set; }

        /// <summary>
        /// Gets or sets the sitemap.
        /// </summary>
        /// <value>The sitemap.</value>
        public ISiteMap SiteMap { get; protected set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MvcSiteMapHtmlHelper"/> class.
        /// </summary>
        /// <param name="htmlHelper">The HTML helper.</param>
        /// <param name="siteMap">The sitemap.</param>
        public MvcSiteMapHtmlHelper(IHtmlHelper htmlHelper, ISiteMap siteMap)
            : this(htmlHelper, siteMap, true)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MvcSiteMapHtmlHelper"/> class.
        /// </summary>
        /// <param name="htmlHelper">The HTML helper.</param>
        /// <param name="siteMap">The sitemap.</param>
        /// <param name="useViewEngine"><c>true</c> to use the internal view engine; otherwise <c>false</c></param>
        internal MvcSiteMapHtmlHelper(IHtmlHelper htmlHelper, ISiteMap siteMap, bool useViewEngine)
        {
            if (htmlHelper == null)
                throw new ArgumentNullException("htmlHelper");
            if (siteMap == null)
                throw new ArgumentNullException("siteMap");

            HtmlHelper = htmlHelper;
            SiteMap = siteMap;

            //TODO: revisar
            //if (useViewEngine)
            //    MvcSiteMapProviderViewEngine.Register();
        }

        /// <summary>
        /// Creates the HTML helper for model.
        /// </summary>
        /// <typeparam name="TModel">The type of the model.</typeparam>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        public IHtmlHelper<TModel> CreateHtmlHelperForModel<TModel>(TModel model)
        {
            throw new NotImplementedException();
            //return new HtmlHelper<TModel>(HtmlHelper.ViewContext, new ViewDataContainer<TModel>(model));
        }
    }
}
