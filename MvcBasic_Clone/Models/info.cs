using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcBasic_Clone.Models
{
    public class Info
    {
        //[Required]
        //[Display(Name = "編碼")]
        public int Id { get; set; }

        [Display(Name = "姓名")]
        [Required(ErrorMessage = "請輸入姓名")]
        [StringLength(maximumLength: 20, MinimumLength = 3, ErrorMessage ="最少需要三個字元")]
        public string Name { get; set; }

        [Display(Name = "行動電話")]
        [Required(ErrorMessage = "請輸入行動電話")]
        [RegularExpression(@"^\d{4}\-?\d{3}\-?\d{3}$", ErrorMessage = "需為09xx-xxx-xxx格式")]
        [DataType(DataType.PhoneNumber)]
        public int Phone { get; set; }

        [Display(Name = "電子郵件")]
        [Required(ErrorMessage = "請輸入電子郵件")]
        [DataType(DataType.EmailAddress,ErrorMessage ="請檢查信箱格式")]
        public string Email { get; set; }

        [Display(Name = "性別")]
        [Required(ErrorMessage = "請輸入性別")]
        public int Gender { get; set; }
    }
}