using E_CommerceWebApplication.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace E_CommerceWebApplication.Controllers;
public class CartController : Controller
{
    //private readonly IServicesType<Product> _productServices;
    //private readonly UserManager<IdentityUser> _userManager;

    //public CartController( IServicesType<Product> productServices)
    //{
    //    _productServices = productServices;
    //}
    //[Authorize]
    //public IActionResult AddToCart(int id)
    //{
    //    var user = HttpContext.User;
    //    string userId = _userManager.GetUserId(user);
    //    return Ok();
    //}
}
