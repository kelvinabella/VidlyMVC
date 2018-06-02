using System.Collections.Generic;
using VidlyMVC.Models;

namespace VidlyMVC.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}