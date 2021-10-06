using System;
using System.ComponentModel.DataAnnotations;

namespace UongHoangAnh033.Models
{
    public class Person
    {
        [Key]
        public int PersonId varchar(20) { get; set; }
        public string PersonName nvarchar(50) { get; set; }
    }
}