using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Commerce.Catalog.ContentTypes;
using EPiServer.Commerce.Catalog.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace CMS.Models.Commerce
{
    [CatalogContentType(DisplayName = "SiteNode", GUID = "a6b18fef-c3a6-45b2-8a10-d233820faa4c", Description = "")]
    public class SiteNode : NodeContent
    {
        
    }
}