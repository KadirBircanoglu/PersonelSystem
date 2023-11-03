using PersonelSystem_EL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelSystem_BL
{
    public interface IPersonelService
    {
        List<Personel> GetPersonelList();
        Personel GetPersonel(int id);
        void PersonelAdd(Personel p);
        void PersonelDelete(Personel p);
        void PersonelUpdate(Personel p);

    }
}
