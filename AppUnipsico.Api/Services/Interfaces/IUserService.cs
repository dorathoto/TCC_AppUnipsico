﻿using AppUnipsico.Api.Models;
using AppUnipsico.Models.DTOs;

namespace AppUnipsico.Api.Services.Interfaces
{
    public interface IUserService
    {
        public Task<UserBaseModel> CreateUserAsync(CreateUserDto userModel);
        public Task<UserBaseModel> Login(RequestLoginDto userLoginDto);
        public Task<bool> ValidateCredentials(RequestLoginDto userLoginDto);
        public Task<IEnumerable<UserBaseModel>> GetAllTeachers();
        public Task<IEnumerable<UserBaseModel>> GetAllStudents();
        public Task<IEnumerable<UserBaseModel>> GetAllPatients();
    }
}
