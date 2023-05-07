﻿using FactoryAPIProject.Models;
using Microsoft.AspNetCore.Identity;

namespace FactoryAPIProject.Services
{
    public interface IUserService
    {
        public Task<List<IdentityUser>> GetUsers();

    }
}
