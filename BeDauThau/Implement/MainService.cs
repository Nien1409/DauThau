
using BeDauThau.Interface;
using BeDauThau.Models;
using System.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace BeDauThau.Implement
{
    public class MainService : IMainService
    {
        private readonly DauThauContext _dbContext;

        public MainService(DauThauContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Project>> GetAll()
        {
            try
            {
                var data = _dbContext.Projects.ToList();

                return data;
            }
            catch (Exception ex)
            {
                throw new Exception ("looix");
            }
        }
        public async Task<Project> GetById(string id)
        {
            try
            {
                var data = _dbContext.Projects.FirstOrDefault(x => x.Pjid == id);

                return data;
            }
            catch (Exception ex)
            {
                throw new Exception("looix");
            }
        }
        public async Task<string> Create(Project request)
        {
            try
            {
                await _dbContext.AddAsync(request);
                await _dbContext.SaveChangesAsync();
                return "Done";
            }
            catch (Exception ex)
            {
                throw new Exception("looix");
            }
        }
        public async Task<string> Delete(string id)
        {
            try
            {
                var data =  _dbContext.Projects.FirstOrDefault(x => x.Pjid == id);
                _dbContext.Remove(data);
               await _dbContext.SaveChangesAsync();
                return "Done"; 

            }
            catch (Exception ex)
            {
                throw new Exception("looix");
            }
        }
    }
}
