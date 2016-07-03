using GigHub.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNet.Identity;
using GigHub.Web.Dto;

namespace GigHub.Web.Controllers
{
    [Authorize]
    public class FollowingsController : ApiController
    {
        private ApplicationDbContext _context;

        public FollowingsController()
        {
            this._context = new ApplicationDbContext(); 
        }

        [HttpPost]
        public IHttpActionResult Follow(FollowingDto dto) 
        {
            var userId = User.Identity.GetUserId();
            var exists = _context.Followings.Any(a => a.FollowerId == userId && a.FolloweeId == dto.FolloweeId);

            if (exists)
            {
                return BadRequest("");
            }

            var following = new Following
            {
                FollowerId = userId,
                FolloweeId = dto.FolloweeId
            };
            _context.Followings.Add(following);
            _context.SaveChanges();

            return Ok();
        }
    }
}
