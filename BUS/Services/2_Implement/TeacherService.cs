using BUS.Services._1_Interface;
using BUS.Viewmodel.Student;
using BUS.Viewmodel.Teacher;
using DAL.ApplicationDBContext;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services._2_Implement
{
    public class TeacherService : ITeacherService
    {
        private readonly ManagerStudent_DBContext _dbcontext;
        public TeacherService()
        {
            _dbcontext = new ManagerStudent_DBContext();
        }
        public async Task<bool> CreateAsync(TeacherCreateVM request)
        {
            if(request != null)
            {
                var obj = new Teacher
                {
                    TeacherCode = request.TeacherCode,
                    FullNameTeacher = request.FullNameTeacher,
                    PhoneNumber = request.PhoneNumber,
                    Email = request.Email,
                    Status = request.Status
                };
                await _dbcontext.Teacher.AddAsync(obj);
                await _dbcontext.SaveChangesAsync();
                return true;
            }
            return false;
        }
        public async Task<List<TeacherVM>> GetAllAsync()
        {
            var obj = await _dbcontext.Teacher.ToListAsync();

            var objVMs = obj.Select(s => new TeacherVM
            {
                TeacherCode = s.TeacherCode,
                FullNameTeacher = s.FullNameTeacher,
                PhoneNumber = s.PhoneNumber,
                Email = s.Email,
                CreateDate = s.CreateDate,
                Status = s.Status
            }).ToList();

            return objVMs;
        }
        public async Task<TeacherVM> GetByIDAsync(string Code)
        {
            var obj = await _dbcontext.Teacher
                                       .FirstOrDefaultAsync(s => s.TeacherCode == Code); 
            if (obj == null)
            {
                return null;
            }

            return new TeacherVM
            {
                TeacherCode = obj.TeacherCode,
                FullNameTeacher = obj.FullNameTeacher,
                PhoneNumber = obj.PhoneNumber,
                Email = obj.Email,
                CreateDate = obj.CreateDate,
                Status = obj.Status
            };
        }      
        public async Task<bool> RemoveAsync(string Code)
        {
            var obj = await _dbcontext.Teacher
                                        .FirstOrDefaultAsync(s => s.TeacherCode == Code);

            if (obj == null)
            {
                return false;
            }

            _dbcontext.Teacher.Remove(obj);
            await _dbcontext.SaveChangesAsync();
            return true;
        }
        public async Task<bool> UpdateAsync(string Code, TeacherUpdateVM request)
        {
            var obj = await _dbcontext.Teacher.FirstOrDefaultAsync(s => s.TeacherCode == Code);

            if (obj == null)
            {
                return false;
            }

            obj.TeacherCode = request.TeacherCode;
            obj.FullNameTeacher = request.FullNameTeacher;
            obj.Email = request.Email;
            obj.PhoneNumber = request.PhoneNumber;
            obj.Status = request.Status;
            obj.ModifieDate = DateTime.UtcNow;
            _dbcontext.Teacher.Update(obj);
            await _dbcontext.SaveChangesAsync();
            return true;
        }
    }
}
