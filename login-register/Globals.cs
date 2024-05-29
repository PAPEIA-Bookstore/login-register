﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login_register
{
    public static partial class GLOBALS
    {
        public static readonly string pepper = "sVgS12";
        public static readonly string usernameGuidelines = "A valid username should:\n- Start with a letter.\n - Use only uppercase or lowercase letters, numbers and underscores(_).\n- Be between 8-30 characters long.";
        public static readonly string passGuidelines = "A valid password should:\n- Contain at least one digit from 1 to 9.\n- Contain at least one lowercase letter.\n- Contain at least one uppercase letter.\n- Contain at least one special character.\n- Be between 8-16 characters long."; 
        public static readonly string usernameREGEX = "^[A-Za-z][A-Za-z0-9_]{7,29}$";
        public static readonly string passREGEX = "^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*\\W)(?!.* ).{8,16}$";
        
    }
}