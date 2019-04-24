﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NTShop.Model.Models
{
    [Table("Feedbacks")]
    public class Feedback
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [StringLength(150)]
        [Required(ErrorMessage ="Bạn chưa nhập tên ^^")]
        public string Name { get; set; }

        [StringLength(250)]
        public string Email { get; set; }

        [StringLength(500)]
        public string Message { get; set; }

        public DateTime CreatedDate { get; set; }

        [Required]
        public bool Status { get; set; }
    }
}