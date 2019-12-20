using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlyDreamOASystem.BLL.WorkManage
{
    public class MemoManage : IBLL.IWorkManage.IMemoManage
    {
        private readonly IDAL.IWorkService.IMemoService Service;
        public MemoManage(IDAL.IWorkService.IMemoService service) 
        {
            Service = service;
        }
        public async  Task<bool> AddMemo(Guid userId, string content)
        {
            return await Task.Run(()=> 
            {
                return Service.Add(new Model.Entitys.WorkEntity.Memo() 
                {
                  Id=Guid.NewGuid(),
                  Content=content,
                  UserInfoId=userId
                  
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
