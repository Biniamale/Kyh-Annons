using System.ComponentModel.DataAnnotations;

namespace Kyh_Annons.Dtos
{
    public record AnnonsDTO
    {
        public Guid Id { get; set; }
        [Required]
        public string KaTegorier { get; set; }
        [Required]
        public decimal Pris { get; set; }
        public string KaTegorierNamn { get; set; }
        public string Plats { get; set; }


    }
}
