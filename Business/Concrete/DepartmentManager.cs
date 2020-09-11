using DataAccess.Abstract;
using DataAccess.Concrete;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class DepartmentManager
    {
        static DepartmentManager departmentManager;
        DepartmentDal departmentDal;
        string controlText;
        private DepartmentManager()
        {
            departmentDal = DepartmentDal.GetInstance();
        }

        public string Add(Department entity)
        {
            try
            {
                controlText = IsDepartmentComplete(entity);
                if (controlText != "")
                {
                    return controlText;
                }
                return departmentDal.Add(entity);
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
                    return "Lütfen Geçerli Bir Departman Seçiniz";
                }
                return departmentDal.Delete(id);
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
                return departmentDal.GetList();
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
                if (entity.Id < 1)
                {
                    return "Lütfen Geçerli Bir Departman Seçiniz";
                }
                controlText = IsDepartmentComplete(entity);
                if (controlText != "")
                {
                    return controlText;
                }
                if (string.IsNullOrEmpty(oldName))
                {
                    return "Departman Bilgilerine Ulaşılamadı";
                }
                return departmentDal.Update(entity, oldName);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        string IsDepartmentComplete(Department department)
        {
            if (string.IsNullOrEmpty(department.Name) || string.IsNullOrEmpty(department.Description))
            {
                return "Lütfen Departman Bilgilerini Tam Giriniz";
            }
            if (department.Name.Length > 50)
            {
                return "Departman İsmi İçin En Fazla 50 Karakter Kullanabilirsiniz";
            }
            if (department.Description.Length > 100)
            {
                return "Departman Açıklaması İçin En Fazla 100 Karakter Kullanabilirsiniz";
            }
            return "";
        }

        public static DepartmentManager GetInstance()
        {
            if (departmentManager == null)
            {
                departmentManager = new DepartmentManager();
            }
            return departmentManager;
        }

        public string GetDepartmentNameByPersonNo(string personNo)
        {
            try
            {
                if (string.IsNullOrEmpty(personNo))
                {
                    return "";
                }
                return departmentDal.GetDepartmentNameByPersonNo(personNo);
            }
            catch
            {
                return "";
            }
        }
    }
}
