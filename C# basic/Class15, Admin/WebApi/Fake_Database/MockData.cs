using System;
using System.Collections.Generic;
using System.Text;
using WebApi.Models;

namespace WebApi.Fake_Database
{
    public static class MockData
    {
        public static List<Admin> GetMockedAdmins()
        {
            Admin john = new Admin()
            {
                Id = 1,
                FullName = "John Doe"
            };
            Admin bob = new Admin()
            {
                Id = 2,
                FullName = "Bob Bobsky",
                Frineds = new List<Admin>() { john }
            };
            Admin mark = new Admin()
            {
                Id = 3,
                FullName = "Mark Dean",
                Frineds = new List<Admin>() { john, bob }
            };
            Admin harry = new Admin()
            {
                Id = 4,
                FullName = "Harry O'Connel",
                Frineds = new List<Admin>() { mark, john }
            };
            Admin jina = new Admin()
            {
                Id = 5,
                FullName = "Jina Johnson",
                Frineds = new List<Admin>() { john, bob, mark, harry }
            };

            return new List<Admin>() { john, bob, mark, harry, jina };
        }
    }
}
