using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlyDreamOASystem.BLL.WorkManage
{
    public class BenchManage : IBLL.IWorkManage.IBenchManage
    {
        private readonly IDAL.IWorkService.IBenchService Service;
        public BenchManage(IDAL.IWorkService.IBenchService service) 
        {
            Service = service;
        }
        public async  Task<bool> AddBench(string name, string url, Guid userInfoId)
        {
            return await Task.Run(()=> 
            {
                return Service.Add(new Model.Entitys.WorkEntity.Bench() 
                {
                  Id=Guid.NewGuid(),
                  Name=name,
                  Url=url,
                  UserInfoId=userInfoId
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
