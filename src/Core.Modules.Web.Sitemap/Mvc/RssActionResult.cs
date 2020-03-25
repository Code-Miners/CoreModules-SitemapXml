

namespace Core.Modules.Web.Sitemap.Mvc
{
    using System.ServiceModel.Syndication;
    using System.Web.Mvc;
    using System.Xml;

    /// <summary>
    /// Action result for returning syndicated feed data 
    /// from an MVC action method
    /// </summary>
    public class RssActionResult : ActionResult
    {
        public SyndicationFeed Feed { get; set; }

        public override void ExecuteResult(ControllerContext context)
        {
            Rss20FeedFormatter rssFormatter = new Rss20FeedFormatter(Feed);
            context.HttpContext.Response.ContentType = "application/rss+xml";

            using (XmlWriter writer = XmlWriter.Create(context.HttpContext.Response.Output))
            {
                rssFormatter.WriteTo(writer);
            }
        }
    }
}

