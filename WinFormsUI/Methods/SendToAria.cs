using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WinFormsUI.CustomClasses;
using V = VMS.TPS.Common.Model.API;
using Newtonsoft.Json;
using VMS.OIS.ARIALocal.WebServices.Document.Contracts;

namespace WinFormsUI.Methods
{
    public class SendToAria
    {
        private List<FileData> FilesToSend;
        private string PatientID;
        private string Physician;
        private List<PatientDocument> PatientDocuments;
        private V.User User;

        public SendToAria(List<FileData> files, string patientID, string physician, V.User user)
        {
            FilesToSend = files;
            PatientID = patientID;
            Physician = physician;
            User = user;
        }

        public bool Execute()
        {
            bool success = true;

            try
            {
                CreatePatientDocs();
                Send();
            }
            catch (Exception e)
            {
                success = false;
            }

            return success;
        }

        private void CreatePatientDocs()
        {
            PatientDocuments = new List<PatientDocument>();

            foreach (FileData fileData in FilesToSend)
            {

                PatientDocument pd = new PatientDocument(PatientID, User, fileData);

                PatientDocuments.Add(pd);
            }
        }

        private void Send()
        {
            foreach (PatientDocument pd in PatientDocuments)
            {
                string jsonDocument = JsonConvert.SerializeObject(pd);

                string request_base = "{\"__type\":\"";
                string request_document = $"{request_base}InsertDocumentRequest:http://services.varian.com/Patient/Documents\",{jsonDocument.TrimStart('{')}}}";
                string apiKey = ConfigurationManager.AppSettings["docKey"];
                string hostName = ConfigurationManager.AppSettings.Get("hostName");
                string port = ConfigurationManager.AppSettings.Get("port");
                string dockey = ConfigurationManager.AppSettings.Get("DocKey");
                string gatewayURL = $"https://{hostName}:{port}/Gateway/service.svc/interop/rest/Process";

                string sMediaTYpe = "application/json"; //bIsJson ? "application/json" :  "application/xml";
                string sResponse = System.String.Empty;

                using (var c = new HttpClient(new HttpClientHandler() { UseDefaultCredentials = true, PreAuthenticate = true }))
                {
                    if (c.DefaultRequestHeaders.Contains("ApiKey"))
                    {
                        c.DefaultRequestHeaders.Remove("ApiKey");
                    }

                    c.DefaultRequestHeaders.Add("ApiKey", apiKey);

                    var task = c.PostAsync(gatewayURL, new StringContent(request_document, Encoding.UTF8, sMediaTYpe));
                    Task.WaitAll(task);

                    var responseTask = task.Result.Content.ReadAsStringAsync();
                    Task.WaitAll(responseTask);

                    sResponse = responseTask.Result;
                }
            }

            return;
        }

    }
}
