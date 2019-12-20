using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlyDreamOASystem.BLL.JournalManage
{
    public class WorklogManage : IBLL.IJournalManage.IWorklogManage
    {
        private readonly IDAL.IJournalService.IWorklogService Service;
        public   WorklogManage(IDAL.IJournalService.IWorklogService service)
        {
            Service = service;
        }
        public async  Task<bool> AddLogin(Guid userId, string content)
        {

            return await Task.Run(()=> 
            {
               return  Service.Add(new Model.Entitys.JournalEntity.Worklog() 
                {
                  Id=Guid.NewGuid(),
                  Content=content,
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
