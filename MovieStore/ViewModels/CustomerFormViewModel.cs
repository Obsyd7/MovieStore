using System.Collections.Generic;
using MovieStore.Models;

namespace MovieStore.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable <MembershipTypeModel> MembershipTypes { get; set; }
        public CustomerModel Customer { get; set; }
    }
}