

namespace Core.Modules.Web.Sitemap.mRSSModel.Channels.Items.MediaContents.Media
{
    using System.Xml.Serialization;

    public class Player
    {
        [XmlAttribute(AttributeName = "url")]
        public string PlayerUrl { get; set; }
    }
}
