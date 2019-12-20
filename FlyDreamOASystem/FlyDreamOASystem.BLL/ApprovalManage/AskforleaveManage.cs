using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlyDreamOASystem.BLL.ApprovalManage
{
    public class AskforleaveManage : IBLL.IApprovalManage.IAskforleaveManage
    {
        private readonly IDAL.IApprovalService.IAskforleaveService Service;
        public AskforleaveManage(IDAL.IApprovalService.IAskforleaveService service) 
        {
            Service = service;
        }

        public async  Task<bool> AddAskfor(Guid userId, DateTime startTime, DateTime endTime, 
            int dayCount, string reason, Guid dictionaryStateId)
        {
            return await Task.Run(()=> 
            {
                return Service.Add(new Model.Entitys.ApprovalEntity.Askforleave() 
                {
                  Count=dayCount,
                  StartTime=startTime,
                  DictionaryState=dictionaryStateId,
                  EndTime=endTime,
                  Id=Guid.NewGuid(),
                  Reason=reason,
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
