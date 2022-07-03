using System;
using System.ComponentModel.DataAnnotations;

namespace commander.Dtos
{
    public class MasterUsersReadDto
    {
    
       [Key]
        public int Id { get; set; }
        [Required]
        public string UserCode { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public short UserRoleId { get; set; }
        [Required]
        public short DepartmentId { get; set; }

    
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormatAttribute(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        public DateTime DateCreated{ get; set; }
        

    }
}


