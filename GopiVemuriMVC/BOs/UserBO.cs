using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GopiVemuriMVC.BOs
{
    [Table("GopiVemuriUser")]
    public class UserBO
    {
        [Key]
        [Column("UserID")]
        public int UserID { get; set; }

        [Column("UserName")]
        [MaxLength(128)]
        public string UserName { get; set; }
        [Column("UserPassword")]
        [MaxLength(128)]
        public string UserPassword { get; set; }

        [Column("Email")]
        [MaxLength(128)]
        public string Email { get; set; }

        //[Column("ConfirmPassword")]
        //[MaxLength(128)]
        //public string ConfirmPassword { get; set; }
    }
}