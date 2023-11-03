using PersonelSystem_EL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelSystem_DL.ContextInfo
{
    public class MyContext :DbContext
    {
        public DbSet<Personel> Personels { get; set; }
    }
}
