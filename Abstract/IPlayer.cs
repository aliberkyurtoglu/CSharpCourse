using System;
using System.Collections.Generic;

namespace GameProject.Abstract
{
    public interface IPlayer
    {
        public int PlayerId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string IdentificationNumber { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }
    }
}