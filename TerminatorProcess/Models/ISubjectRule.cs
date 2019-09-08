using System;
using System.Collections.Generic;
using System.Text;

namespace TerminatorProcess.Models
{
    public interface ISubjectRule
    {
        bool IsMatch(ISubject subject);
        bool OfInterest();
    }
}
