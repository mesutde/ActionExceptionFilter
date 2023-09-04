using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ActionExceptionFilter.Filters
{
    public class GlobalException : ExceptionFilterAttribute
    {
        public async override Task OnExceptionAsync(ExceptionContext context)
        {
            // ActionResult Exception Fırlatmış mı kontrol ediyoruz.
            if (context.Exception.Message != null)
            {
                //ActionResult'tan Exception dönüyorsa gelen hata mesajını yakalıyoruz.
                string message = context.Exception.Message;

                var controllerName = context.RouteData.Values["controller"];
                var actionName = context.RouteData.Values["action"];
            

               var st = new StackTrace(context.Exception, true);
                // Get the top stack frame
                var frame = st.GetFrame(0);
                // Get the line number from the stack frame
                var line = frame.GetFileLineNumber();


                string logMessage = "Hata Mesajı Adı : " + message + "\n" +
                                    "Control Name : " + controllerName + "\n" +
                                    "Action Name : " + actionName + "\n" +
                                    "Hata veren satır numarası : " + line;


                // Belirtmiş olduğumuz Custom Hata sayfasına yönlendiriyoruz.
                context.Result = new RedirectResult("/ErrorPage"); 
            }
        }
    }
}
