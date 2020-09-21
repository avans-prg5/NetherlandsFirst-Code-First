using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AmericaSecond
{
    public class Country
    {
        [Key]
        public string ISOCode { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
    }
}
