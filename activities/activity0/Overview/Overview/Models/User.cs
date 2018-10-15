using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Overview.Models
{
    [Table("USERS")]
    class User
    {
        [Key]
        [Column("ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Int32 Id { get; set; }

        [Column("FIRSTNAME")]
        public String FirstName { get; set; }

        [Column("LASTNAME")]
        public String LastName { get; set; }

        [Column("EMAIL")]
        public String Email { get; set; }


        public override string ToString()
        {
            return $"User[Id: {Id}, FirstName: {FirstName}, LastName: {LastName}, Email: {Email}]";
        }
    }
}
