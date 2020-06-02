using System;
using System.Collections.Generic;
using AndcultureCode.CSharp.Core.Models;

namespace AndcultureCode.GB.Business.Core.Models.Entities.Users
{
    public class User : Auditable
    {
        #region Properties

        public string Email { get; set; }
        public string FirstName { get; set; }
        public bool IsSuperAdmin { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }

        #endregion Properties

        #region Navigation Properties

        public List<UserRole> UserRoles { get; set; }

        #endregion Navigation Properties
    }
}