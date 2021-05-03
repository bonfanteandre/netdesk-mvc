using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetDesk.App.Models
{
    public class ClientViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Name { get; set; }

        [Required]
        [StringLength(13, MinimumLength = 8)]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 9)]
        public string Email { get; set; }
    }
}
