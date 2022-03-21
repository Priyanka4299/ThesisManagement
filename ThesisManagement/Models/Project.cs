using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;


namespace ThesisManagement.Models
{

    [Table("Projects")]
    public class Project
    {

        [Display(Name = "Project ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectId { get; set; }

        [Display(Name = "Title of the Project")]
        [Required]
        [StringLength(50)]
        
        public string ProjectTitle { get; set; }

        [Display(Name = "Description of the Project")]
        [Required]
        [StringLength(50)]
        
        public string ProjectDescription { get; set; }

        [Required]
        [ForeignKey(nameof(Project.Student))]
        public string EnrollmentID { get; set; }

        [Display(Name = " Start Date ")]
        [Required]

        public DateTime StartDate { get; set; }

        [Display(Name = " End Date ")]
        [Required]

        public DateTime EndDate { get; set; }


        #region Navigational Properties to the Student Model (1:0 mapping)

        public Student Student { get; set; }

        #endregion
        #region Navigational Properties to the Submission Detail Model (1:0 mapping)

        public SubmissionDetail SubmissionDetail { get; set; }

        #endregion
    }

}

