using System;
using System.Collections.Generic;
using System.Text;

namespace WebApi.Models
{
    public class Admin
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public List<Admin> Frineds { get; set; }

    }
}
