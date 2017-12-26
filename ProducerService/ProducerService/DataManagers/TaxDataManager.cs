using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ProducerService.DataModels;
using ProducerService.Models;

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
                var tax = context.Set<ScheduledTaxesDataModel>()
                    .Include(x => x.Municipality)
                    .Where(x => x.Municipality.Name == municipality && x.PeriodStart <= date && x.PeriodEnd >= date)
                    .ToList()
                    .OrderBy(x => x.PeriodEnd - x.PeriodStart)
                    .First().Tax;

                return tax;
            }
            //TODO: no entry found
            catch (InvalidOperationException e)
            {
                throw e;
            }
        }

        public void InsertScheduledTax(TaxModel newEntry)
        {
            var municipality = context.Set<MunicipalityDataModel>()
                .FirstOrDefault(x => x.Name == newEntry.Municipality);
            if (municipality == null)
            {
                municipality = new MunicipalityDataModel()
                {
                    Name = newEntry.Municipality
                };
                context.Set<MunicipalityDataModel>().Add(municipality);
            }
            context.Set<ScheduledTaxesDataModel>().Add(new ScheduledTaxesDataModel()
            {
                Municipality = municipality,
                Tax = newEntry.Tax,
                PeriodStart = newEntry.PeriodStart,
                PeriodEnd = newEntry.PeriodEnd
            });
            context.SaveChanges();
        }
    }
}