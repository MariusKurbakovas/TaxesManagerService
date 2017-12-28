using System;
using System.Collections.Generic;
using ProducerService.Models;

namespace ProducerService.DataManagers
{
    public interface ITaxDataManager
    {
        decimal GetTax(string municipality, DateTime date);
        void InsertScheduledTax(TaxModel newRecord);
        void ImportTaxData(List<TaxModel> newData);
        void ClearTaxData();
    }
}
