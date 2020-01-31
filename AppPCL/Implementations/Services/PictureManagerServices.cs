using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPCL.Implementations.Services
{
    public class PictureManagerServices
    {
        private Cloudinary cloudinary = null;

        private Account account = null;
        public PictureManagerServices()
        {
            account = new Account("djrqtnswg", "566887958465752", "tt4KlQG49SafIY6iK7KsOEJZNTo");
            cloudinary = new Cloudinary(account);
        }
        public string UploadPicture(string FilePath)
        {
            ImageUploadParams uploadParams = new CloudinaryDotNet.Actions.ImageUploadParams()
            {
                File = new FileDescription(FilePath)
            };
            ImageUploadResult uploadResult = cloudinary.Upload(uploadParams);
            string UploadedPictureURL = cloudinary.Api.UrlImgUp.BuildUrl(String.Format("{0}.{1}", uploadResult.PublicId, uploadResult.Format));
            return UploadedPictureURL;
        }
    }
}
