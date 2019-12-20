using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FlyDreamOASystem.DTO.AttendanceDTO;

namespace FlyDreamOASystem.BLL.AttendanceManage
{
    public class SigninManage : IBLL.IAttendanceManage.ISigninManage
    {
        private readonly IDAL.IAttendanceService.ISigninService Service;
        public SigninManage(IDAL.IAttendanceService.ISigninService service) 
        {
            Service = service;
        }
        
        public async Task<bool> AddSignin(Guid userId, Guid dictionaryTypeId, bool late, bool quit, string summary, Guid dictionaryStateId)
        {
            return await Task.Run(() =>
            {
                return Service.Add(new Model.Entitys.AttendanceEntity.Signin()
                {
                    Id=Guid.NewGuid(),
                    Summary=summary,
                    DictionaryStateId=dictionaryStateId,
                    UserId=userId,
                    Late=late,
                    Quit=quit,
                    DictionaryTypeId= dictionaryTypeId

                });
            });
        }

        public async  Task<bool> DeleteMenu(Guid id)
        {
            return  await Task.Run(()=> 
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
