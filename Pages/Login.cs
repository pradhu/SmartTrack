using System;
using System.ComponentModel.DataAnnotations;

public class Login
{
    [Required]
    public string Name { get; set; }
    
    [Required]
    public string Password { get; set; }

}