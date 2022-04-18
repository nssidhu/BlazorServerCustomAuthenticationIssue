using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class DTO_LoginSuccessResponse
    {

        public string? Source { get; set; }

        public string? ExitCode { get; set; }

        public string? SubCode { get; set; }

        public string? SuccessMessage { get; set; }

        public DTO_LoginResult? LoginResult { get; set; }

        //source = SOURCE, exitCode = "SUCCESS", subCode = "", successMessage = "Login success", loginresult = LoginResult
    }
}
