using System;
using System.Collections.Generic;
using System.Text;

namespace RegLoginApp.Tables
{
    internal class RegUserTable
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

    }
}
