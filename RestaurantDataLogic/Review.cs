//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RestaurantDataLogic
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    
    public partial class Review
    {
        [JsonIgnoreAttribute]
        public int id { get; set; }
        [JsonIgnoreAttribute]
        public int ReviewId { get; set; }

        public string Name { get; set; }
        public string Summary { get; set; }
        public double Rating { get; set; }
    
        public virtual Restaurant Restaurant { get; set; }
    }
}
