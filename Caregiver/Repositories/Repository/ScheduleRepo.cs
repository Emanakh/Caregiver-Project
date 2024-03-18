﻿using Caregiver.Dtos;
using Caregiver.Models;
using Caregiver.Repositories.IRepository;
using Microsoft.AspNetCore.Identity;
using static Caregiver.Enums.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Caregiver.Repositories.Repository
{
    public class ScheduleRepo : IScheduleRepo
    {
        
        private readonly ApplicationDBContext _db;
        private UserManager<User> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public ScheduleRepo(ApplicationDBContext db,UserManager<User> userManager, IHttpContextAccessor httpContextAccessor)
        {
            _db = db;
            _userManager = userManager;
            _httpContextAccessor= httpContextAccessor;
        }
        public async Task<UserManagerResponse> AddScheduleAsync(ScheduleDTO model)
        {
            var loggedInUserId = _userManager.GetUserId(_httpContextAccessor.HttpContext.User);
            var ayhaga = new CaregiverSchedule
            {
                CaregiverId = loggedInUserId,
                FromTime = model.FromTime,
                ToTime = model.ToTime,
                Status = model.Status

            };
            return new UserManagerResponse
            {
                Message = "User did not create",
                IsSuccess = false,
            };
        }
    }
}
