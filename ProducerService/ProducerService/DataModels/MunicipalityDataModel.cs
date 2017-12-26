using System.ComponentModel.DataAnnotations;

namespace ProducerService.DataModels
{
    public class MunicipalityDataModel
    {
        [Key]
        [MaxLength(255)]
        public string Name { get; set; }
    }
}