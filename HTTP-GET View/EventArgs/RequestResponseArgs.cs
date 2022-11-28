using System;
using System.Collections.Generic;
using System.Text;

namespace HTTP_GET_View.EventArgs
{
    /// <summary>
    /// The <see cref="RequestResponseArgs"/> class.
    /// </summary>
    public class RequestResponseArgs : System.EventArgs
    {
        public string Response { get; set; }

        public RequestResponseArgs()
        {
            Response = string.Empty;
        }

        public RequestResponseArgs(string response) : this()
        {
            Response = response;
        }
    }
}
