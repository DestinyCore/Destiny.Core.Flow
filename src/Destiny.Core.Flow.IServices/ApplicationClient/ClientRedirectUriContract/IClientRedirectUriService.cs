﻿using DestinyCore.Dependency;
using DestinyCore.Ui;
using IDN.Services.BasicsService.Dtos.IdentityServer4.ClientApplication;
using System.Threading.Tasks;

namespace Destiny.Core.Flow.IServices
{
    public interface IClientRedirectUriService : IScopedDependency
    {
        Task<OperationResponse> CreatAsync(ClientRedirectUriInputDto input);
    }
}
