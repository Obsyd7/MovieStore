using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieStore.Models
{
    public class Min18YearsIfMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (CustomerModel) validationContext.ObjectInstance;

            if (customer.MembershipTypeId == MembershipTypeModel.Unknown || 
                customer.MembershipTypeId == MembershipTypeModel.PayAsYouGo)
            {
                return ValidationResult.Success;
            }

            if (customer.Birthdate == null)
            {
                return new ValidationResult("Birthdate is required.");
            }

            var age = DateTime.Today.Year - customer.Birthdate.Value.Year;

            return (age >= 18)
                ? ValidationResult.Success
                : new ValidationResult("Customer should be at least 18 years old to go on a membership.");
        }
    }
}