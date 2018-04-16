using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelAdmin.Services
{
    public enum DeleteState
    {
        Success = 0,
        HasReferences,
        HasInventory,
        ConnectionError,
    }
}
