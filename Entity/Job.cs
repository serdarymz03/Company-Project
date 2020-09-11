using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Job
    {
        int id; string jobName, jobContent; DateTime date;

        public int Id { get => id; set => id = value; }
        public string JobName { get => jobName; set => jobName = value; }
        public string JobContent { get => jobContent; set => jobContent = value; }
        public DateTime Date { get => date; set => date = value; }

        public Job(int id, string jobName)
        {
            this.id = id;
            this.jobName = jobName;
        }

        public Job(string jobName, string jobContent, DateTime date)
        {
            this.jobName = jobName;
            this.jobContent = jobContent;
            this.date = date;
        }

        public Job(int id, string jobName, string jobContent, DateTime date)
        {
            this.id = id;
            this.jobName = jobName;
            this.jobContent = jobContent;
            this.date = date;
        }
    }
}
