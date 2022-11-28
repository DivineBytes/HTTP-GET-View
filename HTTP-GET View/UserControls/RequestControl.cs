using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

using HTTP_GET_View.EventArgs;
using HTTP_GET_View.Properties;
using HTTP_GET_View.Utilities;

namespace HTTP_GET_View.UserControls
{
    public partial class RequestControl : UserControl
    {
        public delegate void RequestResponseChangedDelegate(object sender, RequestResponseArgs eventArgs);
        public event RequestResponseChangedDelegate RequestResponseChanged;

        public RequestControl()
        {
            InitializeComponent();

            CB_Type.SelectedIndex = 0;

            TB_Url.Text = Settings.Default.URL;
            TB_UserAgent.Text = Settings.Default.UserAgent;
        }

        private void BTN_GET_Click(object sender, System.EventArgs e)
        {
            HTTPUtilities.InitializeSecurityProtocol();

            if (!string.IsNullOrEmpty(TB_Url.Text))
            {
                var httpWebRequest = HTTPUtilities.CreateHttpWebRequest(TB_Url.Text, TB_UserAgent.Text);
             
                var requestResponse = string.Empty;
                switch (CB_Type.Text)
                {
                    case "Content":
                        var webResponse = HTTPUtilities.GetWebResponse(httpWebRequest);
                        requestResponse = HTTPUtilities.GetResponseStream(webResponse);
                        break;
                    case "Header":
                        var httpWebResponse = HTTPUtilities.GetHttpWebResponse(httpWebRequest);
                        requestResponse = HTTPUtilities.GetResponseHeaders(httpWebResponse);
                        break;
                    //case "JSON":
                    //    requestResponse = HTTPUtilities.GetJsonData(TB_Url.Text, TB_UserAgent.Text);

                    //    try
                    //    {
                    //        // dynamic module = JsonConvert.DeserializeObject(requestResponse);

                    //    }
                    //    catch (Exception ex)
                    //    {
                    //        Console.WriteLine(ex);
                    //    }
                        

                    //    // TODO: Output module to a PropertyGridView object

                    //    break;
                }

                OnRequestResponseChanged(new RequestResponseArgs(requestResponse));
            }
        }

        protected virtual void OnRequestResponseChanged(RequestResponseArgs eventArgs)
        {
            RequestResponseChanged?.Invoke(this, eventArgs);
        }
    }
}
