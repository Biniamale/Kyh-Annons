using Kyh_Annons.Models;

namespace Kyh_Annons.Repo
{
    public interface IAnnons
    {
        public IEnumerable<Annons> GetAnnonser();
        public Annons GetAnnons(Guid id);
        public void CreateAnnons(Annons annons);
        public void UpdateAnnons(Guid id, Annons annons);
        public void DeleteAnnons(Guid id);
            
    }
}
