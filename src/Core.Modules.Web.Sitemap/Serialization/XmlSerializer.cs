//-----------------------------------------------------------------------
// <copyright file="XmlSerializer.cs" company="Code Miners Limited">
//  Copyright (c) 2019 Code Miners Limited
//   
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//  
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
//  GNU Lesser General Public License for more details.
//  
//  You should have received a copy of the GNU Lesser General Public License
//  along with this program.If not, see<https://www.gnu.org/licenses/>.
// </copyright>
//-----------------------------------------------------------------------

namespace Core.Modules.Web.Sitemap.Serialization
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml;
    using System.Xml.Serialization;

    public class XmlSerializer : IXmlSerializer
    {
        private IXmlNamespaceBuilder NamespaceBuilder { get; }

        private TextWriter Writer { get; }

        private XmlWriterSettings Settings { get; }

        public XmlSerializer()
        {
            NamespaceBuilder = new XmlNamespaceBuilder();
            Writer = new Utf8EncodedStringWriter();

            Settings = new XmlWriterSettings
            {
                Encoding = Encoding.UTF8,
                NamespaceHandling = NamespaceHandling.OmitDuplicates
            };
        }

        public XmlSerializer(TextWriter writer, XmlWriterSettings settings)
        {
            NamespaceBuilder = new XmlNamespaceBuilder();
            Writer = TextWriter.Synchronized(writer);
            Settings = settings;
        }

        public string Serialize<T>(T data)
        {
            XmlSerializerNamespaces xmlSerializerNamespaces = GenerateNamespaces(data);

            System.Xml.Serialization.XmlSerializer xmlSerializer = new System.Xml.Serialization.XmlSerializer(typeof(T));

            using (XmlWriter writer = XmlWriter.Create(Writer, Settings))
            {
                xmlSerializer.Serialize(writer, data, xmlSerializerNamespaces);
            }

            return Writer.ToString();
        }

        public void SerializeToStream<T>(T data, Stream stream)
        {
            XmlSerializerNamespaces xmlSerializerNamespaces = GenerateNamespaces(data);

            System.Xml.Serialization.XmlSerializer xmlSerializer = new System.Xml.Serialization.XmlSerializer(typeof(T));

            using (XmlWriter writer = XmlWriter.Create(stream, Settings))
            {
                xmlSerializer.Serialize(writer, data, xmlSerializerNamespaces);
            }
        }

        private XmlSerializerNamespaces GenerateNamespaces<T>(T data)
        {
            IXmlNamespaceProvider namespaceProvider = data as IXmlNamespaceProvider;
            IEnumerable<string> namespaces = namespaceProvider != null ? namespaceProvider.GetNamespaces() : Enumerable.Empty<string>();
            XmlSerializerNamespaces xmlSerializerNamespaces = NamespaceBuilder.Create(namespaces);
            return xmlSerializerNamespaces;
        }
    }
}