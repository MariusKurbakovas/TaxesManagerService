using System.Data.Entity;

namespace ProducerService.DataModels
{
    public class DataBaseModel : DbContext
    {
        public DataBaseModel() : base()
        {

        }

        public virtual DbSet<MunicipalityDataModel> Municipality { get; set; }
        public virtual DbSet<ScheduledTaxesDataModel> ScheduledTaxes { get; set; }
    }
}