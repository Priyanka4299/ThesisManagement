using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ThesisManagement.Models;
using ThesisManagement.Models.Enums;

namespace ThesisManagement.Models
{
    [Table("Faculty")]
    public class Faculty
    {
    
        [Display(Name = "User ID")]
        [ForeignKey(nameof(Faculty.User))]
        public Guid UserID { get; set; }

        [Required]
        [Key]
        [Display(Name ="Faculty ID")]
        [StringLength(20, ErrorMessage ="{0} cannot be more than {1}")]
        public string FacultyId { get; set; }

        

        [Display(Name = "Type of Faculty")]
        [Required(ErrorMessage = "{0} cannot be empty.")]
        [MinLength(3, ErrorMessage = "{0} should have more than {1} characters.")]
        [StringLength(25, ErrorMessage = "{0} cannot contain more than {1} characters.")]
        public string FacultyType { get; set; }

        
        
       


        #region

        public MyIdentityUser User { get; set; }

        //[ForeignKey(nameof(Faculty.Student))]
        //public int UserId { get; set; }

        //public Student Student { get; set; }

        #endregion
    }
}