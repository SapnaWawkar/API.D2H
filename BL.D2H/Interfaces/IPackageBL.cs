using Models.D2H.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BL.D2H.Interfaces
{
    public interface IPackageBL
    {
        List<Package> GetAll();
    }
}
