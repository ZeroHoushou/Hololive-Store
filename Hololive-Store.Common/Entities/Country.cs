﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;

namespace Hololive_Store.Common.Entities
{
    public class Country
    { 
        public int Id { get; set; }

        [MaxLength(50,ErrorMessage ="The field {0} must contain less than {1} characteres.")] 
        [Required]
        public string Name { get; set; }
        public ICollection<Department> Departments { get; set; }
        [DisplayName("Departments Number")]
        public int DepartmentsNumber => Departments == null ? 0 : Departments.Count;
        [JsonIgnore]
        [NotMapped]
        public int IdCountry { get; set; }
    }
}
