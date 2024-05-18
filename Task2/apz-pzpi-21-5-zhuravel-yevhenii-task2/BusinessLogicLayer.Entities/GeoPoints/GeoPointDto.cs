﻿using System.ComponentModel.DataAnnotations;

namespace BusinessLogicLayer.Entities.GeoPoints
{
    public class GeoPointDto
    {

        [Key]
        public Guid FeederId { get; set; }
        public ICollection<double> Coordinates { get; set; } = new List<double>();
        public string Type { get; set; } = "Point";
    }
}
