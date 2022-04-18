using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{

    public class DTO_LoginResult
    {
        public string AuthToken { get; set; } = "";

        public DateTime TokenExpiryDateTime { get; set; }

        public bool IsAuthenticated { get; set; }

        public bool IsAssociatedWithBusinessAcount { get; set; }

        public bool IsEmailVerified { get; set; }

        public bool IsCellPhoneVerified { get; set; }

        public string EmailAddress { get; set; } = "";

        public string UserID { get; set; } = "";

        public string CellPhoneDialingCode { get; set; } = "";

        public string CellPhoneISO3CountryCode { get; set; } = "";

        public string CellPhoneNumber { get; set; } = "";

        public string FirstName { get; set; } = "";

        public string LastName { get; set; } = "";
    }

}



