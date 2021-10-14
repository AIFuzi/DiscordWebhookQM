using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DiscordWebhookQM.Modules
{
    class WebhookMessageModule
    {
        private WebRequest wRequest;

        public void SendMessage(string Message, string webhookUrl, string ImageUrl, string HexColor)
        {
            InitWebTH(webhookUrl);

            string hrx = "ffffff"; ;
            if (HexColor != "")
            {
                var hCol = HexColor.Split('#');
                hrx = hCol[1];
            }
            int col = Convert.ToInt32(hrx, 16);

            try
            {
                using (var messageWriter = new StreamWriter(wRequest.GetRequestStream()))
                {
                    string jsonMsg = "";
                    if (ImageUrl != "")
                    {
                        jsonMsg = JsonConvert.SerializeObject(new
                        {
                            username = "",
                            content = Message,
                            embeds = new[]
                            {
                                new
                                {
                                    title = "",
                                    description = "",
                                    color = col,
                                    image = new { url = ImageUrl }
                                }
                            }
                        });
                    }
                    else
                    {
                        jsonMsg = JsonConvert.SerializeObject(new
                        {
                            username = "",
                            content = Message,
                        });
                    }

                    messageWriter.Write(jsonMsg);
                }

                var response = (HttpWebResponse)wRequest.GetResponse();

                ClearWebTH();
            }
            catch (Exception e)
            {
                //ShowError(e);
            }
        }

        private void ClearWebTH()
        {
            wRequest = null;
        }

        private void InitWebTH(string webhookUrl)
        {
            wRequest = (HttpWebRequest)WebRequest.Create(webhookUrl);
            wRequest.ContentType = "application/json";
            wRequest.Method = "POST";
        }
    }
}
