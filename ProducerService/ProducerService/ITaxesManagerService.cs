using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using ProducerService.Models;

namespace ProducerService
{
    [ServiceContract]
    public interface ITaxesManagerService
    {
        [OperationContract]
        decimal GetTax(string municipality, DateTime dateTime);

        [OperationContract(IsOneWay = true)]
        void InsertScheduledTax(TaxModel newRecord);

        [OperationContract(IsOneWay = true)]
        void UploadMunicipalitiesDataJson(FileUpload file);
    }
}
