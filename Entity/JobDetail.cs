using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class JobDetail
    {
        int id, jobId; string employerNo, name, jobName, jobContent, workerNo;

        public int Id { get => id; set => id = value; }
        public int JobId { get => jobId; set => jobId = value; }
        public string EmployerNo { get => employerNo; set => employerNo = value; }
        public string Name { get => name; set => name = value; }
        public string WorkerNo { get => workerNo; set => workerNo = value; }
        public string JobName { get => jobName; set => jobName = value; }
        public string JobContent { get => jobContent; set => jobContent = value; }

        public JobDetail(int jobId, string employerNo, string workerNo)
        {
            this.jobId = jobId;
            this.employerNo = employerNo;
            this.workerNo = workerNo;
        }

        public JobDetail(int jobId, string employerNo, string name, string jobName, string jobContent, string workerNo)
        {
            this.jobId = jobId;
            this.employerNo = employerNo;
            this.name = name;
            this.jobName = jobName;
            this.jobContent = jobContent;
            this.workerNo = workerNo;
        }

        public JobDetail(int id, int jobId, string employerNo, string name, string jobName, string jobContent, string workerNo)
        {
            this.id = id;
            this.jobId = jobId;
            this.employerNo = employerNo;
            this.name = name;
            this.jobName = jobName;
            this.jobContent = jobContent;
            this.workerNo = workerNo;
        }
    }
}
