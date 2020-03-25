

namespace Core.Modules.Web.Sitemap.mRSSModel.Channels.Items.MediaContents.Media
{
    using System.Xml.Serialization;

    public class Description
    {
        [XmlText]
        public string MediaDescription { get; set; }
    }
}
