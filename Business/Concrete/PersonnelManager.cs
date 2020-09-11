using DataAccess.Concrete;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PersonnelManager
    {
        static PersonnelManager jobManager;
        PersonnelDal personnelDal;
        string controlText;
        private PersonnelManager()
        {
            personnelDal = PersonnelDal.GetInstance();
        }

        public string Add(Personnel entity)
        {
            try
            {
                controlText = IsPersonnelComplete(entity);
                if (controlText != "")
                {
                    return controlText;
                }
                return personnelDal.Add(entity);
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
                    return "Lütfen Geçerli Bir Personel Seçiniz";
                }
                return personnelDal.Delete(id);
            }
            catch (Exception ex)
            {
                return ex.Message;
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
                return personnelDal.GetList();
            }
            catch
            {
                return new List<Personnel>();
            }
        }

        public string Update(Personnel entity)
        {
            try
            {
                if (entity.Id < 1)
                {
                    return "Lütfen Geçerli Bir Personel Seçiniz";
                }
                controlText = IsPersonnelComplete(entity);
                if (controlText != "")
                {
                    return controlText;
                }
                return personnelDal.Update(entity, "");
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        string IsPersonnelComplete(Personnel personnel)
        {
            if (personnel.PersonNo.Length != 6)
            {
                return "Personel Sicil No 6 Karakterli Olmalıdır";
            }
            if (string.IsNullOrEmpty(personnel.Name) || personnel.DepartmentId < 1 || personnel.AuthId < 1)
            {
                return "Lütfen Personel Bilgilerini Tam Giriniz";
            }
            if (personnel.Name.Length > 50)
            {
                return "Personel İsim İçin En Fazla 50 Karakter Kullanabilirsiniz";
            }
            return "";
        }

        public static PersonnelManager GetInstance()
        {
            if (jobManager == null)
            {
                jobManager = new PersonnelManager();
            }
            return jobManager;
        }

        public object[] Login(string personNo, string password)
        {
            try
            {
                return personnelDal.Login(personNo.Trim(), password.Trim());
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
                if (string.IsNullOrEmpty(personNo))
                {
                    return "";
                }
                return personnelDal.GetPersonnelNameByPersonNo(personNo);
            }
            catch
            {
                return "";
            }
        }
    }
}
