using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlyDreamOASystem.BLL.WorkManage
{
    public class WorkPlanManage : IBLL.IWorkManage.IWorkPlanManage
    {
        private readonly IDAL.IWorkService.IWorkPlanService Service;
        public WorkPlanManage(IDAL.IWorkService.IWorkPlanService service)
        {
            Service = service;
        }
        public async  Task<bool> AddWork(string doneWork, string undoneWork, string logWork, string content,
            Guid userInfoId, Guid dictionaryStatusId, Guid commitUserId)
        {
            return await Task.Run(()=> 
            {
                return Service.Add(new Model.Entitys.WorkEntity.WorkPlan() 
                {
                  Id=Guid.NewGuid(),
                  DictionaryStatusId=dictionaryStatusId,
                  CommitUserId=commitUserId,
                  Content=content,
                  DoneWork=doneWork,
                  LogWork=logWork,
                  UndoneWork=undoneWork,
                  UserInfoId=userInfoId
                });
             });
        }

        public async  Task<bool> Delete(Guid id)
        {
            return await Task.Run(()=> 
            {
               return  Service.Delete(id);
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
