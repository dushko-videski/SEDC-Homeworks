using CodeOrganizer.Enums;

namespace CodeOrganizer.Entities
{
    public class Job
    {
        public string CompanyName { get; set; }
        public Address Address { get; set; }
        public Role Role { get; set; }

    }
}
