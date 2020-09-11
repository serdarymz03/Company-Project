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
    public class JobDal : IRepository<Job>
    {
        static JobDal jobDal;
        SqlService sqlService;
        SqlDataReader dataReader;
        bool result;

        public JobDal()
        {
            sqlService = SqlDatabase.GetInstance();
        }
        public string Add(Job entity)
        {
            try
            {
                dataReader = sqlService.StoreReader("IsEkle", new SqlParameter("@isAdi", entity.JobName), new SqlParameter("@isAciklama", entity.JobContent));
                if (dataReader.Read())
                {
                    result = dataReader[0].ConBool();
                }
                dataReader.Close();
                if (result)
                {
                    return entity.JobName + " Adıyla Kayıtlı Farklı Bir İş Kaydı Bulunuyor";
                }
                return entity.JobName + " İş Kaydı Başarıyla Oluşturuldu";
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
                sqlService.Stored("IsSil", new SqlParameter("@id", id));
                return "İş Kaydı Başarıyla Silindi";
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
                List<Job> jobs = new List<Job>();
                dataReader = sqlService.StoreReader("IsListesi");
                while (dataReader.Read())
                {
                    jobs.Add(new Job(dataReader["ID"].ConInt(), dataReader["IS_ADI"].ToString(), dataReader["IS_ACIKLAMA"].ToString(), dataReader["TARIH"].ConDate()));
                }
                dataReader.Close();
                return jobs;
            }
            catch
            {
                return new List<Job>();
            }
        }

        public string Update(Job entity, string oldName)
        {
            try
            {
                dataReader = sqlService.StoreReader("IsGuncelle", new SqlParameter("@id", entity.Id), new SqlParameter("@isAdi", entity.JobName), new SqlParameter("@isAciklama", entity.JobContent));
                if (dataReader.Read())
                {
                    result = dataReader[0].ConBool();
                }
                dataReader.Close();
                if (result)
                {
                    return entity.JobName + " Adıyla Kayıtlı Farklı Bir İş Kaydı Bulunuyor";
                }
                return entity.JobName + " İş Kaydı Başarıyla Güncellendi";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static JobDal GetInstance()
        {
            if (jobDal == null)
            {
                jobDal = new JobDal();
            }
            return jobDal;
        }

        public List<Job> GetComboJobs(string personNo)
        {
            try
            {
                List<Job> jobs = new List<Job>();
                dataReader = sqlService.StoreReader("PersonelIsListele", new SqlParameter("@sicilno", personNo));
                while (dataReader.Read())
                {
                    jobs.Add(new Job(dataReader["ID"].ConInt(), dataReader["IS_ADI"].ToString()));
                }
                dataReader.Close();
                return jobs;
            }
            catch(Exception ex)
            {
                return new List<Job>();
            }
        }
    }
}
