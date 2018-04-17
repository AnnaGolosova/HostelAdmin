using HostelAdmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelAdmin.Services
{
    interface IAddOccupancy
    {
        void AddOccupancy(Заселение item);
    }
}
