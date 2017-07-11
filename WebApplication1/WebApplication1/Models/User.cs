using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
	public class User
    {

        //// User Data
        [Key]
        public int UserID { get; set; }

        public int UserScore { get; set; }

        public string UserRole { get; set; }

        [Required(ErrorMessage ="חובה להזין שם משתמש")]
        [StringLength(20,MinimumLength =4,ErrorMessage ="שם משתמש צריך להכיל בין 4 ל 20 תוים")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "חובה להזין שם פרטי")]
        [StringLength(10,MinimumLength =2,ErrorMessage ="שם פרטי חייב להכיל בין 2 ל 10 תוים")]
        public string UserFirstName { get; set; }

        [Required(ErrorMessage = "חובה להזין שם משפחה")]
        [StringLength(10, MinimumLength = 2, ErrorMessage = "שם משפחה חייב להכיל בין 2 ל 10 תוים")]
        public string UserLastName { get; set; }

        public string UserGender { get; set; }

        [Required(ErrorMessage = "יש להזין ססמא להתחברות לאתר")]
        [StringLength(10, MinimumLength = 4, ErrorMessage = "ססמא צריכה להכיל בין 4 ל 10 תוים")]
        public string UserPassword { get; set; }

        [Required(ErrorMessage ="יש להזין כתובת מייל תקנית")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage ="המייל שהוזן אינו תקין")]
        public string UserEmail { get; set; }

        public DateTime UserBirthDate { get; set; }
    }
}


//private int UserID;
//private string UserName;
//private string UserFirstName;
//private string UserLastName;
//private DateTime UserBirthDate = new DateTime();
//private string UserGender;
//private string UserPassword;
//private string UserEmail;
//private int UserScore;
//private int UserRole;
