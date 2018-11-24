﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportPlatform.Application.Users.Queries.GetUser
{
    public class GetUserQuery : IRequest<UserViewModel>
    {
        public int Id { get; set; }
    }
}
