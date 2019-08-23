using System;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using WebAPI.Models;
using WebAPI.Models.Data;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserDetailController : ControllerBase
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;
        public UserDetailController(IUserRepository repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        [HttpPost]
        [Route("Save")]
        //POST : /api/UserDetail/Save
        public  ActionResult<UserDetailModel> SaveUserDetails([FromBody] UserDetailModel model)
        {
            try {
                if (model == null)
                {
                    return BadRequest();
                }

                var userDetail = _mapper.Map<UserDetail>(model);
                _repository.Add(userDetail);
                var userDetailToReturn = _mapper.Map<UserDetailModel>(userDetail);
                return Ok(userDetailToReturn);
               
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "A problem occured while handling the request");
            }
        }

        [HttpGet]
        [Route("Get")]
        //Get : /api/UserDetail/Get
        public ActionResult<UserDetailModel[]> GetUsers()
        {
            try
            {
                var userdetails = _repository.GetAllUsers();
                return _mapper.Map<UserDetailModel[]>(userdetails);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }
        }
    }
}