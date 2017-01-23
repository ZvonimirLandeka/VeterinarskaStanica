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
        bool Add(Vlasnik Vlasnik);
        bool Update(Vlasnik Vlasnik);
        bool Delete(int Id);
    }
}
