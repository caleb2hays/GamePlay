using GamePlay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GamePlay.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipTypeModel> MembershipTypes { get; set; }
        public CustomerModel Customer { get; set; }
        

        public string Title
        {
            get
            {
                return Customer.Id != 0 ? "Edit Customer" : "New Customer";
            }
        }


    }

    
}