using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using GamePlay.Models;


// This is used to transfer data from the client to the server, back and forth
// DTOs allow us to refactor our domain model with less chance of the API breaking
// Multiple clients will be using the APIs so keeping the models stable through 
// changes is important
// DTOs also play an important part in security when using JSON
// Also with DTOs you control what properties are exposed or can be updated

namespace GamePlay.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public byte MembershipTypeId { get; set; }

        public MembershipTypeDto MembershipType { get; set; }

        //[Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }
    }
}