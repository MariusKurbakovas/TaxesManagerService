using System;
using ProducerService.DataManagers;

namespace ProducerService
{
    public class TaxesManagerService : ITaxesManagerService
    {
        private readonly ITaxDataManager _taxDataManager = new TaxDataManager();

        public decimal GetTax(string municipality, DateTime dateTime)
        {
            return _taxDataManager.GetTax(municipality, dateTime);
        }
    }
}
