using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace KernelTravelGuides.Models
{
    public class TravelCategory
    {
        [Key]
        public int tra_category_id { get; set; }

        [Required]
        [Display(Name = "Travel Category Name")]
        public string tra_category_name { get; set; }

        [MaxLength(8000)]
        [Required]
        [Display(Name = "Travel Category Description")]
        public string tra_category_desc { get ; set; }


        [Required]
        [Display(Name = "Travel Category Status")]
        public bool tra_category_status { get; set; }


        [DataType(DataType.DateTime)]
        [Display(Name = "Travel Category Created Time")]
        public DateTime created_at { get; set; }



        [DataType(DataType.DateTime)]
        [Display(Name = "Travel Category Updated Time")]
        public DateTime updated_at { get; set; }

      
    }


    public class TravelCategoryCreatedate : TravelCategory
    {

        public TravelCategoryCreatedate()
        { 
            created_at = DateTime.UtcNow;
        }




    }

    public class TravelCategoryUpdatedat : TravelCategory
    {

        public TravelCategoryUpdatedat()
        {
            created_at = DateTime.UtcNow;
        }




    }
}

