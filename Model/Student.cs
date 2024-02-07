using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace RainbowSchoolWebApp.Model
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public int Student_Id {  get; set; }
        public string ? Student_Name { get; set; }
        [StringLength(50)]
        public string ? Subject {  get; set; }
        public double Marks {  get; set; }
    }
}
