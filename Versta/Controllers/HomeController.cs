using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Versta.Models;
using Versta.Entities;
using Microsoft.EntityFrameworkCore;



namespace Versta.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}


        private OrderContext db;

        public HomeController(OrderContext context)
        {
            db = context;
        }


        private OrderModel GetModel(IEnumerable<OrderInfo> orders) => new OrderModel
        {
            Orders = orders
        };


        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(GetModel(await db.OrdersDB.ToListAsync()));
        }


        public IActionResult Index1()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateNewOrder() 
        {
            CreateNewOrderModel model = new CreateNewOrderModel();
            //OrderInfo? userInfo = (from usr in db.OrdersDB
                                  //where usr.Email == User.Identity.Name
            //                      select usr).FirstOrDefault();
            //model.User = userInfo!;
            return View(model);
        }


        [HttpPost]
        public async Task<ActionResult> CreateNewOrder(CreateNewOrderModel model)
        {
            string guid = Guid.NewGuid().ToString();
            if (ModelState.IsValid)
            {
                db.OrdersDB.Add(new OrderInfo()
                {
                    unique_id = guid,
                    city_from = model.CityFrom,
                    address_from = model.AdressFrom,
                    city_to = model.CityTo,
                    address_to = model.AdressTo,
                    weight = model.Weight,
                    date = model.Date
                });
                await db.SaveChangesAsync();
                // запись добавлена, id сгенерировался,
                // повторно userInfo чтобы вынуть id для redirect
                OrderInfo orderInfo1 = (from ord in db.OrdersDB
                                            where ord.unique_id == guid 
                                        select ord).SingleOrDefault();
                return RedirectToAction("OrderPage", new { id = orderInfo1?.id });
                //return View(model);
            }
            else
            {
                return View(model);
            }
        }


        public IActionResult OrderPage(int id)
        {
            OrderInfo? orderInfo = (from ord in db.OrdersDB
                                  where ord.id == id
                                  select ord).SingleOrDefault();
            OrderModel order = new OrderModel();
            order.Order = orderInfo!;
            return View(order);
        }

        public IActionResult Privacy()
        {
            return View();
        }


    }
}