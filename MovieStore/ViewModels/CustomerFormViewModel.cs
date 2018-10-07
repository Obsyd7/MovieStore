using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MovieStore.Models;

namespace MovieStore.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable <MembershipTypeModel> MembershipTypes { get; set; }
        public CustomerModel Customer { get; set; }
    }
}