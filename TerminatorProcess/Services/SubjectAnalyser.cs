using System.Collections.Generic;
using System.Linq;
using TerminatorProcess.Models;

namespace TerminatorProcess.Services
{
    class SubjectAnalyser : ISubjectAnalyser
    {
        private readonly List<ISubjectRule> _subjectRules;

        public SubjectAnalyser()
        {
            _subjectRules = new List<ISubjectRule>();
            _subjectRules.Add(new IsWomanRule());
            _subjectRules.Add(new IsDogRule());
        }

        public bool InvestigateFurther(ISubject subject)
        {
            var isMatch = _subjectRules.FirstOrDefault(rule => rule.IsMatch(subject));

            return isMatch == null || Investigate(isMatch);
        }

        private bool Investigate(ISubjectRule rule)
        {
            return rule.OfInterest();
        }
    }
}
