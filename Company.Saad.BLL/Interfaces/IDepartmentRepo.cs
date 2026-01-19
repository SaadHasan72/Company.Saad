using Coompany.Saad.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Saad.BLL.Interfaces
{
    public interface IDepartmentRepo
    {
        IEnumerable<Department> GetALL();

        Department? Get(int id);

        int Add(Department model);
        int Update(Department model);
        int Delete(Department moedl);
    }
}
