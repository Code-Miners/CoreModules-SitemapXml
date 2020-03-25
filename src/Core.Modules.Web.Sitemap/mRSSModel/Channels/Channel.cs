

namespace Core.Modules.Web.Sitemap.mRSSModel.Channels
{
    using System.Xml.Serialization;
    using System.Collections.Generic;
    using Core.Modules.Web.Sitemap.mRSSModel.Channels.Items;

    public class Channel
    {
        [XmlElement(ElementName = "title", Order = 1)]
        public string Title { get; set; }

        [XmlElement(ElementName = "link", Order = 2)]
        public string Link { get; set; }

        [XmlElement(ElementName = "description", Order = 3)]
        public string Description { get; set; }

        [XmlElement(ElementName = "item", Type = typeof(Item), Order = 4)]
        public List<Item> Items { get; set; }
    }
}
