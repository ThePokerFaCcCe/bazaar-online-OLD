using Microsoft.AspNetCore.Http;

namespace Testing.Application.Validators
{
    public static class FormFileValidator
    {
        public static bool IsValidImage(this IFormFile file)
        {
            try
            {
                var img = System.Drawing.Image.FromStream(file.OpenReadStream());
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }

        public static bool IsSizeSmallerThan(this IFormFile file, long kilobytes)
        {
            long size = kilobytes * 1024;
            return (file.Length <= size);
        }

        public static bool HasValidExtension(this IFormFile file, string[] extensions)
        {
            var extension = Path.GetExtension(file.FileName);
            return (extensions.Contains(extension.Trim().ToLower()));
        }



    }
}
