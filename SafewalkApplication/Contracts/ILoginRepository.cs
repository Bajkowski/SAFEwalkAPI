﻿using SafewalkApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SafewalkApplication.Contracts
{
    public interface ILoginRepository
    {
        Task<User> Get(string email, string password, bool isUser);

    }
}
