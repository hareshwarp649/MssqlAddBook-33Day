using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MssqlAddBook33_16
{
    internal class CompareContact : IComparer<Contacts>
    {
        public enum SortingType
        {
            FIRST_NAME, CITY, STATE, ZIP
        }

        public SortingType CompareByContactDetail;

        public int Compare(Contacts x, Contacts y)
        {
            switch (CompareByContactDetail)
            {
                case SortingType.FIRST_NAME:
                    return x.firstName.CompareTo(y.firstName);
                case SortingType.CITY:
                    return x.city.CompareTo(y.city);
                case SortingType.ZIP:
                    return x.zipCode.CompareTo(y.zipCode);
                case SortingType.STATE:
                    return x.state.CompareTo(y.state);
                default:
                    break;
            }
            return 0;
        }
    }
}
