using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Linq;

namespace HTTP_GET_View.Utilities
{
    /// <summary>
    /// The <see cref="HTTPUtilities"/> class.
    /// </summary>
    public class HTTPUtilities
    {
        public static HttpWebRequest CreateHttpWebRequest(string url, string userAgent, int timeoutMs = 10000)
        {
            if (string.IsNullOrEmpty(url))
            {
                throw new ApplicationException("Specify the URI of the resource to retrieve.");
            }

            try
            {
                Uri ourUri = new Uri(url);

                HttpWebRequest http = (HttpWebRequest)WebRequest.Create(ourUri);
                http.KeepAlive = false;
                http.UserAgent = userAgent;
                http.Timeout = timeoutMs;
                return http;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return null;
        }

        public static WebResponse GetWebResponse(HttpWebRequest httpWebRequest)
        {
            if (httpWebRequest == null)
            {
                throw new ArgumentException("The httpWebRequest is null.");
            }

            try
            {
                WebResponse response = httpWebRequest.GetResponse();
               
                return response;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return null;
        }

        public static HttpWebResponse GetHttpWebResponse(HttpWebRequest httpWebRequest)
        {
            try
            {
                HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                return httpWebResponse;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return null;
        }

        public static string GetResponseHeaders(HttpWebResponse response)
        {
            //using (response)
            //{
            //    using (Stream response_stream = response.GetResponseStream())
            //    {
            //        if (response_stream.CanRead)
            //        {
            //            byte[] buffer = new byte[16654];
            //            int read;
            //            using (MemoryStream s = new MemoryStream())
            //            {
            //                while ((read = response_stream.Read(buffer, 0, buffer.Length)) > 0)
            //                {
            //                    s.Write(buffer, 0, read);
            //                }

            //                var body = new byte[s.Length];
            //                s.Seek(0, SeekOrigin.Begin);
            //                s.Read(body, 0, body.Length);
            //            }
            //        }
            //    }

            string baseT = response.ResponseUri.Scheme.ToUpper() + "/" + response.ProtocolVersion;
            
            var statusCode = response.StatusCode;
                var statusCodeValue = (int)response.StatusCode;

                //var ContentType = response.GetResponseHeader("Content-Type");
                //var ContentLength = response.GetResponseHeader("Content-Length");
                //var ETag = response.GetResponseHeader("ETag");

                string content = string.Empty;
                content += baseT + " " + statusCodeValue + " " + statusCode + Environment.NewLine;

                var headers = response.Headers.AllKeys;

                foreach (var header in headers)
                {
                    string headerContent = response.GetResponseHeader(header);
                    content += header + ": " + headerContent + Environment.NewLine;
                }
                return content;
        }
        /// <summary>Initializes the security protocol.</summary>
        public static void InitializeSecurityProtocol()
        {
            ServicePointManager.Expect100Continue = true;

            // Note: Required for .NET 4.0 to create a secure TSL channel.
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        }

        public static string GetJsonData(string url, string userAgent, int timeoutMs = 10000)
        {
            HttpWebRequest httpWebRequest = System.Net.WebRequest.Create(url) as HttpWebRequest;
            httpWebRequest.UserAgent = userAgent;
            httpWebRequest.Timeout = timeoutMs;

            using (HttpWebResponse httpWebResponse = httpWebRequest.GetResponse() as HttpWebResponse)
            {
                if (httpWebResponse.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception(string.Format("Server error (HTTP {0}: {1}).",
                        httpWebResponse.StatusCode, httpWebResponse.StatusDescription));
                }

                Stream stream = httpWebResponse.GetResponseStream();

                if (stream != null)
                {
                    StreamReader sr = new StreamReader(stream);
                    string content = sr.ReadToEnd();
                    return content;
                }


            //    using (var webClient = new System.Net.WebClient())
            //{
                
            //    var json = webClient.DownloadString(url);
            //    dynamic module = JsonConvert.DeserializeObject(json);

            //    return json;
            }

            return string.Empty;
        }

        //public static string GetResponseHeaders(HttpWebRequest httpWebRequest)
        //{
        //    if (httpWebRequest == null)
        //    {
        //        throw new ArgumentException("The httpWebRequest is null.");
        //    }
            
        //    try
        //    {
                
        //        //var response = await httpClient.GetAsync("https://localhost:12345/stocks/MSFT");

        //        //foreach (var header in response.Headers)
        //        //{
        //        //    Console.WriteLine($"{header.Key}={header.Value.First()}");
        //        //}

        //        //var HttpWebResponse = HttpWebResponse(HttpWebResponse) httpWebRequest.GetResponse();
               
        //        //string value = httpWebResponse.GetResponseHeader("Content-Length");

        //       // var headers = webResponse.Headers.AllKeys;

        //        string content = string.Empty;
        //        //foreach (var header in headers)
        //        //{
        //        //    content += header + Environment.NewLine;
        //        //}

        //        return content;
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e);
        //    }
            
        //    return string.Empty;
        //}

        public static string GetResponseStream(WebResponse webResponse)
        {
            if (webResponse == null)
            {
                throw new ArgumentException("The webResponse is null.");
            }
            
            try
            {
                Stream stream = webResponse.GetResponseStream();
                
                if (stream != null)
                {
                    StreamReader sr = new StreamReader(stream);
                    string content = sr.ReadToEnd();
                    return content;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return string.Empty;
        }

        /// <summary>
        ///     Checks for internet connection.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <param name="timeoutMs">The timeout ms.</param>
        /// <returns>The <see cref="bool" />.</returns>
        public static bool CheckForInternetConnection(string url, int timeoutMs = 10000)
        {
            if (string.IsNullOrEmpty(url))
            {
                throw new ApplicationException("Specify the URI of the resource to retrieve.");
            }

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.KeepAlive = false;
                request.Timeout = timeoutMs;
                // request.UserAgent = string.Empty;
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
