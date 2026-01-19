using Company.Saad.BLL.Interfaces;
using Coompany.Saad.DAL.Data.Contexts;
using Coompany.Saad.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Saad.BLL.Repositories
{
    public class DepartmentRepository : IDepartmentRepo
    {
       private readonly  CompanyDBContext _Context;

        public DepartmentRepository()
        {
            _Context=new CompanyDBContext();
        }

        public IEnumerable<Department> GetALL()
        {
          
                return _Context.Departments.ToList();
            
            
        }

        public Department? Get(int id)
        {
          
                return _Context.Departments.Find(id);
            
        }
        public int Add(Department model)
        {
            
                _Context.Departments.Add(model);

                return _Context.SaveChanges();

            
        }



        public int Update(Department model)
        {
           
                _Context.Departments.Update(model);

                return _Context.SaveChanges();

            
        }

        public int Delete(Department moedl)
        {
            
                _Context.Departments.Remove(moedl);

                return _Context.SaveChanges();

            
        }

   

      
    }
}
