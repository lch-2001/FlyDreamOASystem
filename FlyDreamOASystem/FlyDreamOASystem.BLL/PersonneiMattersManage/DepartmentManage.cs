using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlyDreamOASystem.BLL.PersonneiMattersManage
{
    public class DepartmentManage : IBLL.IPersonneiMattersManage.IDepartmentManage
    {
        private readonly IDAL.IPersonneiMattersService.IDepartmentService Service;
        public DepartmentManage(IDAL.IPersonneiMattersService.IDepartmentService service) 
        {
            Service = service;
        }
        public async  Task<bool> AddDepartment(string name)
        {
            return await Task.Run(()=> 
            {
                return Service.Add(new Model.Entitys.PersonnelMattersEntity.Department() 
                {
                   Id=Guid.NewGuid(),
                   Name=name,
                
                  
                });
            });
        }
        public async Task<bool> AddDepartment(string name,Guid parentId)
        {
            return await Task.Run(() =>
            {
                return Service.Add(new Model.Entitys.PersonnelMattersEntity.Department()
                {
                    Id = Guid.NewGuid(),
                    Name = name,
                    ParentId=parentId
                });
            });
        }
        public async  Task<bool> Delete(Guid id)
        {
            return await Task.Run(()=>
            {
                return Service.Delete(id);
            });
        }

        public async  Task<bool> Delete(Guid id, bool isDelete)
        {
            return await Task.Run(() =>
            {
                return Service.Delete(id,isDelete);
            });
        }
    }
}
