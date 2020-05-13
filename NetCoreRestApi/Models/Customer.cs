using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NetCoreRestApi.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required, StringLength(20)]
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
