using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ProducerService.DataModels;

namespace ProducerService.DataManagers
{
    public class TaxDataManager
    {
        private DbContext context = new DataBaseModel();

        public List<ScheduledTaxesDataModel> GetAllMunicipalityTaxes(string municipality)
        {
            var municipalityTaxes = context.Set<ScheduledTaxesDataModel>().Include(x => x.Municipality)
                .Where(x => x.Municipality.Name == municipality).ToList();
            return municipalityTaxes;
        }
    }
}