using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlyDreamOASystem.BLL.ApprovalManage
{
    public class FlowManage : IBLL.IApprovalManage.IFlowManage
    {
        private readonly IDAL.IApprovalService.IFlowService Service;
        public FlowManage(IDAL.IApprovalService.IFlowService service) 
        {
            Service = service;
        }
        public async  Task<bool> AddFlow(Guid approvalFlowId, int node, Guid? UserId)
        {
            return await Task.Run(()=> 
            {
                return Service.Add(new Model.Entitys.ApprovalEntity.Flow() 
                {
                    Id=Guid.NewGuid(),
                    ApprovalFlowId=approvalFlowId,
                    Node=node,
                    UserId=UserId
                });
            });
        }

        public  async Task<bool> DeleteMenu(Guid id)
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
