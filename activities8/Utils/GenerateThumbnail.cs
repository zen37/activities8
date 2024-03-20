using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Jpeg;
using SixLabors.ImageSharp.Processing;

namespace activities8.Utils;
public class GenerateThumbnail {
    public static async Task<string> GetReducedImageBase64(IFormFile file)
    {
        try 
         {
            using (var image = await Image.LoadAsync(file.OpenReadStream()))
                {
                    // Resize the image to 100x100 pixels and preserve the aspect ratio
                    image.Mutate(x => x.Resize(new ResizeOptions
                    {
                        Size = new Size(200, 200),
                        Mode = ResizeMode.Max,
                    }));

                    // Save the thumbnail to a MemoryStream
                    using (var thumbnailStream = new MemoryStream())
                    {
                        await image.SaveAsync(thumbnailStream, new JpegEncoder());

                        // Convert the thumbnail to a base64 string
                        var thumbnailBytes = thumbnailStream.ToArray();
                        var thumbnailBase64 = Convert.ToBase64String(thumbnailBytes);
                        return thumbnailBase64;
                    }
                }

            }
            catch (Exception ex)
            {
            return $"Failed to GetReducedImageBase64: {ex.Message}";
        }
    }
}
