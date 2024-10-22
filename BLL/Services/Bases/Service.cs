﻿#nullable disable

using BLL.DAL;

namespace BLL.Services.Bases
{
    public abstract class Service
    {
        public bool IsSuccessful { get; set; }

        public string Message { get; set; } = string.Empty;

        public readonly Db _db;
        public Service(Db db)
        {
            _db = db;
        }

        public Service Success(string message = "") 
        { 
            IsSuccessful = true;
            Message = message;
            return this;
        }

        public Service Error (string message = "")
        { 
            IsSuccessful = false; 
            Message = message; 
            return this; 
        }
    }
}
