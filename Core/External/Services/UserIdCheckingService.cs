﻿using Core.External.Interfaces;
using Core.External.Models.Options;
using Core.External.Models.Response;
using Microsoft.Extensions.Options;

namespace Core.External.Services;

public class UserIdCheckingService : IUserIdCheckingService
{
    // Started this with chatgpt..
    // Major changes maybe needed seeing as this might be a gRPC that I need to contact.
    // Awaiting documentation before making a bunch of changes.
    // Was changed to REST last week but no valid controller to check against.


    private readonly HttpClient _httpClient;
    private readonly string _userApiUrl;

    public UserIdCheckingService(HttpClient httpClient, IOptions<UserCheckingOptions> options)
    {
        _httpClient = httpClient;
        _userApiUrl = options.Value.Url;
    }

    public async Task<ExternalResponse> UserExistanceCheck(string userId)
    {
        return ExternalResponse.Ok();
    }
}
