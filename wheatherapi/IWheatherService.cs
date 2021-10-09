using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace wheatherapi
{
    public interface IWheatherService
    {
        Task<string> Get(string cityName);
       
    }
}
