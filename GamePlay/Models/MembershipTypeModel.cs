using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GamePlay.Models
{
    public class MembershipTypeModel
    {
        public byte Id { get; set; }

        public short SignUpFee { get; set; }

        public byte DurationInMonths { get; set; }

        public byte DiscountRate { get; set; }

        [Required]
        public string TypeName { get; set; }

        public static readonly byte Unkown = 0;
        public static readonly byte PayAsYouGo = 1;
    }
}