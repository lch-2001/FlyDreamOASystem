using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FlyDreamOASystem.DTO.UserDTO;

namespace FlyDreamOASystem.BLL.UserManage
{
    public class UserInfoManage : IBLL.IUserManage.IUserInfoManage
    {
        private readonly IDAL.IUserService.IUserInfoService Service;
        public UserInfoManage(IDAL.IUserService.IUserInfoService service) 
        {
            Service = service;
        }
       
        public async  Task<bool> Add(Guid userId, string name, Guid dictionaryId, string idCard,
            DateTime birthday, int qQ, string phone, string adress, string ecducation, bool state,
            Guid positionId, string headimgurl, bool isManager = false)
        {
           return await Task.Run(()=> 
            {
                return Service.Add(new Model.Entitys.UserEntity.UserInfo() 
                {
                  UserId=userId,
                  State=state,
                  Adress=adress,
                  Birthday=birthday,
                  DictionaryId=dictionaryId,
                  Ecducation=ecducation,
                  Headimgurl=headimgurl,
                  Id=Guid.NewGuid(),
                  IdCard=idCard,
                  IsManager=isManager,
                  Name=name,
                  Phone=phone,
                  PositionId=positionId,
                  QQ=qQ
                });
            });
        }

        public async  Task<bool> DeleteMenu(Guid id)
        {
           return await Task.Run(()=> 
            {
              return   Service.Delete(id);
            });
        }

        public async  Task<bool> DeleteMenu(Guid id, bool isDelete)
        {
            return await Task.Run(() =>
            {
                return Service.Delete(id,isDelete);
            });
        }

        public async Task<List<UserInfoDTO>> GetAllInclude()
        {
           return await Task.Run(()=> 
            {
                return Service.GetAllInclude().Select((ur, uo, dy, pn) => new DTO.UserDTO.UserInfoDTO 
                {
                     Id=uo.Id,
                     State=uo.State,
                     Adress=uo.Adress,
                     UserName=ur.Name,
                     UserPass=ur.Pwd,
                     Birthday=uo.Birthday,
                     CreateTime=uo.CreateTime,
                     Sex=dy.Value,
                     Ecducation=uo.Ecducation,
                     Headimgurl=uo.Headimgurl,
                     IdCard=uo.IdCard,
                     IsManager=uo.IsManager,
                     Name=uo.Name,
                     Phone=uo.Phone,
                     PositionName=pn.Name,
                     QQ=uo.QQ
                }).ToList();
            });
        }
    }
}
