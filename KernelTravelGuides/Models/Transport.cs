using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
namespace KernelTravelGuides.Models
{
    public class Transport
    {
        [Key]
        public int transport_id { get; set; }

        [Required]
        [Display(Name = "Transport Name")]
        public string transport_name { get; set; }

        [Required]
        [Display(Name = "Transport Number")]
        public string transport_number { get; set; }

        [Required]
        [Display(Name = "Transport Price")]
        public int transport_price { get; set; }

        [Required]
        [Display(Name = "Transport Rating")]
        public int transport_rating { get; set; }

        [MaxLength(8000)]
        [Required]
        [Display(Name = "Transport Description")]
        public string transport_desc { get; set; }


        [Required]
        [Display(Name = "Transport Status")]
        public bool transport_status { get; set; }


        [DataType(DataType.DateTime)]
        [Display(Name = "Transport Created Time")]
        public DateTime created_at { get; set; }



        [DataType(DataType.DateTime)]
        [Display(Name = "Transport Updated Time")]
        public DateTime updated_at { get; set; }

    }


    public class TransportCreatedate : Transport
    {

        public TransportCreatedate()
        {
            created_at = DateTime.UtcNow;
        }


    }

    public class TransportUpdatedat : Transport
    {

        public TransportUpdatedat()
        {
            created_at = DateTime.UtcNow;
        }




    }
}
