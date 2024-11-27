using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VillaAPI.Controllers
{
    [Route("ErrorHandling")]
    [ApiController]
    [AllowAnonymous] // not reuqired any authentication
    [ApiVersionNeutral] // this is for using in any version 
    [ApiExplorerSettings(IgnoreApi = true)]// this is for prevent to show in swagger
    public class ErrorHandlingController : ControllerBase
    {
        [Route("ProcessError")]
        public IActionResult ProcessError([FromServices] IHostEnvironment hostEnvironment)
        {
            if (hostEnvironment.IsDevelopment())
            {
                //custom logic
                var feature = HttpContext.Features.Get<IExceptionHandlerFeature>();

                return Problem(
                    detail: feature.Error.StackTrace,
                    title: feature.Error.Message,
                    instance: hostEnvironment.EnvironmentName
                    );
            }
            else
            {
                return Problem();
            }
        }


    }
}
