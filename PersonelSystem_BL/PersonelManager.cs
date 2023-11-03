using PersonelSystem_DL.Repositories;
using PersonelSystem_EL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace PersonelSystem_BL
{
    public class PersonelManager : IPersonelService
    {
        IPersonelRepo _personelRepo;

        public PersonelManager(IPersonelRepo personelRepo)
        {
            _personelRepo = personelRepo;
        }

        public Personel GetPersonel(int id)
        {
            try
            {
                return _personelRepo.Get(x => x.Id == id);
            }
            catch (Exception ex )
            {

                throw ex;
            }
        }

        public List<Personel> GetPersonelList()
        {
            try
            {
                return _personelRepo.List();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void PersonelAdd(Personel p)
        {
            try
            {
                _personelRepo.Insert(p);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void PersonelDelete(Personel p)
        {
            _personelRepo.Delete(p);
        }

        public void PersonelUpdate(Personel p)
        {
            _personelRepo.Update(p);
        }
    }
    
}
