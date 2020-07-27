using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieStore.Core.Entities;
using MovieStore.Core.Models.Request;
using MovieStore.Core.ServiceInterfaces;

namespace MovieStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class PurchaseController : ControllerBase
    {
        private readonly IUserService _userService;

        public PurchaseController(IUserService userService){

            _userService = userService;
                }

        [HttpPost]
        public async Task<Purchase> Post(PurchaseRequestModel purchaseRequstModel)
        {
            return await _userService.Purchase(purchaseRequstModel);
        }
    }
}
