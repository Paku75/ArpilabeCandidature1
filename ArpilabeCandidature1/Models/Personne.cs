using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ArpilabeCandidature1.Models
{
    public class Personne
    {
        [Key]
        public int id { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string nom { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string prenom { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string email { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(10)")]
        public string telephone { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(255)")]
        public string note { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string depatement { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(10)")]
        public string dateNaissance { get; set; }

    }
}
