

namespace Core.Modules.Web.Sitemap.mRSSModel.Channels.Items.MediaContents.Media
{
    using System.Xml.Serialization;

    public class Thumbnail
    {
        [XmlAttribute(AttributeName = "url")]
        public string MediaThumbnailUrl { get; set; }
    }
}
