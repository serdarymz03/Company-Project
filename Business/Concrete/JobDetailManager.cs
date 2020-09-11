using DataAccess.Concrete;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class JobDetailManager
    {
        static JobDetailManager jobManager;
        JobDetailDal jobDetailDal;
        string controlText;
        private JobDetailManager()
        {
            jobDetailDal = JobDetailDal.GetInstance();
        }

        public string Add(JobDetail entity)
        {
            try
            {
                controlText = IsJobDetailComplete(entity);
                if (controlText != "")
                {
                    return controlText;
                }
                return jobDetailDal.Add(entity);
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
                    return "Lütfen Geçerli Bir İş Detayı Seçiniz";
                }
                return jobDetailDal.Delete(id);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public JobDetail Get(int id)
        {
            return null;
        }

        public List<JobDetail> GetList(string procedurName, string personNo)
        {
            try
            {
                return jobDetailDal.GetListByPersonNo(procedurName, personNo);
            }
            catch
            {
                return new List<JobDetail>();
            }
        }

        public string Update(JobDetail entity)
        {
            try
            {
                if (entity.Id < 1)
                {
                    return "Lütfen Geçerli Bir İş Detayı Seçiniz";
                }
                controlText = IsJobDetailComplete(entity);
                if (controlText != "")
                {
                    return controlText;
                }                
                return jobDetailDal.Update(entity, "");
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string IsJobDetailComplete(JobDetail jobDetail)
        {
            if (jobDetail.JobId < 1 || string.IsNullOrEmpty(jobDetail.EmployerNo) || string.IsNullOrEmpty(jobDetail.WorkerNo))
            {
                return "Lütfen İş Detay Bilgilerini Tam Giriniz";
            }
            if (jobDetail.EmployerNo.Length > 6)
            {
                return "İşveren Sicil No İçin En Fazla 6 Karakter Kullanabilirsiniz";
            }
            if (jobDetail.WorkerNo.Length > 6)
            {
                return "Görev Alan Personel Sicil No İçin En Fazla 6 Karakter Kullanabilirsiniz";
            }
            return "";
        }

        public static JobDetailManager GetInstance()
        {
            if (jobManager == null)
            {
                jobManager = new JobDetailManager();
            }
            return jobManager;
        }

        public int AdminPersonCount(string personNo)
        {
            try
            {
                return jobDetailDal.AdminPersonCount(personNo);
            }
            catch
            {
                return -1;
            }
        }

        public int AdminTotalJobs()
        {
            try
            {
                return jobDetailDal.AdminTotalJobs();
            }
            catch 
            {
                return -1;
            }
        }
    }
}
