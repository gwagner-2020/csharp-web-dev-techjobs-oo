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

            int actualOutputId = testJob.Id;
            int expectedOutputId = 1;
            Assert.AreEqual(expectedOutputId, actualOutputId);

            string actualOutputName = testJob.Name;
            string expectedOutputName = "Product Tester";
            Assert.AreEqual(expectedOutputName, actualOutputName);

            string actualOutputEmployer = testJob.EmployerName.Value;
            string expectedOutputEmployer = "ACME";
            Assert.AreEqual(expectedOutputEmployer, actualOutputEmployer);

            string actualOutputLocation = testJob.EmployerLocation.Value;
            string expectedOutputLocation = "Desert";
            Assert.AreEqual(expectedOutputLocation, actualOutputLocation);

            string actualOutputType = testJob.JobType.Value;
            string expectedOutputType = "Quality control";
            Assert.AreEqual(expectedOutputType, actualOutputType);

            string actualOutputCompetency = testJob.JobCoreCompetency.Value;
            string expectedOutputCompetency = "Persistence";
            Assert.AreEqual(expectedOutputCompetency, actualOutputCompetency);
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

            //List<string> labels = new List<string> { "ID:", "Name:", "Employer:", "Location:", "Position Type:", "Core Competency:" };

            //string testString = testJob.ToString();
            string actualOutput = testJob.ToString();

            string expectedOutput = $"\nID: {testJob.Id}\nName: Android Developer\nEmployer: EyeVerify\nLocation: Kansas City\nPosition Type: Mobile Developer\nCore Competency: Android\n";

            Assert.AreEqual(expectedOutput, actualOutput);

            //foreach (string label in labels)
            //{
            //    Assert.IsTrue(testString.Contains(label));
            //}
            //Assert.IsTrue(testString.Contains("ID:"));
            //Assert.IsTrue(testString.Contains("Name:"));
            //Assert.IsTrue(testString.Contains("Employer:"));
            //Assert.IsTrue(testString.Contains("Location:"));
            //Assert.IsTrue(testString.Contains("Position Type:"));
            //Assert.IsTrue(testString.Contains("Core Competency:"));
        }

        //[TestMethod]
        //public void TestToStringMethodContainsFieldData()
        //{
        //    Job testJob = new Job("Android Developer", new Employer("EyeVerify"), new Location("Kansas City"), new PositionType("Mobile Developer"), new CoreCompetency("Android"));

        //    string stringId = $"{testJob.Id}";

        //    List<string> fieldData = new List<string> { stringId, testJob.Name, testJob.EmployerName.Value, testJob.EmployerLocation.Value, testJob.JobType.Value, testJob.JobCoreCompetency.Value };


        //    string testString = testJob.ToString();

        //    foreach (string field in fieldData)
        //    {
        //        Assert.IsTrue(testString.Contains(field));
        //    }
        //}
        [TestMethod]
        public void TestToStringMethodEmptyFields()
        {
            Job testJob = new Job("Android Developer", new Employer(), new Location(""), new PositionType(), new CoreCompetency("Android"));

            string actualOutput = testJob.ToString();

            string expectedOutput = $"\nID: {testJob.Id}\nName: Android Developer\nEmployer: Data not available\nLocation: Data not available\nPosition Type: Data not available\nCore Competency: Android\n";

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void TestToStringMethodIdFieldOnly()
        {
            Job testJob = new Job();

            string actualOutput = testJob.ToString();

            string expectedOutput = "\nOOPS! This job does not seem to exist.\n";

            Assert.AreEqual(expectedOutput, actualOutput);
        }
        
        

        
        

    }
}
