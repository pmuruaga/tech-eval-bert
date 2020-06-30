using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using TechEvalBert.Helpers;
using TechEvalBert.Models;

namespace TechEvalBert.Business
{
    public class Albums
    {
        public async Task<List<Album>> GetAlbumsAsync()
        {
            string urlAlbums = "http://jsonplaceholder.typicode.com/albums";
            WebHelper webHelper = new WebHelper(urlAlbums);
            string responseBody = await webHelper.GetResponse();
            var albums = JsonSerializer.Deserialize<List<Album>>(responseBody);
            return albums;
        }

        public async Task<List<Photo>> GetAlbumPhotosAsync(int albumId)
        {
            string urlPhotos = "http://jsonplaceholder.typicode.com/photos/";
            WebHelper webHelper = new WebHelper(urlPhotos);
            string responseBody = await webHelper.GetResponse();
            var photos = JsonSerializer.Deserialize<List<Photo>>(responseBody);            
            return photos.Where(x => x.albumId == albumId).ToList();
        }

        public async Task<List<Comment>> GetPhotoCommentsAsync(int photoId)
        {
            string urlComments = "http://jsonplaceholder.typicode.com/comments";
            WebHelper webHelper = new WebHelper(urlComments);
            string responseBody = await webHelper.GetResponse();
            var photos = JsonSerializer.Deserialize<List<Comment>>(responseBody);
            return photos.Where(x => x.postId == photoId).ToList();
        }
    }
}
