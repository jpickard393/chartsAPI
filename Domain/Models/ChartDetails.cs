using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChartsAPI.Domain.Models
{
    using Interfaces;
    
    public class ChartDetails : IEntity<int>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }  
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        [ForeignKey("ChartType")]
        public int Type { get; set; }
        public ChartType ChartType { get; set; }

    }
}
