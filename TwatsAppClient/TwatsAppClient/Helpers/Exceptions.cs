﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// some custom exceptions , not really needed
/// </summary>
namespace TwatsAppClient.Helpers
{
    
    public class LoginException : Exception
    {
        public LoginException() { }
        public LoginException(string message) : base(message) { }
        public LoginException(string message, Exception inner) : base(message, inner) { }
    }

}
