namespace TerminatorProcess.Models
{
    public class Subject : ISubject
    {
        public string SubjectName { get; set; }
    }

    public class IsWomanRule : ISubjectRule
    {
        public bool IsMatch(ISubject subject)
        {
            return subject.SubjectName.ToLower().Contains("woman");
        }

        public bool OfInterest()
        {
            return true;
        }
    }
    public class IsDogRule : ISubjectRule
    {
        public bool IsMatch(ISubject subject)
        {
            return subject.SubjectName.ToLower().Contains("dog");
        }

        public bool OfInterest()
        {
            return false;
        }
    }
}