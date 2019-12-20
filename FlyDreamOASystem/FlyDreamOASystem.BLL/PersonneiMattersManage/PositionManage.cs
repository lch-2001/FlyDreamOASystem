using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlyDreamOASystem.BLL.PersonneiMattersManage
{
    public class PositionManage : IBLL.IPersonneiMattersManage.IPositionManage
    {
        public IDAL.IPersonneiMattersService.IPositionService Service { get; set; }

        public PositionManage(IDAL.IPersonneiMattersService.IPositionService service)
        {
            Service = service;
        }

        public async  Task<bool> AddPosition(Guid departmentId, string name, decimal pay)
        {
            return await Task.Run(()=> 
            {
                return Service.Add(new Model.Entitys.PersonnelMattersEntity.Position() 
                {
                  Id=Guid.NewGuid(),
                  Name=name,
                  Pay=pay,
                  DepartmentId=departmentId,
                  
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
