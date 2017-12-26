using System;
using ProducerService.DataManagers;
using ProducerService.Models;

namespace ProducerService
{
    public class TaxesManagerService : ITaxesManagerService
    {
        private readonly ITaxDataManager _taxDataManager = new TaxDataManager();

        public decimal GetTax(string municipality, DateTime dateTime)
        {
            return _taxDataManager.GetTax(municipality, dateTime.Date);
        }

        public void InsertScheduledTax (TaxModel newRecord)
        {
            _taxDataManager.InsertScheduledTax(newRecord);
        }
    }
}
