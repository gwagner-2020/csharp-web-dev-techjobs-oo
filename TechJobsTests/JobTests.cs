using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job testJob1 = new Job();
            Job testJob2 = new Job();

            int actualOutput1 = testJob1.Id;
            int expectedOutput1 = 1;

            int actualOutput2 = testJob2.Id;
            int expectedOutput2 = 2;

            Assert.AreEqual(expectedOutput1, actualOutput1);
            Assert.AreEqual(expectedOutput2, actualOutput2);
        }


        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job testJob = new Job("Product Tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            List<string> actualOutput = new List<string> { $"{testJob.Id}", testJob.Name, testJob.EmployerName.Value, testJob.EmployerLocation.Value, testJob.JobType.Value, testJob.JobCoreCompetency.Value };
            List<string> expectedOutput = new List<string> { "1","Product Tester", "ACME", "Desert", "Quality control", "Persistence" };

            for (int i = 0; i < actualOutput.Count; i++)
            {
                Assert.AreEqual(expectedOutput[i], actualOutput[i]); 
            }
        }


        [TestMethod]
        public void TestJobsForEquality()
        {
            Job testJob1 = new Job("Android Developer", new Employer("EyeVerify"), new Location("Kansas City"), new PositionType("Mobile Developer"), new CoreCompetency("Android"));
            Job testJob2 = new Job("Android Developer", new Employer("EyeVerify"), new Location("Kansas City"), new PositionType("Mobile Developer"), new CoreCompetency("Android"));

            bool actualOutput = testJob1.Equals(testJob2);
            bool expectedOutput = false;

            Assert.AreEqual(expectedOutput, actualOutput);
        }


        [TestMethod]
        public void TestToStringMethodBlankLines()
        {
            Job testJob = new Job("Android Developer", new Employer("EyeVerify"), new Location("Kansas City"), new PositionType("Mobile Developer"), new CoreCompetency("Android"));

            string testString = testJob.ToString();

            bool actualOutputBlankLineStart = testString.StartsWith('\n');
            bool expectedOutputBlankLineStart = true;

            bool actualOutputBlankLineFinish = testString.EndsWith('\n');
            bool expectedOutputBlankLineFinish = true;

            Assert.AreEqual(expectedOutputBlankLineStart, actualOutputBlankLineStart);
            Assert.AreEqual(expectedOutputBlankLineFinish, actualOutputBlankLineFinish);
        }


        [TestMethod]
        public void TestToStringMethodContainsDataAndFormatting()
        {
            Job testJob = new Job("Android Developer", new Employer("EyeVerify"), new Location("Kansas City"), new PositionType("Mobile Developer"), new CoreCompetency("Android"));

            string actualOutput = testJob.ToString();

            string expectedOutput = $"\nID: {testJob.Id}\nName: Android Developer\nEmployer: EyeVerify\nLocation: Kansas City\nPosition Type: Mobile Developer\nCore Competency: Android\n";

            Assert.AreEqual(expectedOutput, actualOutput);
        }


        [TestMethod]
        public void TestToStringMethodEmptyFields()
        {
            Job testJob = new Job("Android Developer", new Employer(""), new Location(""), new PositionType(""), new CoreCompetency("Android"));

            string actualOutput = testJob.ToString();

            string expectedOutput = $"\nID: {testJob.Id}\nName: Android Developer\nEmployer: Data not available\nLocation: Data not available\nPosition Type: Data not available\nCore Competency: Android\n";

            Assert.AreEqual(expectedOutput, actualOutput);
        }


        [TestMethod]
        public void TestToStringMethodIdFieldOnly()
        {
            Job testJob = new Job("", new Employer(""), new Location(""), new PositionType(""), new CoreCompetency(""));

            string actualOutput = testJob.ToString();

            string expectedOutput = "\nOOPS! This job does not seem to exist.\n";

            Assert.AreEqual(expectedOutput, actualOutput);
        }

    }
}
