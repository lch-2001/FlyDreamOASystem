using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlyDreamOASystem.BLL.ApprovalManage
{
    public class UserapprovalNodeDataManage : IBLL.IApprovalManage.IUserapprovalNodeDataManage
    {
        private readonly IDAL.IApprovalService.IUserapprovalNodeDataService Service;
        public UserapprovalNodeDataManage(IDAL.IApprovalService.IUserapprovalNodeDataService service) 
        {
            Service = service;
        }
        public async  Task<bool> AddNodeData(Guid userapprovalDataId, int node, Guid dictionaryStateId)
        {
            return await Task.Run(()=> 
            {
                return Service.Add(new Model.Entitys.ApprovalEntity.UserapprovalNodeData() 
                {
                  Id=Guid.NewGuid(),
                  DictionaryStateId=dictionaryStateId,
                  Node=node,
                  UserapprovalDataId=userapprovalDataId
                });
            });
        }

        public async  Task<bool> DeleteMenu(Guid id)
        {
            return await Task.Run(()=> 
            {
               return  Service.Delete(id);
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
