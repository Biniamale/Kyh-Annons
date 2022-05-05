using Kyh_Annons.Models;

namespace Kyh_Annons.Repo
{
    public class InMemAnnonsRepo : IAnnons
    {
        private List<Annons> _Annonser;
        public InMemAnnonsRepo()
        {
            _Annonser = new() { new Annons { Id = Guid.NewGuid(), KaTegorier = "Annons 0", Pris = 10, KaTegorierNamn = "String", Plats = "string" } };
        }
        public void CreateAnnons(Annons annons)
        {
            _Annonser.Add(annons);
        }

        public void DeleteAnnons(Guid id)
        {
            var annonsIndex = _Annonser.FindIndex(x => x.Id == id);
            if (annonsIndex > -1)
                _Annonser.RemoveAt(annonsIndex);
        }

        public Annons GetAnnons(Guid id)
        {
            var Annons = _Annonser.Where(x => x.Id == id).SingleOrDefault();
            return Annons;
        }

        public IEnumerable<Annons> GetAnnonser()
        {
            return _Annonser;
            
        }

        public void UpdateAnnons(Guid id, Annons annons)
        {
            var annonsIndex = _Annonser.FindIndex(x => x.Id == id);
            if (annonsIndex > -1)
                _Annonser[annonsIndex] = annons;

        }
    }
}
