using System;
using System.IO;

namespace ConsumerApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var proxy = new TaxesManagerService.TaxesManagerServiceClient();

            //Deleting all taxes from the service
            try
            {
                proxy.ClearTaxData();
                Console.WriteLine("Tax data cleared successfuly.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed to delete data.");
                Console.WriteLine(e.Message);
            }

            //Importing municipalities data from json file
            string pathSource = "../../data.json";
            try
            {
                using (FileStream fsSource = new FileStream(pathSource,
                FileMode.Open, FileAccess.Read))
                {
                    proxy.UploadMunicipalitiesDataJson(fsSource);
                }
                Console.WriteLine("File import successful.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed to import file.");
                Console.WriteLine(e.Message);
            }

            //Geting taxes of municipality at specified date
            try
            {
                Console.WriteLine(proxy.GetTax("Vilnius", DateTime.Now.AddYears(-1)));
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed to find specified tax info.");
                Console.WriteLine(e.Message);
            }

            try
            {
                Console.WriteLine(proxy.GetTax("Vilnius", DateTime.Parse("2016-12-25")));
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed to find specified tax info.");
                Console.WriteLine(e.Message);
            }

            //Inserting new scheduled tax
            var scheduledTaxToAdd = new TaxesManagerService.TaxModel()
            {
                Municipality = "Vilnius",
                PeriodStart = DateTime.Parse("2016-05-04"),
                PeriodEnd = DateTime.Parse("2016-07-02"),
                Tax = (decimal)0.5
            };
            try
            {
                proxy.InsertScheduledTax(scheduledTaxToAdd);
                Console.WriteLine("New tax inserted successfuly.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed to insert new tax.");
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
