using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AmericaSecond
{
    public class Car
    {
        [Key]
        public string LicensePlate { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public Person Owner { get; set; }
        public DateTime Built { get; set; }
    }
}
