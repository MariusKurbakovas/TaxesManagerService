using System;
using System.ServiceModel;
using ProducerService.Models;

namespace ProducerService
{
    [ServiceContract]
    public interface ITaxesManagerService
    {
        [OperationContract]
        decimal GetTax(string municipality, DateTime dateTime);

        [OperationContract]
        void InsertScheduledTax(TaxModel newRecord);

        [OperationContract]
        void UploadMunicipalitiesDataJson(FileUploadModel file);
    }
}
