#  Codeminers Libraries: Xml Sitemap Interface

This library is a utility library for generating Xml sitemaps. Currently, it supports normal and image sitemaps with
news sitemaps in the pipeline.

This project is based on MvcSiteMap, a project on Github, and some elements of that project are present here. Those that
are keep their original MIT License. The rest is copyright Code Miners Limited and licensed under the LGPL.

## Setup and configuration

Currently this library is available from the public Nuget feed run by the company. If this code proves useful, we may release
it to Nuget.org.

The library uses a simple provider style setup. We've gone with the design prinicple of splitting up sitemaps and using 
a sitemap index. This is why there's a Sitemap type and an ImageSitemap type. Longer term there'll be a NewsSitemap type.

Included are MVC Action Result instances for these types as well.

The codebase has a very simple provider example that reads a configuration section to create a sitemap. This isn't a real
world example but shows how you might build a provider from a CMS API, database etc.

## Roadmap

Right now we don't have a .NET Core version of this library but that's in the pipeline. A lot of the work we do use
platforms and systems where .NET Core isn't available. That said, here's what we're thinking about:

* News Sitemap
* .NET Core


## Where this code has come from

In developing our website we were throwing some code together and decided we'd start releasing it in case someone found 
it useful. So we've repackaged our code into 'modules', adding in Sonar settings and tests then released them into
the wild.

If this code is of use to you, great! If not, no problem, there's a fancy search feature top left of this page. Happy 
hunting.

:rocket:
