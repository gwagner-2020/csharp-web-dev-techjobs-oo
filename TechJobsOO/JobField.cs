using System;
using System.Collections.Generic;
using System.Text;

namespace TechJobsOO
{
    public abstract class JobField
    {
        
        public int Id { get; }
        protected static int nextId = 1;
        public string Value { get; set; }

        public JobField()
        {
            Id = nextId;
            nextId++;
        }

        public JobField(string value) : this()
        {
            this.Value = value;
        }

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

            JobField jf = obj as JobField;
            return this.Id == jf.Id;
        }

        public override int GetHashCode()
        {
        return HashCode.Combine(Id);
        }

        public override string ToString()
        {
        return this.Value;
        }
    
    }
}
