using System;
using System.ComponentModel.DataAnnotations;

namespace commander.Models
{
    public class MasterUser
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

        private DateTime? dateCreated = null;
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormatAttribute(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        public DateTime DateCreated
        {
            get
            {
                return this.dateCreated.HasValue
                   ? this.dateCreated.Value
                   : DateTime.Now;
            }

            set { this.dateCreated = value; }
        }

    }
}


