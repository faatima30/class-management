using classManagementSystem.Models;

namespace classManagementSystem.Controllers
{
    internal class Services : tbl_Services
    {
        public new string Customer_name { get; set; }
        public new string Service_type { get; set; }
        public new string Issue { get; set; }
        public new string Price { get; set; }
    }
}