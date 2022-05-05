using System.ComponentModel.DataAnnotations;

namespace Kyh_Annons.Dtos
{
    public record CreateOrUpdateAnnonsDTO
    {
       
        [Required]
        public string KaTegorier { get; set; }
        
        public decimal Pris { get; set; }
        [Required]
        public string KaTegorierNamn { get; set; }
        public string Plats { get; set; }
    }
}
