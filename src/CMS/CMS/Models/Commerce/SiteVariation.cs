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
    [CatalogContentType(DisplayName = "SiteVariation", GUID = "36719426-427c-4f48-9d31-5158ce021bb2", Description = "")]
    public class SiteVariation : VariationContent
    {
       
    }
}