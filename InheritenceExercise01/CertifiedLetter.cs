using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceExercise01
{
    class CertifiedLetter : Letter
    {
        public int TrackingNumber { get; set; }

        public CertifiedLetter(Letter myObj, int trackingNumber)
        {
            RecipientName = myObj.RecipientName;
            DateMailed = myObj.DateMailed;
            TrackingNumber = trackingNumber;
        }
        public override string ToString()
        {
            return $"{base.ToString()} -- Your tracking number: {TrackingNumber}";
        }
    }
}
