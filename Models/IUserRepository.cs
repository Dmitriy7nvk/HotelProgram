﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HotelProgram.Models
{
    public interface IUserRepository
    {
        bool AuthenticateUser(NetworkCredential credential);
        void Add(User user);
        void Edit(User user);
        void Remove(int id);
        User GetById(int id);
        User GetByUsername(string username);
        IEnumerable<User> GetByAll();
    }
}