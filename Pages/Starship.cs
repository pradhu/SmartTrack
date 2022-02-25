using System;
using System.ComponentModel.DataAnnotations;

public class Starship
{
    [Required]
    public string EmployeeName { get; set; }

    public string EmployeeID { get; set; }

    [Required]
   //EmailAddress]
    public string Email { get; set; }

    [Required]
   //Phone]
    public string PhoneNumber { get; set; } = string.Empty;

    [Required]
    public string Location { get; set; }

    public string YearsofExp { get; set; }

    [Required]
    public string Skillset { get; set; }

    [Required]
    public string TeamReqName { get; set; }

    }


   /* [Required]
    [StringLength(16,
        ErrorMessage = "Name too long (16 character limit).")]
       public string Name{ get; set; }
        public string Email { get; set; }
       public string SkillSet{ get; set; }
       public string PhoneNumber{ get; set; }
       public string YearsOfExperience{ get; set; }

    
        Starship()
        {
            Name = "Unknown";
            Email = "Unknown";
            SkillSet = "Unknown";
            PhoneNumber = "Unknown";
            YearsOfExperience = "Unknown";
        }
        Starship(string Name, string Email, string SkillSet, string PhoneNumber)
        {
            this.Name = Name;
            this.Email = Email;
            this.SkillSet = SkillSet;
            this.PhoneNumber = PhoneNumber;
            this.YearsOfExperience = YearsOfExperience;
        }
        void WriteFile()
        {
            using (StreamWriter sw = new StreamWriter("Data.txt"))
            {
                sw.WriteLine(this.Name);
                sw.WriteLine(this.Email);
                sw.WriteLine(this.SkillSet);
                sw.WriteLine(this.PhoneNumber);
                sw.WriteLine(this.YearsOfExperience);
            }

            
        }

        void ReadFile()
    {
        // Read and show each line from the file.
           string name = "";
            using (StreamReader sr = new StreamReader("Data.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(name);
                }
            }
        } */

