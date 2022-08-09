using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MySpectrumApp.Models;

namespace MySpectrumApp.Services
{
    public interface IRestService
    {
        //Task<string> BitcoinLimitsAsync();

        Task<Data> BitcoinLimitsAsync();

        Task<string> BitcoinLimitsAsync2();
    }
}
