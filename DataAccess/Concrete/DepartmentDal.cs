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
    public class DepartmentDal : IRepository<Department>
    {
        static DepartmentDal departmentDal;
        SqlService sqlService;
        SqlDataReader dataReader;
        bool result;

        public DepartmentDal()
        {
            sqlService = SqlDatabase.GetInstance();
        }

        public string Add(Department entity)
        {
            try
            {
                dataReader = sqlService.StoreReader("DepartmanEkle", new SqlParameter("@departmanAd", entity.Name), new SqlParameter("@aciklama", entity.Description));
                if (dataReader.Read())
                {
                    result = dataReader[0].ConBool();
                }
                dataReader.Close();
                if (result)
                {
                    return entity.Name + " İsmiyle Kayıtlı Başka Bir Departman Bulunuyor";
                }
                return entity.Name + " Departmanı Başarıyla Kaydedildi";
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
                sqlService.Stored("DepartmanSil", new SqlParameter("@id", id));
                return "Departman Başarıyla Silindi";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Department Get(int id)
        {
            return null;
        }

        public List<Department> GetList()
        {
            try
            {
                List<Department> departments = new List<Department>();
                dataReader = sqlService.StoreReader("DepartmanListele");
                while (dataReader.Read())
                {
                    departments.Add(new Department(dataReader["ID"].ConInt(), dataReader["DEPARTMAN_AD"].ToString(), dataReader["ACIKLAMA"].ToString()));
                }
                dataReader.Close();
                return departments;
            }
            catch
            {
                return new List<Department>();
            }
        }

        public string Update(Department entity, string oldName)
        {
            try
            {
                dataReader = sqlService.StoreReader("DepartmanGuncelle", new SqlParameter("@id", entity.Id), new SqlParameter("@departmanAd", entity.Name), new SqlParameter("@aciklama", entity.Description), new SqlParameter("@departmanEskiAd", oldName));
                if (dataReader.Read())
                {
                    result = dataReader[0].ConBool();
                }
                dataReader.Close();
                if (result)
                {
                    return entity.Name + " İsmiyle Kayıtlı Başka Bir Departman Bulunuyor";
                }
                return entity.Name + " Departmanı Başarıyla Güncellendi";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static DepartmentDal GetInstance()
        {
            if (departmentDal == null)
            {
                departmentDal = new DepartmentDal();
            }
            return departmentDal;
        }

        public string GetDepartmentNameByPersonNo(string personNo)
        {
            try
            {
                string departmentName = "";
                dataReader = sqlService.StoreReader("DepartmanIsmi", new SqlParameter("@sicilno", personNo));
                if (dataReader.Read())
                {
                    departmentName = dataReader["DEPARTMAN_AD"].ToString();
                }
                dataReader.Close();
                return departmentName;
            }
            catch
            {
                return "";
            }
        }
    }
}
