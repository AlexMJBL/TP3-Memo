using System.ComponentModel.DataAnnotations;

namespace MemoApi.Models
{
    public class Compte
    {
        [Key]
        public string Id { get; set; }
        [Required]
        [StringLength(150)]
        public string NomUtilisateur { get; set; }
        [Required]
        [StringLength(150)]
        public string MotDePasse { get; set; }
        [Required]
        public DateTime DateCreation { get; set; }
        public DateTime? DateDerniereConnexion { get; set; }

        public ICollection<Memo> Memos { get; set; } = new List<Memo>();


    }
}
