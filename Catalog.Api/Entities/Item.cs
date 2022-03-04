using System;
using MongoDB.Bson.Serialization.Attributes;

namespace Catalog.Api.Entities
{
    [BsonIgnoreExtraElements]
    public class Item
    { 
       public Guid ID  {get; set;}
       public string Name { get; set; }
       public string Description { get; set; }
       public decimal Price { get; set; }
       public DateTimeOffset CreatedDate { get; set; }

    }
}