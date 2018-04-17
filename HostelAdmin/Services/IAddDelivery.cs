using HostelAdmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelAdmin.Services
{
    interface IAddDelivery
    {
        void AddDelivery(ВыдачаИнвентаря item);
    }
}
