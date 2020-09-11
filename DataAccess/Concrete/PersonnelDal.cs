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
    public class PersonnelDal : IRepository<Personnel>
    {
        static PersonnelDal personnelDal;
        SqlService sqlService;
        SqlDataReader dataReader;
        bool result;

        public PersonnelDal()
        {
            sqlService = SqlDatabase.GetInstance();
        }
        public string Add(Personnel entity)
        {
            try
            {
                dataReader = sqlService.StoreReader("PersonelEkle", new SqlParameter("@sicilno", entity.PersonNo), new SqlParameter("@adsoyad", entity.Name),
                    new SqlParameter("@departman", entity.DepartmentId), new SqlParameter("@yetkiid", entity.AuthId));
                if (dataReader.Read())
                {
                    result = dataReader[0].ConBool();
                }
                dataReader.Close();
                if (result)
                {
                    return entity.PersonNo + " Sicil Numarası Daha Önce Kullanılmış";
                }
                return entity.Name + " Personel Kaydı Başarıyla Tamamlanmıştır";
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
                sqlService.Stored("PersonelSil", new SqlParameter("@id", id));
                return "Personel Başarıyla Silindi";
            }
            catch (Exception ex)
            {
                return ex.Message; ;
            }
        }

        public Personnel Get(int id)
        {
            return null;
        }

        public List<Personnel> GetList()
        {
            try
            {
                List<Personnel> personnels = new List<Personnel>();
                dataReader = sqlService.StoreReader("PersonelListesi");
                while (dataReader.Read())
                {
                    personnels.Add(new Personnel(dataReader["ID"].ConInt(), dataReader["DEPARTMAN_ID"].ConInt(), dataReader["YETKI_ID"].ConInt(), dataReader["SICILNO"].ToString(), dataReader["AD_SOYAD"].ToString(), dataReader["DEPARTMAN_AD"].ToString(), dataReader["YETKI_AD"].ToString()));
                }
                dataReader.Close();
                return personnels;
            }
            catch
            {
                return new List<Personnel>();
            }
        }

        public string Update(Personnel entity, string oldName)
        {
            try
            {
                sqlService.Stored("PersonelGuncelle", new SqlParameter("@sicilno", entity.PersonNo), new SqlParameter("@adsoyad", entity.Name), new SqlParameter("@departmanId", entity.DepartmentId), new SqlParameter("@yetkiId", entity.AuthId));
                return entity.Name + " Personeli Başarıyla Güncellendi";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static PersonnelDal GetInstance()
        {
            if (personnelDal == null)
            {
                personnelDal = new PersonnelDal();
            }
            return personnelDal;
        }

        public object[] Login(string personNo, string password)
        {
            try
            {
                object[] infos = null;
                dataReader = sqlService.StoreReader("PersonelLogin", new SqlParameter("@sicilno", personNo), new SqlParameter("@sifre", password));
                if (dataReader.Read())
                {
                    string name, departmentName, authName; int id, departmentId, authId;

                    id = dataReader["ID"].ConInt();
                    name = dataReader["AD_SOYAD"].ToString();
                    departmentId = dataReader["DEPARTMAN_ID"].ConInt();
                    departmentName = dataReader["DEPARTMAN_AD"].ToString();
                    authId = dataReader["YETKI_ID"].ConInt();
                    authName = dataReader["YETKI_AD"].ToString();

                    infos = new object[] { id, personNo, name, departmentId, departmentName, authId, authName };
                }
                dataReader.Close();
                return infos;
            }
            catch
            {
                return null;
            }
        }

        public string GetPersonnelNameByPersonNo(string personNo)
        {
            try
            {
                string personnelName = "";
                dataReader = sqlService.StoreReader("PersonelIsmi", new SqlParameter("@sicilno", personNo));
                if (dataReader.Read())
                {
                    personnelName = dataReader["AD_SOYAD"].ToString();
                }
                dataReader.Close();
                return personnelName;
            }
            catch
            {
                return "";
            }
        }
    }
}
