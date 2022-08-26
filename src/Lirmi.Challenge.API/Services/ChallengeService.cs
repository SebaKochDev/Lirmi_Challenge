using Lirmi.Challenge.API.Context;
using Lirmi.Challenge.API.Models;
using System.Linq;

namespace Lirmi.Challenge.API.Services
{
    public interface IChallengeService
    {
        IEnumerable<ChallengeDTO> GetChallengeData();
    }
    public class ChallengeService : IChallengeService
    {
        private ChallengeDataContext _context;
        public ChallengeService(ChallengeDataContext context)
        {
          _context   = context;
        }

        
        public IEnumerable<ChallengeDTO> GetChallengeData()
        {
            try
            {
                var result = _context.Asignaturas
               .Select(x =>
               new ChallengeDTO
               {
                   asignatura = x.name,
                   curso = x.curso.name,
                   colegio = x.curso.colegio.name
               }).ToList();

                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }
    }
}
