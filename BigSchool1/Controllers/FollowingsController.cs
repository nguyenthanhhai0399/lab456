using BigSchool1.DTOs;
using BigSchool1.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BigSchool1.Controllers
{
    public class FollowingsController : ApiController
    {
        private readonly ApplicationDbContext _dbContext;
        public FollowingsController()
        {
            _dbContext = new ApplicationDbContext();
        }
        [HttpPost]
        public IHttpActionResult Follow(FollowingDto FollowingDto)
        {
            var userId = User.Identity.GetUserId();
            if (_dbContext.Folowings.Any(f => f.FollowerId == userId && f.FolloweeId == FollowingDto.FolloweeId))
                return BadRequest("The Attendance already exist!");
            var following = new Following
            {

                FollowerId = userId,
                FolloweeId = FollowingDto.FolloweeId
            };
            _dbContext.Attendances.Add(following);
            _dbContext.SaveChanges();
            return Ok();
        }
    }
}
