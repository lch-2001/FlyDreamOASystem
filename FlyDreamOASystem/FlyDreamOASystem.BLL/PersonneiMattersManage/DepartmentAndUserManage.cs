using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlyDreamOASystem.BLL.PersonneiMattersManage
{
    public class DepartmentAndUserManage : IBLL.IPersonneiMattersManage.IDepartmentAndUserManage
    {
        private readonly IDAL.IPersonneiMattersService.IDepartmentAndUserService Service;
        public DepartmentAndUserManage(IDAL.IPersonneiMattersService.IDepartmentAndUserService service) 
        {
            Service = service;
        }
        public async  Task<bool> Add(Guid userId, Guid departmentId, string reason)
        {
            return await  Task.Run(()=> 
            {
                return Service.Add(new Model.Entitys.PersonnelMattersEntity.DepartmentAndUser() 
                {
                  Id=Guid.NewGuid(),
                  Reason=reason,
                  DepartmentId=departmentId,
                  UserId=userId
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
