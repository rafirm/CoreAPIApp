using System.ComponentModel.DataAnnotations;

namespace commander.Dtos
{
    public class CommandDeleteDto
    {
    
        
        [Required]
        public string HowTo { get; set; }
        [Required]
        public string Line { get; set; }
        [Required]
        public string Platform { get; set; }

    }
}


