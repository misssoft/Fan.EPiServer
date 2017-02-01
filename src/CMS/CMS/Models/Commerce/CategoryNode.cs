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
    [CatalogContentType(DisplayName = "BookNode", GUID = "4de9c757-b3dc-44b7-9b9c-32d36864de26", Description = "")]
    public class CategoryNode : NodeContent
    {
       
    }
}