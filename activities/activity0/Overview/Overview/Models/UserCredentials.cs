using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Overview.Models
{
    [Table("USER_CREDENTIALS")]
    class UserCredentials
    {
        [Key]
        [Column("USER_ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Int32 UserId { get; set; }

        [Column("USERNAME")]
        public String Username { get; set; }

        [Column("PASSWORD")]
        public String Password { get; set; }


        public override string ToString()
        {
            return $"UserCredentials[UserId: {UserId}, Username: {Username}, Password: {Password}]";
        }
    }
}
