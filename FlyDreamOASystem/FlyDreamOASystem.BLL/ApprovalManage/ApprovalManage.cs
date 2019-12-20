using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlyDreamOASystem.BLL.ApprovalManage
{
    public class ApprovalManage : IBLL.IApprovalManage.IApprovalManage
    {
        private readonly IDAL.IApprovalService.IApprovalService Service;
        public ApprovalManage(IDAL.IApprovalService.IApprovalService service) 
        {
            Service = service;
        }
        public async  Task<bool> AddApproval(Guid userId, string name, string season, string icon, Guid dictionaryStateId)
        {
            return await Task.Run(()=> 
            {
                return Service.Add(new Model.Entitys.ApprovalEntity.Approval() 
                {
                 Id=Guid.NewGuid(),
                 UserId=userId,
                 Name=name,
                 Season=season,
                 Icon=icon,
                 State=dictionaryStateId,
                 
                });
            });
        }

        public async  Task<bool> DeleteMenu(Guid id)
        {
            return await Task.Run(()=>
            {
                return Service.Delete(id);
            });
        }

        public async  Task<bool> DeleteMenu(Guid id, bool isDelete)
        {
            return await Task.Run(() =>
            {
                return Service.Delete(id,isDelete);
            });
        }
    }
}
