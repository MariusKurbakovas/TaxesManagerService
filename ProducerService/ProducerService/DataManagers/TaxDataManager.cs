using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ProducerService.DataModels;

namespace ProducerService.DataManagers
{
    public class TaxDataManager : ITaxDataManager
    {
        private DbContext context = new DataBaseModel();

        public List<ScheduledTaxesDataModel> GetAllMunicipalityTaxes(string municipality)
        {
            var municipalityTaxes = context.Set<ScheduledTaxesDataModel>().Include(x => x.Municipality)
                .Where(x => x.Municipality.Name == municipality).ToList();
            return municipalityTaxes;
        }

        public decimal GetTax(string municipality, DateTime date)
        {
            try
            {
                var tax = context.Set<ScheduledTaxesDataModel>().Include(x => x.Municipality)
                .Where(x => x.Municipality.Name == municipality && x.PeriodStart <= date && x.PeriodEnd >= date)
                .ToList()
                .OrderBy(x => x.PeriodEnd - x.PeriodStart)
                .First().Tax;

                return tax;
            }
            catch (InvalidOperationException e)
            {
                throw e;
            }
        }
    }
}