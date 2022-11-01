using Microsoft.AspNetCore.Http;
using System;

namespace ImparApi.Business.Helpers
{
    public static class FileConverter
    {
        public static string ConvertImageFileToBase64(IFormFile file)
        {
            long length = file.Length;
            if (length < 0)
                throw new Exception("Error with the file");

            using var fileStream = file.OpenReadStream();
            byte[] bytes = new byte[length];
            var base64 = fileStream.Read(bytes, 0, (int)file.Length);
            var base64String = Convert.ToBase64String(bytes);
            return base64String;
        }
    }
}