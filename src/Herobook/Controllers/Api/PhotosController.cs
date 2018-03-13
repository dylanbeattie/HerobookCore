using Herobook.Data;
using Herobook.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Herobook.Controllers.Api
{
	public class PhotosController : Controller {
        private readonly IDatabase db;

        public PhotosController() {
            this.db = new DemoDatabase();
        }

        [Route("api/profiles/{username}/photos")]
        [HttpGet]
        public object GetProfilePhotos(string username) {
            return db.LoadPhotos(username);
        }


        [Route("api/profiles/{username}/photos")]
        [HttpPost]
        public object PostProfilePhoto(string username, [FromBody] Photo photo) {
            photo.Username = username;
            photo.PostedAt = DateTimeOffset.Now;
            return db.CreatePhoto(photo);
        }

        [Route("api/profiles/{username}/photos/{photoId}")]
        [HttpGet]
        public object GetProfilePhoto(string username, Guid photoId) {
            var photo = db.LoadPhoto(photoId);
            return photo;
        }

        [Route("api/profiles/{username}/photos/{photoId}")]
        [HttpPut]
        public object UpdateProfilePhoto(string username, Guid photoId, [FromBody] Photo photo) {
            return db.UpdatePhoto(photoId, photo);
        }

        [Route("api/profiles/{username}/photos/{photoId}")]
        [HttpDelete]
        public void DeleteProfilePhoto(string username, Guid photoId) {
            db.DeletePhoto(photoId);
        }
    }
}