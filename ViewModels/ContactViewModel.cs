using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Dutch_Treat.ViewModels
{
    public class ContactViewModel
    {
       [Required][MinLength(3)] public string Name { get; set; }
      [EmailAddress] [Required] public string Email { get; set; }
       [Required] public string Subject { get; set; }
     [MaxLength(250)]  [Required] public string Message { get; set; }
    }
}