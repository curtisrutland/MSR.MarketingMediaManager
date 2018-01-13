using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using MSR.MarketingMediaManager.Helpers;

namespace MSR.MarketingMediaManager.Controllers
{
    [RoutePrefix("api/media")]
    public class MediaController : ApiController
    {
        [HttpPost]
        [Route("")]
        public async Task<int> UploadMedia()
        {
            if (!Request.Content.IsMimeMultipartContent())
                throw new HttpResponseException(HttpStatusCode.UnsupportedMediaType);

            var provider = GetMultipartProvider();
            await Request.Content.ReadAsMultipartAsync(provider);
            var uploadedFile = provider.FileData.First();
            var contentType = uploadedFile.Headers.ContentType.MediaType;
            var uploadedFileInfo = new FileInfo(uploadedFile.LocalFileName);
            var inferredMimeType = MimeTypeHelper.GetMimeType(uploadedFileInfo);
            if(inferredMimeType == null) throw new HttpResponseException(HttpStatusCode.UnsupportedMediaType);
            return 1;
        }

        private static MultipartFormDataStreamProvider GetMultipartProvider()
        {
            var root = HttpContext.Current.Server.MapPath("~/App_Data");
            Directory.CreateDirectory(root);
            return new MultipartFormDataStreamProvider(root);
        }
    }
}