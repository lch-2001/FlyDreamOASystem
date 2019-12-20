using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlyDreamOASystem.BLL.ApprovalManage
{
    public class CopyManage : IBLL.IApprovalManage.ICopyManage
    {
        private readonly IDAL.IApprovalService.ICopyService Service;
        public CopyManage(IDAL.IApprovalService.ICopyService service) 
        {
            Service = service;
        }
        public async  Task<bool> AddCopy(Guid approvalFlowId, Guid userId)
        {
            return await Task.Run(() =>
            {
                return Service.Add(new Model.Entitys.ApprovalEntity.Copy() 
                {
                 Id=Guid.NewGuid(),
                 ApprovalFlowId=approvalFlowId,
                 UserId=userId
                });
            });
        }

        public async  Task<bool> DeleteMenu(Guid id)
        {
           return await  Task.Run(()=> 
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
