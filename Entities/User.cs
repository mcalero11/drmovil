﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class User : IEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        
    }
}
