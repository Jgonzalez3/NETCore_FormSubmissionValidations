using System.ComponentModel.DataAnnotations;

namespace FormSubmission.Models{
    public class User{
        [Required]
        [MinLength(4)]
        public string firstname {get;set;}
        [Required]
        [MinLength(4)]
        public string lastname {get;set;}
        [Required]
        [Range(0,200)]
        public int age {get;set;}
        [Required]
        public string email {get;set;} 
        [Required]
        [MinLength(8)]
        public string password {get;set;}
    }
}