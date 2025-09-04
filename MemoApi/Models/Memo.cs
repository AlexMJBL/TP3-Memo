using System.ComponentModel.DataAnnotations;

namespace MemoApi.Models
{
    public class Memo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string Titre { get; set; }
        [Required]
        [StringLength(150)]
        public string Description { get; set; }
        [Required]
        public DateTime DateCreation { get; set; }

        [Required]
        [StringLength(50)]
        public string IdCompte { get; set; }

        public Compte Compte { get; set; }


    }
}
