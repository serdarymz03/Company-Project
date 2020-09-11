using DataAccess.Abstract;
using DataAccess.Database;
using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class JobDetailDal : IRepository<JobDetail>
    {
        static JobDetailDal jobDetailDal;
        SqlService sqlService;
        SqlDataReader dataReader;
        bool result;

        public JobDetailDal()
        {
            sqlService = SqlDatabase.GetInstance();
        }
        public string Add(JobDetail entity)
        {
            try
            {
                dataReader = sqlService.StoreReader("IsDetayEkle", new SqlParameter("@isid", entity.JobId), new SqlParameter("@isveren", entity.EmployerNo), new SqlParameter("@isalan", entity.WorkerNo));
                if (dataReader.Read())
                {
                    result = dataReader[0].ConBool();
                }
                dataReader.Close();
                if (result)
                {
                    return "Aynı İş Kaydı Daha Önce" + entity.WorkerNo + " Personeline Verilmiş";
                }
                string workerName = PersonnelDal.GetInstance().GetPersonnelNameByPersonNo(entity.WorkerNo);

                return workerName + " İş Ataması Başarıyla Yapılmıştır";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Delete(int id)
        {
            throw new NotImplementedException();
        }

        public JobDetail Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<JobDetail> GetList()
        {
            throw new NotImplementedException();
        }

        public string Update(JobDetail entity, string oldName)
        {
            throw new NotImplementedException();
        }

        public static JobDetailDal GetInstance()
        {
            if (jobDetailDal == null)
            {
                jobDetailDal = new JobDetailDal();
            }
            return jobDetailDal;
        }

        public List<JobDetail> GetListByPersonNo(string procedurName, string personNo)
        {
            try
            {
                List<JobDetail> jobDetails = new List<JobDetail>();
                dataReader = sqlService.StoreReader(procedurName, new SqlParameter("@sicilno", personNo));
                while (dataReader.Read())
                {
                    JobDetail jobDetail;
                    if (procedurName.Contains("Admin"))
                    {
                        jobDetail = new JobDetail(dataReader["IS_DETAYID"].ConInt(), dataReader["IS_ID"].ConInt(), personNo, dataReader["AD_SOYAD"].ToString(), dataReader["IS_ADI"].ToString(), dataReader["IS_ACIKLAMA"].ToString(), dataReader["ISALAN"].ToString());
                    }
                    else
                    {
                        jobDetail = new JobDetail(dataReader["IS_DETAYID"].ConInt(), dataReader["IS_ID"].ConInt(), dataReader["ISVEREN"].ToString(), dataReader["AD_SOYAD"].ToString(), dataReader["IS_ADI"].ToString(), dataReader["IS_ACIKLAMA"].ToString(), personNo);
                    }
                    jobDetails.Add(jobDetail);
                }
                dataReader.Close();
                return jobDetails;
            }
            catch
            {
                return new List<JobDetail>();
            }
        }

        public int AdminPersonCount(string personNo)
        {
            try
            {
                int number = -1;
                dataReader = sqlService.StoreReader("AdminPersonelSayisi", new SqlParameter("@sicilno", personNo));
                if (dataReader.Read())
                {
                    number = dataReader["ELEMAN_SAYISI"].ConInt();
                }
                dataReader.Close();
                return number;
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
                int number = -1;
                dataReader = sqlService.StoreReader("AdminToplamIs");
                if (dataReader.Read())
                {
                    number = dataReader["TOPLAM_IS"].ConInt();
                }
                dataReader.Close();
                return number;
            }
            catch
            {
                return -1;
            }
        }
    }
}
