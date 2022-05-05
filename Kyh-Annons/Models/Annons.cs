using System.ComponentModel.DataAnnotations;

namespace Kyh_Annons.Models
{
    public class Annons
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string KaTegorier { get; set; }
        [Required]
        public decimal Pris { get; set; }
        [Required]
        public string KaTegorierNamn { get; set; }
        [Required]
        public string Plats { get; set; }
    }

}
