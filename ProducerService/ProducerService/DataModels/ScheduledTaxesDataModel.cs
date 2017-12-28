using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ProducerService.Models;

namespace ProducerService.DataModels
{
    public class ScheduledTaxesDataModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public virtual MunicipalityDataModel Municipality { get; set; }
        //TODO: figure out can taxes be scheduled in any way, or only yearly/monthly/weekly/daily
        [Column(TypeName = "Date")]
        public DateTime PeriodStart { get; set; }
        [Column(TypeName = "Date")]
        public DateTime PeriodEnd { get; set; }
        [Required]
        public decimal Tax { get; set; }
    }
}