using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinarskaStanica.Model.Repositories
{
    public interface ITerminRepository
    {
        List<Termin> GetAll();
        Termin GetById(int Id);
        bool Add(Termin Termin);
        bool Update(Termin Termin);
        bool Delete(int Id);
        List<Termin> GetAllByZivotinjaId(int Id);
        List<Termin> GetAllByZaposlenikId(int Id);

        List<Lijek> GetAllLijek();
        Lijek GetLijekById(int Id);
        bool AddLijek(Lijek Lijek);
        bool UpdateLijek(Lijek Lijek);
        bool DeleteLijek(int Id);

        List<VrstaZahvata> GetAllVrstaZahvata();
        VrstaZahvata GetVrstaZahvataById(int Id);
        bool AddVrstaZahvata(VrstaZahvata VrstaZahvata);
        bool UpdateVrstaZahvata(VrstaZahvata VrstaZahvata);
        List<Termin> GetAllByVlasnikId(int idVlasnik);
        bool DeleteVrstaZahvata(int Id);
        List<VrstaTermina> GetAllVrstaTermina();
        VrstaTermina GetVrstaTerminaById(int idVrstaTermina);
    }
}
