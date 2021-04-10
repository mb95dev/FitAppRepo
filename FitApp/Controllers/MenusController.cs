﻿using FitApp.ApplicationServices.API;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenusController : ControllerBase
    {
        private readonly IMediator _mediator;
        public MenusController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetMenus([FromQuery] GetMenusRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> AddMenu([FromQuery] GetMenusRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }
        [HttpPut]
        [Route("")]
        public async Task<IActionResult> UpdateMenu([FromQuery] GetMenusRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }
        [HttpDelete]
        [Route("")]
        public async Task<IActionResult> DeleteMenu([FromQuery] GetMenusRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
