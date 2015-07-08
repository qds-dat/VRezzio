using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VRezzio.Models
{

    public enum eRole
    {
        University,
        Student
    }

    public enum eTitle
    {
        Mr,
        Mrs,
        Ms,
        Miss,
        Dr
    }
    public enum eSchoolStatus
    {
        Peding,
        Active
    }

    public enum eStudentStatus
    {
        Registed,
        CompleteStep1,
        CompleteStep2,
        CompleteStep3,
        Complete,
        
    }

    public enum eAccountStatus
    {
        Active,
        Inactive
    }

    public enum Like
    {
        None,
        HighlyLikely,
        Likely,
        NotLikely
    }
}