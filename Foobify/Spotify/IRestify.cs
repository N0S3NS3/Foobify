using System;
using System.Collections.Generic;
using System.Net.Http;

namespace Spotify
{
    interface IRestify
    {
        void connect();
        void disconnect();
        Boolean checkAuthentication();
    }
}
