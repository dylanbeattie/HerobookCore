using Herobook.Data;
using Herobook.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Herobook.Controllers.Api
{
	public class StatusesController {
        private readonly DemoDatabase db;

        public StatusesController() {
            this.db = new DemoDatabase();
        }

        [Route("api/profiles/{username}/statuses")]
        [HttpGet]
        public object GetProfileStatuses(string username) {
            return db.LoadStatuses(username);
        }

        [Route("api/profiles/{username}/statuses")]
        [HttpPost]
        public object PostProfileStatus(string username, [FromBody]Status status) {
            status.Username = username;
            status.PostedAt = DateTimeOffset.Now;
            return db.CreateStatus(status);
        }

        [Route("api/profiles/{username}/statuses/{statusId}")]
        [HttpGet]
        public object GetProfileStatus(string username, Guid statusGuid) {
            return db.LoadStatus(statusGuid);
        }

        [Route("api/profiles/{username}/statuses/{statusId}")]
        [HttpPut]
        public object UpdateProfileStatus(string username, Guid statusId, [FromBody] Status status) {
            return db.UpdateStatus(statusId, status);
        }
    }
}