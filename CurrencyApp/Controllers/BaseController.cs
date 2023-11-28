using AutoMapper;
using Currency.Entities.EntityModels;
using Currency.Service.Contracts;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CurrencyApp.Controllers
{
    public class BaseController : Controller
    {

        public readonly IServiceManager _serviceManager;
        public readonly IMapper _mapper;
        public BaseController(IServiceManager services, IMapper mapper)
        {
            _serviceManager = services;
            _mapper = mapper;
        }

    }
}
