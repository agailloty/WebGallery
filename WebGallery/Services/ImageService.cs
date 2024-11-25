using System.IO;

namespace WebGallery.Services
{
    public class ImageService
    {
        public string[] GetImageFiles(string directoryPath)
        {
            if (Directory.Exists(directoryPath))
            {
                return Directory.GetFiles(directoryPath, "*.*", SearchOption.AllDirectories)
                                .Where(file => file.EndsWith(".jpg") || file.EndsWith(".png") || file.EndsWith(".gif"))
                                .ToArray();
            }
            return Enumerable.Empty<string>().ToArray();
        }
    }
}
