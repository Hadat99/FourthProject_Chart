using System.ComponentModel.DataAnnotations;

namespace FourthProject_Chart.Models
{
    public class P0008_Compaction
    {
        [Key]
        public int compactionid { get; set; }

        [Required]
        public int siteid { get; set; }

        [Required]
        public int group_id { get; set; }

        public int team_number { get; set; }

        public int vibrator_pi_50 { get; set; }

        public int vibrator_pi_50_line { get; set; }

        public int vibrator_pi_40 { get; set; }

        public int vibrator_pi_40_line { get; set; }

        public int shuttering_vibrator { get; set; }

        [Display(Name = "バイブ挿入間隔")]
        public int insertion_interval { get; set; }

        [Display(Name = "締固め作業高さ")]
        public double compaction_work_height { get; set; }

        [Display(Name = "締固め時間")]
        public int compaction_time { get; set; }

        [Display(Name = "再振動（後追い）")]
        public int re_vibration_follow_up { get; set; }

        [Display(Name = "型枠バイブ")]
        public int shuttering_vibration { get; set; }

    }
}
