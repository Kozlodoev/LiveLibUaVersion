using LiveLibUaVersionMVC.Data;

namespace LiveLibUaVersionMVC.Controllers
{
    public class AuthController : Controller
    {
        private readonly LibraryContext _context;

        public AuthController(LibraryContext context)
        {
            _context = context;
        }

        // GET: Auth/Login
        [Route("/login")]
        public IActionResult GetLoginScreen()
        {
            return View();
        }

        // POST: Auth/Login
        /*[HttpPost]
        [Route("/login")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(HttpContext context)
        {
            var form = context.Request.Form;

            if (!form.ContainsKey("email") || form.ContainsKey("password"))
                return ViewBag.Message = "Не вірний email і/або пароль...";

            string email = form["email"];
            string password = form["password"];

            Person? person = people.FirstOrDefault(p => p.Email == email && p.Password == password);

            if (person is null) return ViewBag.Message = "Користувач незнайдений...";

            var claims = new List<Claim> { new Claim(ClaimTypes.Name, person.Email) };

            ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, "Cookies");

            await context.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

            return RedirectToAction(nameof(Index));
        }*/

        /*public Task<IActionResult> Register(RegisterModel model)
        {

        }*/
    }
}
