using System;
using System.Collections.Generic;
using System.Net.Http;

namespace Foobify
{
    interface IRestify
    {
        void connect();
        void disconnect();
        Boolean checkAuthentication();
    }
}
