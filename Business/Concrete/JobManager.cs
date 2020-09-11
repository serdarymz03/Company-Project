using DataAccess.Abstract;
using DataAccess.Concrete;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class JobManager
    {
        static JobManager jobManager;
        JobDal jobDal;
        string controlText;
        private JobManager()
        {
            jobDal = JobDal.GetInstance();
        }

        public string Add(Job entity)
        {
            try
            {
                controlText = IsJobComplete(entity);
                if (controlText != "")
                {
                    return controlText;
                }
                return jobDal.Add(entity);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Delete(int id)
        {
            try
            {
                if (id < 1)
                {
                    return "Lütfen Geçerli Bir İş Seçiniz";
                }
                return jobDal.Delete(id);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Job Get(int id)
        {
            return null;
        }

        public List<Job> GetList()
        {
            try
            {
                return jobDal.GetList();
            }
            catch
            {
                return new List<Job>();
            }
        }

        public string Update(Job entity)
        {
            try
            {
                if (entity.Id < 1)
                {
                    return "Lütfen Geçerli Bir İş Seçiniz";
                }
                controlText = IsJobComplete(entity);
                if (controlText != "")
                {
                    return controlText;
                }
                return jobDal.Update(entity, "");
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        string IsJobComplete(Job job)
        {
            if (string.IsNullOrEmpty(job.JobName) || string.IsNullOrEmpty(job.JobContent))
            {
                return "Lütfen İş Bilgilerini Tam Giriniz";
            }
            if (job.JobName.Length > 100)
            {
                return "İş İsmi İçin En Fazla 100 Karakter Kullanabilirsiniz";
            }
            if (job.JobContent.Length > 500)
            {
                return "İş Açıklaması İçin En Fazla 500 Karakter Kullanabilirsiniz";
            }
            return "";
        }

        public static JobManager GetInstance()
        {
            if (jobManager == null)
            {
                jobManager = new JobManager();
            }
            return jobManager;
        }

        public List<Job> GetComboJobs(string personNo)
        {
            try
            {
                if (string.IsNullOrEmpty(personNo))
                {
                    return new List<Job>();
                }
                return jobDal.GetComboJobs(personNo);
            }
            catch
            {
                return new List<Job>();
            }
        }
    }
}
