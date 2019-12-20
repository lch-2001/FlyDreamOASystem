using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlyDreamOASystem.BLL.ApprovalManage
{
    public class ApprovalFlowManage : IBLL.IApprovalManage.IApprovalFlowManage
    {
        private readonly IDAL.IApprovalService.IApprovalFlowService Service;
        public ApprovalFlowManage(IDAL.IApprovalService.IApprovalFlowService service) 
        {
            Service = service;
        }
        public async  Task<bool> AddApprovalFlow(Guid approvalId,int level)
        {
            return await Task.Run(()=> 
            {
              return    Service.Add(new Model.Entitys.ApprovalEntity.ApprovalFlow() 
                {
                   approvalId=approvalId,
                   level=level,
                   Id=Guid.NewGuid()
                });
            });
        }

        public async   Task<bool> DeleteMenu(Guid id)
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
