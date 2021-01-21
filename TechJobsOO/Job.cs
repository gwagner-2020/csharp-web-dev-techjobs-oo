using System;
using System.Collections.Generic;
namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.
        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            this.Name = name;
            this.EmployerName = employerName;
            this.EmployerLocation = employerLocation;
            this.JobType = jobType;
            this.JobCoreCompetency = jobCoreCompetency;
        }

        // TODO: Generate Equals() and GetHashCode() methods.

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            Job j = obj as Job;
            return this.Id == j.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            string output = "";

            string stringId = "";
            string stringName = "";
            string stringEmployer = "";
            string stringLocation = "";
            string stringJobType = "";
            string stringCompetency = "";

            if ($"{this.Id}" == null || $"{this.Id}" == "")
            {
                stringId += "ID: Data not available";
            } 
            else
            {
                stringId += $"ID: {this.Id}";
            }

            if (this.Name == null || this.Name == "")
            {
                stringName += "Name: Data not available";
            }
            else
            {
                stringName += $"Name: {this.Name}";
            }

            if (this.EmployerName.Value == null || this.EmployerName.Value == "")
            {
                stringEmployer += "Employer: Data not available";
            }
            else
            {
                stringEmployer += $"Employer: {this.EmployerName.Value}";
            }

            if (this.EmployerLocation.Value == null || this.EmployerLocation.Value == "")
            {
                stringLocation += "Location: Data not available";
            }
            else
            {
                stringLocation += $"Location: {this.EmployerLocation.Value}";
            }

            if (this.JobType.Value == null || this.JobType.Value == "")
            {
                stringJobType += "Position Type: Data not available";
            }
            else
            {
                stringJobType += $"Position Type: {this.JobType.Value}";
            }

            if (this.JobCoreCompetency.Value == null || this.JobCoreCompetency.Value == "")
            {
                stringCompetency += "Core Competency: Data not available";
            }
            else
            {
                stringCompetency += $"Core Competency: {this.JobCoreCompetency.Value}";
            }

            if ((this.Name == null || this.Name == "") && (this.EmployerName.Value == null || this.EmployerName.Value == "") && (this.EmployerLocation.Value == null || this.EmployerLocation.Value == "") && (this.EmployerLocation.Value == null || this.EmployerLocation.Value == "") && (this.JobType.Value == null || this.JobType.Value == "") && (this.JobCoreCompetency.Value == null || this.JobCoreCompetency.Value == ""))
            {
                output += "\nOOPS! This job does not seem to exist.\n";
            }
            else
            {
                output += $"\n{stringId}\n{stringName}\n{stringEmployer}\n{stringLocation}\n{stringJobType}\n{stringCompetency}\n";
            }
            
            return output;
        }
    }
}
