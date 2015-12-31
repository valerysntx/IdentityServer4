﻿// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using IdentityServer4.Core.Hosting;
using IdentityServer4.Core.Models;
using IdentityServer4.Core.Validation;
using System.Threading.Tasks;

namespace IdentityServer4.Core.ResponseHandling
{
    interface IAuthorizeEndpointResultGenerator
    {
        Task<IEndpointResult> CreateErrorResultAsync(ErrorTypes errorType, string error, ValidatedAuthorizeRequest request);
        Task<IEndpointResult> CreateLoginResultAsync(ValidatedAuthorizeRequest request);
        Task<IEndpointResult> CreateConsentResultAsync(ValidatedAuthorizeRequest validatedRequest);
        Task<IEndpointResult> CreateAuthorizeResultAsync(AuthorizeResponse response);
    }
}