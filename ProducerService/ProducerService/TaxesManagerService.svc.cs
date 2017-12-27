using System;
using System.Collections.Generic;
using System.Net;
using System.ServiceModel.Web;
using Newtonsoft.Json;
using ProducerService.DataManagers;
using ProducerService.Models;

namespace ProducerService
{
    public class TaxesManagerService : ITaxesManagerService
    {
        //TODO: Dependency injection
        private readonly ITaxDataManager _taxDataManager = new TaxDataManager();

        public decimal GetTax(string municipality, DateTime dateTime)
        {
            try
            {
                return _taxDataManager.GetTax(municipality, dateTime.Date);
            }
            catch (Exception)
            {
                OutgoingWebResponseContext response = WebOperationContext.Current.OutgoingResponse;
                response.StatusCode = HttpStatusCode.NotFound;
                return 0;
            }
        }

        public void InsertScheduledTax (TaxModel newRecord)
        {
            try
            {
                _taxDataManager.InsertScheduledTax(newRecord);
            }
            catch (Exception)
            {
                OutgoingWebResponseContext response = WebOperationContext.Current.OutgoingResponse;
                response.StatusCode = HttpStatusCode.InternalServerError;
            }
        }

        public void UploadMunicipalitiesDataJson (FileUploadModel file)
        {
            FileManager _fileManager = new FileManager();
            try
            {
                var fileText = _fileManager.GetTextFromFileByteStream(file.FileByteStream);
                var taxData = JsonConvert.DeserializeObject<List<TaxModel>>(fileText);
                _taxDataManager.ImportTaxData(taxData);
            }
            //TODO: deal with exception
            catch (JsonException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
