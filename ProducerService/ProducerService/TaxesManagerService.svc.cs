using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using ProducerService.DataManagers;
using ProducerService.Models;

namespace ProducerService
{
    public class TaxesManagerService : ITaxesManagerService
    {
        private readonly ITaxDataManager _taxDataManager = new TaxDataManager();

        public decimal GetTax(string municipality, DateTime dateTime)
        {
            return _taxDataManager.GetTax(municipality, dateTime.Date);
        }

        public void InsertScheduledTax (TaxModel newRecord)
        {
            _taxDataManager.InsertScheduledTax(newRecord);
        }

        public void UploadMunicipalitiesDataJson (FileUpload file)
        {
            FileManager _fileManager = new FileManager();
            var fileText = _fileManager.GetTextFromFileByteStream(file.FileByteStream);
            try
            {
                var taxData = JsonConvert.DeserializeObject<List<TaxModel>>(fileText);
                _taxDataManager.ImportTaxData(taxData);
            }
            //TODO: deal with exception
            catch (JsonException ex)
            {
                throw ex;
            }
        }
    }
}
