using System;
using ProducerService.Models;

namespace ProducerService.DataManagers
{
    public interface ITaxDataManager
    {
        decimal GetTax(string municipality, DateTime date);
        void InsertScheduledTax(TaxModel newRecord);
    }
}
