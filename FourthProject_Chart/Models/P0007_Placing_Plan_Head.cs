using System.ComponentModel.DataAnnotations;

namespace FourthProject_Chart.Models
{
    public class P0007_Placing_Plan_Head
    {
        [Key]
        public int placingid { get; set; }

        [Display(Name = "打込み間隔")]
        public double driving_interval { get; set; }

        [Display(Name = "自由落下高さ")]
        public double free_fall_height { get; set; }

        [Display(Name = "打上げ方法")]
        public string lauch_method { get; set; }

        [Display(Name = "1層の打上がり高さ")]
        public double layer_height { get; set; }

        [Display(Name = "層数")]
        public int layer_number { get; set; }
    }
}
