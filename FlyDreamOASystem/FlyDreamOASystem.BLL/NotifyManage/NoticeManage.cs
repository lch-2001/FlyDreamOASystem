using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlyDreamOASystem.BLL.NotifyManage
{
    public class NoticeManage : IBLL.INotifyManage.INoticeManage
    {
        private readonly IDAL.INotifyService.INoticeService Service;
        public NoticeManage(IDAL.INotifyService.INoticeService service) 
        {
            Service = service;
        }
        public async  Task<bool> AddNotice(Guid sendUserId, Guid dictionaryTypeId, Guid dictionaryStateId,
            Guid takeUserId, string title, string detail, long read, long unRead, int order)
        {
            return await Task.Run(()=> 
            {
                return Service.Add(new Model.Entitys.NotifyEntity.Notice() 
                {
                  Id=Guid.NewGuid(),
                  UserId=sendUserId,
                  DictionaryStateId=dictionaryStateId,
                  Detail=detail,
                  DictionaryId=dictionaryTypeId,
                  Order=order,
                  Read=read,
                  TakeUserId=takeUserId,
                  UnRead=unRead,
                  Title=title   
                });
            });
        }

        public async  Task<bool> Delete(Guid id)
        {
            return await Task.Run(()=> 
            {
              return   Service.Delete(id);
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
