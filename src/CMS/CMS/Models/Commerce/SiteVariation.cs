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
    [CatalogContentType(DisplayName = "SiteVariation", GUID = "5bd4b21b-4514-461a-b27f-5d9e508bb532", Description = "")]
    public class SiteVariation : VariationContent
    {
        
    }
}