using System.ComponentModel.DataAnnotations;

namespace WebService.Enum
{
    public enum Status
    {
        [Display(Name = "SUCCESS")]
        Success = 1,

        [Display(Name = "FAIL")]
        Fail = 2
    }
}