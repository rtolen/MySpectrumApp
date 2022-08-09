using System.Collections.Generic;
using System.Threading.Tasks;
using MySpectrumApp.Services;
using MySpectrumApp.Models;

namespace MySpectrumApp.Interfaces
{
    public class MySpectrumAppManager
    {
        IRestService restService;

        public MySpectrumAppManager(IRestService service)
        {
            restService = service;
        }

        public async Task<Data> GetBitcoinLimitsAsync()
        {
            var s = await restService.BitcoinLimitsAsync();
            return s;
        }

        public async Task<string> GetBitcoinLimitsAsync2()
        {
            var s = await restService.BitcoinLimitsAsync2();
            return s;
        }
    }
}
