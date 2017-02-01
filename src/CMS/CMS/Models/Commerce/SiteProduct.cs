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
    [CatalogContentType(DisplayName = "SiteProduct", GUID = "7aeb5b89-b3d7-4800-9324-4233abccdcce", Description = "")]
    public class SiteProduct : ProductContent
    {
        
    }
}