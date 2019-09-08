using FluentAssertions;
using NUnit.Framework;
using TerminatorProcess.Models;
using TerminatorProcess.Services;

namespace TerminatorProcess.Tests
{
    [TestFixture]
    public class SubjectAnalyserTests
    {
        
        private ISubjectAnalyser _sut;
        
        
        [SetUp]
        public void Setup()
        {
            _sut = new SubjectAnalyser();
        }


        //** Scan subjects and determine if they require further investigation **
        // - Scan subjects and see if they are human
        // - Upon investigation, determine if intended target

        [TestCase("woman", true)]
        [TestCase("girl", false)]
        [TestCase("man", false)]
        [TestCase("boy", true)]
        [TestCase("T1000", true)]
        public void TerminatorShould_Determine_ToInvestigateFurther(string subjectName, bool outcome)
        {
            var subject = new Subject { SubjectName = subjectName };
            var result = _sut.InvestigateFurther(subject);

            result.Equals(outcome);
        }
    }
}