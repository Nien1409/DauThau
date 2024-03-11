using BeDauThau.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace BeDauThau.Interface
{
    public interface IMainService
    {
        Task<List<Project>> GetAll();
        Task<Project> GetById(string id);
        Task<string> Delete(string id);
        Task<string> Create(Project reqiest);
    }
}
