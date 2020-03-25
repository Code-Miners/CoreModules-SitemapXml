

namespace Core.Modules.Web.Sitemap.mRSSModel.Channels.Items
{

    using Core.Modules.Web.Sitemap.Serialization;
    using System.Xml.Serialization;
    using System.Collections.Generic;
    using Core.Modules.Web.Sitemap.mRSSModel.Channels.Items.MediaContents;

    public class Item
    {
        [XmlElement(ElementName = "link", Order = 1)]
        public string Link { get; set; }

        [XmlElement(ElementName = "content", Type = typeof(MediaContent), Order = 2, Namespace = XmlNamespaces.Mrss)]
        public List<MediaContent> Content { get; set; }
    }
}
