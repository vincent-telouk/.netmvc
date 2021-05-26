using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3MVC.Models
{

    [Index(nameof(nom), nameof(prenom), Name = "IX_Employee", IsUnique = false)]
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nom Employé")]
        [StringLength(20)]
        [Column(TypeName = "varchar")]
        public string nom { get; set; }
        [Display(Name = "Prénom Employé")]
        [StringLength(20)]
        public string prenom { get; set; }
        [Display(Name = "Date Entrée")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? DateEntree { get; set; }



        private decimal? _CA = 0;
        [Display(Name = "Chiffre d'affaire")]
        [DisplayFormat(DataFormatString = "{0:# ##0.00 €}")]
        [Column(TypeName = "decimal(16,2)")]
        public decimal? CA
        {
            get => _CA ?? 0;
            set => _CA = value;
        }
    }
}
        


