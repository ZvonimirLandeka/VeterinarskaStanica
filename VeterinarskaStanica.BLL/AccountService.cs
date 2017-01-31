using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinarskaStanica.DAL.Repository;

namespace VeterinarskaStanica.BLL
{
    public class AccountService
    {
        private ZaposlenikRepository ZaposlenikRepository;
        private VlasnikRepository VlasnikRepository;
        public AccountService()
        {
            ZaposlenikRepository = new ZaposlenikRepository();
            VlasnikRepository = new VlasnikRepository();
        }

        public bool CheckLogin(string KorisnickoIme, string Lozinka)
        {
            var Vlasnik= VlasnikRepository.GetByKorisnickoIme(KorisnickoIme);
            if (Vlasnik == null)
            {
                return false;
            }
            return Vlasnik.Lozinka.Equals(Lozinka);
            
        }

    }
}
