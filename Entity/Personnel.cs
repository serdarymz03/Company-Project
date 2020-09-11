using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Personnel
    {
        int id, departmentId, authId; string personNo, name,departmentName,authName;

        public int Id { get => id; set => id = value; }
        public int DepartmentId { get => departmentId; set => departmentId = value; }
        
        public int AuthId { get => authId; set => authId = value; }
        public string PersonNo { get => personNo; set => personNo = value; }
        public string Name { get => name; set => name = value; }
        public string DepartmentName { get => departmentName; set => departmentName = value; }
        public string AuthName { get => authName; set => authName = value; }

        public Personnel(int departmentId, int authId, string personNo, string name)
        {
            this.departmentId = departmentId;
            this.authId = authId;
            this.personNo = personNo;
            this.name = name;
        }

        public Personnel(int departmentId, int authId, string personNo, string name, string departmentName, string authName)
        {
            this.departmentId = departmentId;
            this.authId = authId;
            this.personNo = personNo;
            this.name = name;
            this.departmentName = departmentName;
            this.authName = authName;
        }

        public Personnel(int id, int departmentId, int authId, string personNo, string name, string departmentName, string authName)
        {
            this.id = id;
            this.departmentId = departmentId;
            this.authId = authId;
            this.personNo = personNo;
            this.name = name;
            this.departmentName = departmentName;
            this.authName = authName;
        }
    }
}
