using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceExercise01
{
    class Letter
    {
        public string RecipientName { get; set; }
        public string DateMailed { get; set; }

        public Letter()
        {
        }

        public Letter(string recipientName, string dateMailed)
        {
            RecipientName = recipientName;
            DateMailed = dateMailed;
        }

        public override string ToString()
        {
            return $"Class Type: {GetType()} -- Recipient name: {RecipientName} -- Date mailed: {DateMailed}";
        }
    }
}
