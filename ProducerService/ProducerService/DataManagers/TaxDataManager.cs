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
            var municipalityTaxes = context.Set<ScheduledTaxesDataModel>()
                .Include(x => x.Municipality)
                .Where(x => x.Municipality.Name == municipality).ToList();
            return municipalityTaxes;
        }

        public decimal GetTax(string municipality, DateTime date)
        {
            var tax = context.Set<ScheduledTaxesDataModel>()
                .Include(x => x.Municipality)
                .Where(x => x.Municipality.Name == municipality && x.PeriodStart <= date && x.PeriodEnd >= date)
                .ToList()
                //The tax with the shortests period is taken
                .OrderBy(x => x.PeriodEnd - x.PeriodStart)
                .First().Tax;

            return tax;
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
                PeriodStart = newEntry.PeriodStart.Date,
                PeriodEnd = newEntry.PeriodEnd.Date
            });

            context.SaveChanges();
        }

        //TODO: figure out how to deal with old data (keep it or delete it) when imporing from file
        public void ImportTaxData(List<TaxModel> newData)
        {
            var newDataMunicipalities = newData.Select(x => new MunicipalityDataModel
            {
                Name = x.Municipality
            }).Distinct().ToList();
            var existingMunicipalities = context.Set<MunicipalityDataModel>().ToList();
            foreach (var municipality in newDataMunicipalities)
            {
                if (!existingMunicipalities.Any(x => x.Name == municipality.Name))
                {
                    context.Set<MunicipalityDataModel>().Add(municipality);
                    existingMunicipalities.Add(municipality);
                }
            }
            foreach (var entry in newData)
            {
                context.Set<ScheduledTaxesDataModel>().Add(new ScheduledTaxesDataModel()
                {
                    Municipality = existingMunicipalities.First(x => x.Name == entry.Municipality),
                    Tax = entry.Tax,
                    PeriodStart = entry.PeriodStart.Date,
                    PeriodEnd = entry.PeriodEnd.Date
                });
            }
            context.SaveChanges();
        }

        public void ClearTaxData()
        {
            context.Database.ExecuteSqlCommand("delete from [dbo].[ScheduledTaxesDataModels]");
        }
    }
}