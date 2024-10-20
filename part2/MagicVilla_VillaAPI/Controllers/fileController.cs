using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VillaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [ApiVersion("1.0", Deprecated = true)]

    public class fileController : ControllerBase
    {

        private const int MaxFileSizeInMB = 2;
        private static readonly string[] AllowedExtensions = { ".jpg", ".jpeg", ".png" };



        [HttpPost("uploadImage")]
        public async Task<IActionResult> UploadImage(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                return BadRequest("File is empty.");
            }

            // Check if the file exceeds the size limit
            if (file.Length > MaxFileSizeInMB * 1024 * 1024)
            {
                return BadRequest($"File size exceeds {MaxFileSizeInMB}MB.");
            }

            // Validate file extension
            var fileExtension = Path.GetExtension(file.FileName).ToLowerInvariant();
            if (!AllowedExtensions.Contains(fileExtension))
            {
                return BadRequest("Invalid file type.");
            }

            // Generate a unique file name
            var uniqueFileName = Guid.NewGuid() + fileExtension;

            // Combine the file name and the upload path
            var uploadPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", uniqueFileName);
            try
            {
                // Ensure the directory exists
                Directory.CreateDirectory(Path.GetDirectoryName(uploadPath));

                using (var fileStream = new FileStream(uploadPath, FileMode.Create))
                {
                    await file.CopyToAsync(fileStream);
                }
                // i need to generate the url of the image
                var url = $"{Request.Scheme}://{Request.Host}/images/{uniqueFileName}";



                return Ok(new { url });
            }
            catch (Exception ex)
            {
                // Log the exception here (e.g., using a logging framework)
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

    }
}
