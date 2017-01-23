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
        bool Add(Zaposlenik Zaposlenik);
        bool Update(Zaposlenik Zaposlenik);
        bool Delete(int Id);

        List<VrstaZaposlenika> GetAllVrstaZaposlenika();
        VrstaZaposlenika GetVrstaZaposlenikaById(int Id);
        bool AddVrstaZaposlenika(VrstaZaposlenika VrstaZaposlenika);
        bool UpdateVrstaZaposlenika(VrstaZaposlenika VrstaZaposlenika);
        bool DeleteVrstaZaposlenika(int Id);

    }
}
