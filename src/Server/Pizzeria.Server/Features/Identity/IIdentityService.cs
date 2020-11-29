﻿namespace Pizzeria.Server.Features.Identity
{
    using System.Threading.Tasks;
    using Infrastructure.Common;
    using Infrastructure.Services.Common;
    using Models;

    public interface IIdentityService : IService
    {
        Task<Result> RegisterAsync(RegisterRequestModel model);

        Task<Result<LoginResponseModel>> LoginAsync(LoginRequestModel model);
    }
}
