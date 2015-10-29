﻿using System.Net.Http;

namespace HalClient.Net
{
    public interface IHalHttpClientFactory
    {
        IHalHttpClient CreateClient(HttpClient customHttpClient = null);
    }
}