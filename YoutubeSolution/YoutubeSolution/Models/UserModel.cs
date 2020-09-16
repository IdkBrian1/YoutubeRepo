using System;
using SQLite;

namespace YoutubeSolution.Models
{
    public class UserModel
    {

        [PrimaryKey, AutoIncrement]
        public int UserID { get; set; }

        [MaxLength(30)]
        public string EmailField { get; set; }

        [MaxLength(16)]
        public string PasswordField { get; set; }

        [MaxLength(30)]
        public string NamesField { get; set; }

        [MaxLength(2)]
        public string AgeField { get; set; }

        public DateTime Creation_Date { get; set; }

    }
}
