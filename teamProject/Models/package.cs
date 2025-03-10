﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace teamProject.Models
{
    public class package
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Type { get; set; }

        public string Notes { get; set; }


        public bool Active { get; set; }

        public int Price { get; set; }


        //nav ?? virtual??
        //nav ?virtual?

        [JsonIgnore]
        public virtual List<Provider_Package>? Provider_Packages { get; set; }
    }
}
