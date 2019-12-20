using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FlyDreamOASystem.DTO.AttendanceDTO;
using FlyDreamOASystem.Model.Entitys.AttendanceEntity;
using SqlSugar;

namespace FlyDreamOASystem.BLL.AttendanceManage
{
    public class SigninInfoManage : IBLL.IAttendanceManage.ISigninInfoManage
    {
        private readonly IDAL.IAttendanceService.ISigninInfoService Service;
        public SigninInfoManage(IDAL.IAttendanceService.ISigninInfoService service) 
        {
            Service = service;
        }

        public async  Task<bool> Add(int lateTotal, int quitTotal, int leaveTotal, int userTotal,
            int dueTotal, int actualTotal, int summary)
        {
            return await Task.Run(()=> 
            {
              return   Service.Add(new Model.Entitys.AttendanceEntity.SigninInfo() 
              {
                Id=Guid.NewGuid(),
                Summary=summary,
                ActualTotal=actualTotal,
                DueTotal=dueTotal,
                LateTotal=lateTotal,
                LeaveTotal=leaveTotal,
                QuitTotal=quitTotal,
                UserTotal=userTotal
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

        public async  Task<List<SigninInfoDTO>> GetAll()
        {
            return await Service.GetAll().Select(m=> new DTO.AttendanceDTO.SigninInfoDTO()
            {
               Id=m.Id,
               Summary=m.Summary,
               ActualTotal=m.ActualTotal,
               CreateTime=m.CreateTime,
               DueTotal=m.DueTotal,
               LateTotal=m.LateTotal,
               LeaveTotal=m.LeaveTotal,
               QuitTotal=m.QuitTotal,
               UserTotal=m.UserTotal
            }).ToListAsync();
        }
    }
}
