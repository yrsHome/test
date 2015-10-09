using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcMusicStore.Repository.DataObject
{
    public class OrdersDTO
    {
        public long OrderId { get;set; }
        public DateTime OrderDate { get; set; }
        public String UserName { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Address { get; set; }
        public String City { get; set; }
        public String State { get; set; }
        public String PostalCode { get; set; }
        public String Country { get; set; }
        public String Phone { get; set; }
        public String Email { get; set; }
        public Decimal Total { get; set; }
    }
}