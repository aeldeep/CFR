//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RegisterNewUser
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage="Please Enter User Name", AllowEmptyStrings =false)]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please Enter Password", AllowEmptyStrings = false)]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        [StringLength(50, MinimumLength =6,ErrorMessage ="Password Mustn't be less than 6 Characters")]
        public string Password { get; set; }
        [Compare("Password",ErrorMessage ="Password Dosen't Match")]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        public String ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Please Enter Your Full Name", AllowEmptyStrings = false)]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Please Enter Email", AllowEmptyStrings = false)]
        [RegularExpression(@"^([0-9a-zA-Z]([\+\-_\.][0-9a-zA-Z]+)*)+@(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]*\.)+[0-9a-zA-Z]{2,3})$",
            ErrorMessage = "Please Enter A Valid Email")]
        public string Email { get; set; }
    }
}
