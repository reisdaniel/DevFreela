using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.ExpectionHandler
{
    public class ApiExceptionHandler : IExceptionHandler
    {
        public async Task HandleExceptionAsync(HttpContext httpContext)
        {
            var details = new ProblemDetails
            {
                Status = StatusCodes.Status500InternalServerError,
                Title = "Server Error"
            };

            // Adicionar lógica como logar o erro, se necessário

            httpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;

            await httpContext.Response.WriteAsJsonAsync(details);
        }

        public ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
