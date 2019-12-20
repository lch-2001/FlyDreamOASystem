using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlyDreamOASystem.BLL.ApprovalManage
{
    public class UserapprovalDataManage : IBLL.IApprovalManage.IUserapprovalDataManage
    {
        private readonly IDAL.IApprovalService.IUserapprovalDataService Service;
        public UserapprovalDataManage(IDAL.IApprovalService.IUserapprovalDataService service) 
        {
            Service = service;
        }
        public async  Task<bool> Add(Guid approvalId, int node, Guid userId)
        {
            return await Task.Run(()=> 
            {
                return Service.Add(new Model.Entitys.ApprovalEntity.UserapprovalData() 
                {
                  Id=Guid.NewGuid(),
                  ApprovalId=approvalId,
                  Node=node,
                  UserId=userId
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
