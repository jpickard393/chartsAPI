using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChartsAPI.Domain.Models
{
    using Interfaces;
    using System.Runtime.Serialization;

    public class ChartType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [DataMember(Name ="ChartType")]
        public string ChartTypeName { get; set; }
    }
}
