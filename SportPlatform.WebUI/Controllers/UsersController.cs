﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportPlatform.Application.Users.Commands.CreateUser;
using SportPlatform.Application.Users.Commands.DeleteUser;
using SportPlatform.Application.Users.Commands.UpdateUser;
using SportPlatform.Application.Users.Queries.GetAllUsersQuery;
using SportPlatform.Application.Users.Queries.GetUser;
using SportPlatform.Application.Users.Queries.LoginUserQuery;

namespace SportPlatform.WebUI.Controllers
{

    public class UsersController : BaseController
    {
        // GET: api/Users
        [HttpGet]
        public Task<UsersListViewModel> GetAllUsers()
        {
            return Mediator.Send(new GetAllUsersQuery());
        }

        // GET: api/Users/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<IActionResult> GetUser(int id)
        {
            return Ok(await Mediator.Send(new GetUserQuery() { Id = id }));
        }

        // POST: api/Users
        [HttpPost]
        [ProducesResponseType(typeof(UserViewModel), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> RegisterUser([FromBody] CreateUserCommand command)
        {
            var userId = await Mediator.Send(command);

            return CreatedAtAction("GetUser", new { id = userId });
        }

        [HttpPost]
        [ProducesResponseType(typeof(bool), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> Login([FromBody] LoginUserQuery command)
        {
            return Ok(await Mediator.Send(command));
        }

        // PUT: api/Users/5
        [HttpPut("{id}")]
        [ProducesResponseType(typeof(UserDTO), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> PutUser([FromRoute] int id, [FromBody] UpdateUserCommand command)
        {
            if(id != command.UserId)
            {
                return BadRequest();
            }

            return Ok(await Mediator.Send(command));
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public async Task<IActionResult> DeleteUser(int id)
        {
            await Mediator.Send(new DeleteUserCommand { Id = id });

            return NoContent();
        }


    }
}
