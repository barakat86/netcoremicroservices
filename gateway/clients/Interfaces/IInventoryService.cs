using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gateway.clients.Interfaces
{
    public interface IInventoryService
    {
        Task<string[]> GetValues();
    }
}