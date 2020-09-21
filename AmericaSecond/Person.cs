using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AmericaSecond
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(15)]
        public string TelephoneNumber { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        public Country Nationality { get; set; }

        public List<Car> OwnedVehicles { get; set; }
    }
}
