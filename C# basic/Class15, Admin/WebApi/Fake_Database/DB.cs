using System;
using System.Collections.Generic;
using System.Text;
using WebApi.Models;

namespace WebApi.Fake_Database
{
    internal static class DB
    {
        //property
        internal static List<Admin> Admins { get; set; } = MockData.GetMockedAdmins();
    }
}
