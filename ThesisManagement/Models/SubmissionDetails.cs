﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ThesisManagement.Models
{
    [Table("SubmissionDetails")]
    public class SubmissionDetail
    {
        [Display(Name = "Submission ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SubmissionId { get; set; }


        [Display(Name = "Enter Project Id")]
        [ForeignKey(nameof(SubmissionDetail.ProjectId))]

        public int ProjectId { get; set; }


        [Display(Name = "Enter Description")]
        [Required]
        [MinLength(2)]
        [StringLength(60)]
        [Column("varchar")]
        public string SubmissionDesc { get; set; }


        [Display(Name = "Sumission Due Date:")]
        [Required(ErrorMessage = "Required")]
 
        public DateTime SubmissionDueOn { get; set; }


        [Display(Name = "Submission Date:")]
        [Required(ErrorMessage = "Required")]

        public DateTime SubmissionOn { get; set; }


        [Required(ErrorMessage = "Upload Submission File")]
        [StringLength(150)]
        public string SubmissionFile { get; set; }

        [StringLength(60)]
        public string FileContentType { get; set; }




        [Required]
        public string ReviewedBy { get; set; }


        [Required]
        [RegularExpression(@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$", ErrorMessage = "Invalid date format.")]
        public DateTime ReviewOn { get; set; }


        [Display(Name = "Remarks of submission")]
        [Required]
        [MaxLength(3)]
        
        public string Remarks { get; set; }


        #region Navigational Properties to the Project Model (1:0 mapping)

        public Project Project { get; set; }

        #endregion

    }
}

