using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;


namespace WebAPI.Models.Data.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly AuthenticationContext _context;
        private readonly ILogger<UserRepository> _logger;
        public UserRepository(AuthenticationContext context,ILogger<UserRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void Add<T>(T entity) where T : class
        {
            _logger.LogInformation($"Adding an object of type {entity.GetType()} to the context");
            _context.Add(entity);
            _context.SaveChanges();
        }

        public void Delete<T>(T entity) where T : class
        {
            _logger.LogInformation($"Removing an object of type {entity.GetType()} to the context");
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public bool SaveChanges()
        {
            _logger.LogInformation($"Attempting to save the changes in the context");
            return _context.SaveChanges() > 0;
        }

     
        UserDetail[] IUserRepository.GetAllUsers()
        {
            _logger.LogInformation($"Getting all users");
            IQueryable<UserDetail> query = _context.UserDetail;
            return query.ToArray();
        }
    }
}
