using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinarskaStanica.Model.Repositories
{
    public interface IZivotinjaRepository
    {
        List<Zivotinja> GetAll();
        Zivotinja GetById(int Id);
        bool Add(Zivotinja Zivotinja);
        bool Update(Zivotinja Zivotinja);
        bool Delete(int Id);

        List<Zivotinja> GetAllByVlasnikId(int Id);
        Zivotinja GetByBrojCipa(string BrojCipa);

        List<VrstaZivotinje> GetAllVrstaZivotinje();
        VrstaZivotinje GetVrstaZivotinjeById(int Id);
        bool AddVrstaZivotinje(VrstaZivotinje VrstaZivotinje);
        bool UpdateVrstaZivotinje(VrstaZivotinje VrstaZivotinje);
        bool DeleteVrstaZivotinje(int Id);

        List<PasminaZivotinje> GetAllPasminaZivotinje();
        PasminaZivotinje GetPasminaZivotinjeById(int Id);
        bool AddPasminaZivotinje(PasminaZivotinje PasminaZivotinje);
        bool UpdatePasminaZivotinje(PasminaZivotinje PasminaZivotinje);
        bool DeletePasminaZivotinje(int Id);

        List<Bolest> GetAllBolest();
        Bolest GetBolestById(int Id);
        bool AddBolest(Bolest Bolest);
        bool UpdateBolest(Bolest Bolest);
        bool DeleteBolest(int Id);


    }
}
