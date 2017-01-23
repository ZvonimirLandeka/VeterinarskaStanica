using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinarskaStanica.Model.Repositories
{
    public interface IVlasnikRepository
    {
        List<Vlasnik> GetAll();
        Vlasnik GetById(int Id);
        Vlasnik GetByOib(string OIB);
        Vlasnik GetByKorisnickoIme(string KorisnickoIme);
        bool Add(Vlasnik zaposlenik);
        bool Update(Vlasnik zaposlenik);
        bool Delete(int Id);
    }
}
