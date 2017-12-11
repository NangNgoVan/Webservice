using System;

namespace WebService.Entity
{
    public class UsbToken
    {
        public int Id { get; set; }
        public string SubjectName { get; set; }
        public string SerialNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime CreateAt { get; set; }

        //FK
        //public virtual ICollection<AccountTokenTemplate> AccountTokenTemplates { get; set; }
    }
}
