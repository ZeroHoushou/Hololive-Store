using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Hololive_Store.Common.Entities
{
    public class Department
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "The field {0} must contain less than {1} characteres.")]
        [Required]
        public string Name { get; set; }

        public ICollection<City> Citiess { get; set; }

        [DisplayName("Cities Number")]
        public int CitiesNumber => Citiess == null ? 0 : Citiess.Count;
        
        [NotMapped]
        public int IdCountry { get; set; }

    }

}
