using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace Buoi10_TranMinhThanh.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public string Major {  get; set; } = string.Empty;
    }
}
