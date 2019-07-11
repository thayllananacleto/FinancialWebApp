using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Finance.Entities
{
    public class Actions
    {

        public int Id { get; set; }

        public decimal Value { get; set; }

        public DateTime Date { get; set; }

        public ActionType ActionType { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

    }
}