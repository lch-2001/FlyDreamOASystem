using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlyDreamOASystem.BLL.PersonneiMattersManage
{
  public   class PositionAdnUserManage:IBLL.IPersonneiMattersManage.IPositionAndUserManage
    {
        private readonly IDAL.IPersonneiMattersService.IPositionAndUserService Service;
        public PositionAdnUserManage(IDAL.IPersonneiMattersService.IPositionAndUserService service)
        {
            Service = service;
        }

        public async  Task<bool> Add(Guid positionId, Guid userInfoId, string reason)
        {
            return await Task.Run(()=>
            {
                return Service.Add(new Model.Entitys.PersonnelMattersEntity.PositionAndUser() 
                {
                 Id=Guid.NewGuid(),
                 PositionId=positionId,
                 Reason=reason,
                 UserInfoId=userInfoId
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
