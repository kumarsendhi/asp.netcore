using Microsoft.ServiceFabric.Services.Remoting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStatefulService.Interface
{
    public interface ICounter : IService
    {
        Task<long> GetCountAsync();
    }
}
