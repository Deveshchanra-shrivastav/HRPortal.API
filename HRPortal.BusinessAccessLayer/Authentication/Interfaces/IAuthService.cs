using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRPortal.Entities.Authentication;

namespace HRPortal.BusinessAccessLayer.Authentication.Interfaces
{
    public interface IAuthService
    {
        Task<SignupResponse>  SignupAsync(SignupRequest request);
    }
}
