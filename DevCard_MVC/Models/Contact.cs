using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace DevCard_MVC.Models
{
    public class Contact
    {
        [Required ( ErrorMessage ="این فیلد اجباری است")]
        [MinLength (3,ErrorMessage ="حداقل طول نام ، 3 کاراکتر است")]
        [MaxLength(100,ErrorMessage ="حداکثر طول نام ، 100 کاراکتر است")]
        public string name { get; set; }
        [Required(ErrorMessage = "این فیلد اجباری است")]
        [EmailAddress(ErrorMessage ="مقدار وارد شده ایمیل صحیح نیست")]
        public string email { get; set; }

        public string service { get; set; }
        public string message { get; set; }
        public SelectList? services { get; set; }

    }
}
