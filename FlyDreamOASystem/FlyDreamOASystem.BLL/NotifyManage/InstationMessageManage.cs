using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlyDreamOASystem.BLL.NotifyManage
{
    public class InstationMessageManage : IBLL.INotifyManage.IInstationMessageManage
    {
        private readonly IDAL.INotifyService.IInstationMessageService Service;
        public InstationMessageManage(IDAL.INotifyService.IInstationMessageService service)
        {
            Service = service;
        }
        public async  Task<bool> AddMessage(Guid sendId, Guid receiveId, Guid dictionaryStateId, string content)
        {
            return await Task.Run(()=> 
            {
               return  Service.Add(new Model.Entitys.NotifyEntity.InstationMessage() 
               {
                 Id=Guid.NewGuid(),
                 State=dictionaryStateId,
                 SendId=sendId,
                 Content=content,
                 ReceiveId=receiveId
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
