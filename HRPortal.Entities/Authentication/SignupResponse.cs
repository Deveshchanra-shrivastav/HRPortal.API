using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRPortal.Entities.Authentication
{
    public class SignupResponse
    {
        bool Success;
        string Message;

        public SignupResponse(bool success, string message)
        {
            Success = success;
            Message = message;
        }
    }
}
