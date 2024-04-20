﻿using DataAccessLayer.Entities.Attributes;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Entities
{
    [CollectionName("animal-types")]
    public class AnimalType : ICloneable
    {
        [Key]
        [BsonId]
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
