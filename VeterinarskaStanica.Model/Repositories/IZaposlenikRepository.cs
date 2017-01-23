using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinarskaStanica.Model.Repositories
{
    public interface IZaposlenikRepository
    {
        List<Zaposlenik> GetAll();
        Zaposlenik GetById(int Id);
        Zaposlenik GetByOib(string OIB);
        Zaposlenik GetByKorisnickoIme(string KorisnickoIme);
        bool Add(Zaposlenik zaposlenik);
        bool Update(Zaposlenik zaposlenik);
        bool Delete(int Id);

        List<VrstaZaposlenika> GetAllVrstaZaposlenika();
        VrstaZaposlenika GetVrstaZaposlenikaById(int Id);
        bool AddVrstaZaposlenika(VrstaZaposlenika zaposlenik);
        bool UpdateVrstaZaposlenika(VrstaZaposlenika zaposlenik);
        bool DeleteVrstaZaposlenika(int Id);

    }
}
