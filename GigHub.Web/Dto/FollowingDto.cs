using GigHub.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GigHub.Web.Dto
{
    public class FollowingDto
    {

        public string FollowerId { get; set; }


        public string FolloweeId { get; set; }

        public ApplicationUser Follower { get; set; }

        public ApplicationUser Followee { get; set; }
    }
}