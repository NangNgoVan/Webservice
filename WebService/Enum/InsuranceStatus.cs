using System.ComponentModel.DataAnnotations;

namespace WebService.Enum
{
    public enum InsuranceStatus
    {
        [Display(Name = "SUCCESS")]
        Success = 1,

        [Display(Name = "FAIL")]
        Fail = 2,

        [Display(Name = "Published")]
        Published = 3
    }
}