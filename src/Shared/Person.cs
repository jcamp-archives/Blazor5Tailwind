using System.ComponentModel.DataAnnotations;

namespace Blazor5Tailwind.Shared
{
    public class Person
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int? Age { get; set; }
        [EmailAddress]
        public string EmailAddress { get; set; }
    }
}
