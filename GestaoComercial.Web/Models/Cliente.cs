using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GestaoComercial.Web.Models
{

    [Table("Cliente")]

    public partial class Cliente
    {

        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(255)]
        public string NomeCompleto { get; set; }

        [StringLength(255)]
        public string NomeFantasia { get; set; }

        [Required]
        [StringLength(15)]
        public string CPF { get; set; }




    }
}