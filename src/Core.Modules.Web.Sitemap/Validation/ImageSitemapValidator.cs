//-----------------------------------------------------------------------
// <copyright file="ImageSitemapValidator.cs" company="Code Miners Limited">
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

namespace Core.Modules.Web.Sitemap.Validation
{
    using System;
    using System.IO;
    using System.Reflection;
    using System.Xml;
    using System.Xml.Schema;
    using Model;
    using Serialization;

    public sealed class ImageSitemapValidator
    {
        public ValidationResult ValidateSitemap(ImageSitemap candidate)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer();
                string text = serializer.Serialize(candidate);

                XmlReaderSettings settings = new XmlReaderSettings();
                settings.Schemas.Add("http://www.google.com/schemas/sitemap-image/1.1", new XmlTextReader(LoadSchema()));
                settings.ValidationEventHandler += ValidationEventHandler;
                settings.ValidationFlags = settings.ValidationFlags | XmlSchemaValidationFlags.ReportValidationWarnings;
                settings.ValidationType = ValidationType.Schema;

                XmlDocument document = new XmlDocument();
                XmlReader reader = XmlReader.Create(new StringReader(text), settings);
                document.Load(reader);

                document.Validate(ValidationEventHandler);

                return new ValidationResult(true, "ok");
            }
            catch (Exception ex)
            {
                return new ValidationResult(false, ex.Message);
            }
        }

        private TextReader LoadSchema()
        {
            TextReader textreader;
            using (StreamReader reader = new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream("Core.Modules.Web.Sitemap.Validation.ImageSitemapSchema.xsd")))
            {
                string xsd = reader.ReadToEnd();

                textreader = new StringReader(xsd);
            }

            return textreader;
        }

        private static void ValidationEventHandler(object sender, ValidationEventArgs args)
        {
            if (args.Severity == XmlSeverityType.Warning || args.Severity == XmlSeverityType.Error)
            {
                if (args.Exception != null)
                {
                    throw args.Exception;
                }

                throw new XmlSchemaException("There is an unknown problem with the document");
            }
        }
    }
}