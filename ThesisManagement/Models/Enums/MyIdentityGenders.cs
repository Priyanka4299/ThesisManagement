using System.ComponentModel.DataAnnotations;

namespace ThesisManagement.Models.Enums
{

    public enum MyIdentityGenders
    {
        [Display(Name = "Male")]
        Male,

        [Display(Name = "Female")]
        Female,

        [Display(Name = "Third Gender")]
        ThirdGender
    }
}
