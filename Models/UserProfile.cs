﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask5.Models
{
    public class UserProfile
    {

        public int Id { get; set; }
        public string CellPhone { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

    }
}
