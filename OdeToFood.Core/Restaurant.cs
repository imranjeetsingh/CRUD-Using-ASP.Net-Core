using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OdeToFood.Core
{

    public class Restaurant
    {
        public int Id { get; set; }
        [Required, StringLength(20)]

        public String Name { get; set; }

        [Required, StringLength(50)]
        public String Location { get; set; }

        public CuisineType Cuisine { get; set; }

    }
}
