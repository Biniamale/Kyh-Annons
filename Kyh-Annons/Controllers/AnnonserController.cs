using Kyh_Annons.Data;
using Kyh_Annons.Dtos;
using Kyh_Annons.Models;
using Kyh_Annons.Repo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace Kyh_Annons.Controllers
{
    [ApiController]
    [Route("annonser")]
    [Authorize]
    public class AnnonserController : ControllerBase
    {
        private IAnnons _AnnonsRepo;
        public readonly ApplicationDbContext _context;
        
        
        public AnnonserController(IAnnons annonsRepo, ApplicationDbContext context)
        {
           
            _context = context;
            _AnnonsRepo = annonsRepo;
            
            //_AnnonsRepo = new InMemAnnonsRepo();
        }
        [HttpGet]
        public ActionResult<IEnumerable<AnnonsDTO>> GetAnnonser()
        {
            return _AnnonsRepo.GetAnnonser().Select(x => new AnnonsDTO { Id = x.Id, KaTegorier = x.KaTegorier, Pris = x.Pris, KaTegorierNamn = x.KaTegorierNamn, Plats = x.Plats }).ToList();
        }
        [HttpGet("{id}")]
        public ActionResult<AnnonsDTO> GetAnnons(Guid id)
        {

            var Annons = _AnnonsRepo.GetAnnons(id);
            if (Annons == null)
                return NotFound();
            var annonsDTO = new AnnonsDTO { Id = Annons.Id, KaTegorier = Annons.KaTegorier, Pris = Annons.Pris, KaTegorierNamn = Annons.KaTegorierNamn, Plats = Annons.Plats };
            return annonsDTO;

        }
        [HttpPost]
        public ActionResult CreateAnnons(CreateOrUpdateAnnonsDTO annons)
        {
            var myannons = new Annons();
            myannons.Id = Guid.NewGuid();
            myannons.KaTegorier = annons.KaTegorier;
            myannons.Pris = annons.Pris;
            myannons.KaTegorier = annons.KaTegorier;
            myannons.Plats = annons.Plats;

            _AnnonsRepo.CreateAnnons(myannons);
            return Ok();
        }
        [HttpPut("{id}")]
        public ActionResult UpdateAnnons(Guid id, CreateOrUpdateAnnonsDTO annons)
        {
            var myannons = _AnnonsRepo.GetAnnons(id);
            if (myannons == null)
                return NotFound();
            myannons.KaTegorier = annons.KaTegorier;
            myannons.Pris = annons.Pris;
            myannons.KaTegorierNamn = annons.KaTegorier;
            myannons.Plats = annons.Plats;

            _AnnonsRepo.UpdateAnnons(id, myannons);
            return Ok();
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteAnnons(Guid id)
        {
            var annons = _AnnonsRepo.GetAnnons(id);
            if (annons == null)
                return NotFound();

            _AnnonsRepo.DeleteAnnons(id);
            return Ok();
        }
        
    }
  }
    


