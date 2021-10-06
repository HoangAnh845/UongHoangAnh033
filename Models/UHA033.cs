using System;
using System.ComponentModel.DataAnnotations;

namespace UongHoangAnh033.Models
{
    public class UHA033
    {
        [Key]
        public int UHA033Id varchar(20) { get; set; }
        [not null]
        public string UHA033Name nvarchar(50) { get; set; }
        [not null]
        public string UHA033Gender boolean { get; set; }
    }
}