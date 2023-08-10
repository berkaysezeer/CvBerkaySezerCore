using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace CvBerkaySezerCore.Areas.Writer.Controllers
{
    [Authorize]
    [Area("Writer")]
    public class MessageController : Controller
    {
        WriterMessageManager messageManager = new WriterMessageManager(new EfWriterMessageDal());

        private readonly UserManager<WriterUser> _userManager;

        public MessageController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(HttpContext.User.Identity.Name);
            var email = user.Email;

            List<WriterMessage> messages = messages = messageManager.TGetReceiverMessage(email);

            return View(messages);
        }

        public async Task<IActionResult> SenderMessage()
        {
            var user = await _userManager.FindByNameAsync(HttpContext.User.Identity.Name);
            var email = user.Email;

            List<WriterMessage> messages = messages = messageManager.TGetSenderMessage(email);

            return View(messages);
        }
    }
}
