﻿using LRR.WebApp.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace LRR.WebApp.MVC.Controllers
{
    public class MainController : Controller
    {
        protected bool ResponsePossuiErros(ResponseResult resposta)
        {
            if(resposta != null && resposta.Errors.Mensagens.Any()) 
            {
                return true;
            }
            return false;
        }
    }
}
