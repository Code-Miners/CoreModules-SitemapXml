//-----------------------------------------------------------------------
// <copyright file="SimpleProviderTests.cs" company="Code Miners Limited">
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

namespace LibraryTests
{
    using System.Linq;
    using Core.Modules.Web.Sitemap.Model;
    using Core.Modules.Web.Sitemap.Providers;
    using NUnit.Framework;

    [TestFixture]
    public class SimpleProviderTests
    {
        [Test]
        public void SitemapFromConfigTest()
        {
            ISitemapProvider provider = new ConfiguredSitemapProvider();

            Sitemap data = provider.GetSiteMap();

            Assert.IsNotNull(data, "No sitemap returned");
            Assert.IsTrue(data.Nodes != null && data.Nodes.Any(), "No nodes in sitemap");                
        }
    }
}
