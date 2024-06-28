using System.ComponentModel.DataAnnotations;

namespace SchedulerApp.Models
{
    public class Events
    {
        

        [Key]
        public int EventID { get; set; }
        public string? Subject { get; set; }
        public string? Description { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string? ThemeColor { get; set; }
        public Boolean IsFUllDate { get; set;}
    }
}
