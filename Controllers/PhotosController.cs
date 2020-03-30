using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PhotoApi.Models;

namespace PhotoApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class PhotosController : ControllerBase
  {
    private PhotoApiContext _db;

    public PhotosController(PhotoApiContext db)
    {
      _db = db;
    }

    // GET api/photos
    [HttpGet]
    public ActionResult<IEnumerable<Photo>> Get(string title, string tag, string url)
    {
      var query = _db.Photos.AsQueryable();

      if (title != null)
      {
        query = query.Where(entry => entry.Title == title);
      }

      if (tag != null)
      {
        query = query.Where(entry => entry.Tag == tag);
      }

      if (url != null)
      {
        query = query.Where(entry => entry.Url == url);
      }

      return query.ToList();
    }

    // POST api/photos
    [HttpPost]
    public void Post([FromBody] Photo photo)
    {
      _db.Photos.Add(photo);
      _db.SaveChanges();
    }

    // GET api/photos/5
    [HttpGet("{id}")]
    public ActionResult<Photo> Get(int id)
    {
      return _db.Photos.FirstOrDefault(entry => entry.PhotoId == id);
    }

    // PUT api/photos/8
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Photo photo)
    {
      photo.PhotoId = id;
      _db.Entry(photo).State = EntityState.Modified;
      _db.SaveChanges();
    }

    // Delete api/photos/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var photoToDelete = _db.Photos.FirstOrDefault(entry => entry.PhotoId == id);
      _db.Photos.Remove(photoToDelete);
      _db.SaveChanges();
    }
  }
}