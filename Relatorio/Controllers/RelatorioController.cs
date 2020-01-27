using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Relatorio.Controllers
{
    public class RelatorioController : ApiController
    {
        public HttpResponseMessage Get()
        {
            
            var dataSet = new hotelDataSet();
            dataSet.clientes.AddclientesRow("André", "Lima", 30);
            dataSet.clientes.AddclientesRow("Kaique", "Lima", 24);
            dataSet.clientes.AddclientesRow("Caio", "Lima", 22);
            dataSet.clientes.AddclientesRow("André", "Lima", 30);
            dataSet.clientes.AddclientesRow("Kaique", "Lima", 24);
            dataSet.clientes.AddclientesRow("Caio", "Lima", 22);
            dataSet.clientes.AddclientesRow("André", "Lima", 30);
            dataSet.clientes.AddclientesRow("Kaique", "Lima", 24);
            dataSet.clientes.AddclientesRow("Caio", "Lima", 22);
            dataSet.clientes.AddclientesRow("André", "Lima", 30);
            dataSet.clientes.AddclientesRow("Kaique", "Lima", 24);
            dataSet.clientes.AddclientesRow("Caio", "Lima", 22);
            dataSet.clientes.AddclientesRow("André", "Lima", 30);
            dataSet.clientes.AddclientesRow("Kaique", "Lima", 24);
            dataSet.clientes.AddclientesRow("Caio", "Lima", 22);
            dataSet.clientes.AddclientesRow("André", "Lima", 30);
            dataSet.clientes.AddclientesRow("Kaique", "Lima", 24);
            dataSet.clientes.AddclientesRow("Caio", "Lima", 22);
            dataSet.clientes.AddclientesRow("André", "Lima", 30);
            dataSet.clientes.AddclientesRow("Kaique", "Lima", 24);
            dataSet.clientes.AddclientesRow("Caio", "Lima", 22);
            dataSet.clientes.AddclientesRow("André", "Lima", 30);
            dataSet.clientes.AddclientesRow("Kaique", "Lima", 24);
            dataSet.clientes.AddclientesRow("Caio", "Lima", 22);
            dataSet.clientes.AddclientesRow("André", "Lima", 30);
            dataSet.clientes.AddclientesRow("Kaique", "Lima", 24);
            dataSet.clientes.AddclientesRow("Caio", "Lima", 22);
            dataSet.clientes.AddclientesRow("André", "Lima", 30);
            dataSet.clientes.AddclientesRow("Kaique", "Lima", 24);
            dataSet.clientes.AddclientesRow("Caio", "Lima", 22);
            dataSet.clientes.AddclientesRow("André", "Lima", 30);
            dataSet.clientes.AddclientesRow("Kaique", "Lima", 24);
            dataSet.clientes.AddclientesRow("Caio", "Lima", 22);
            dataSet.clientes.AddclientesRow("André", "Lima", 30);
            dataSet.clientes.AddclientesRow("Kaique", "Lima", 24);
            dataSet.clientes.AddclientesRow("Caio", "Lima", 22);
            dataSet.clientes.AddclientesRow("André", "Lima", 30);
            dataSet.clientes.AddclientesRow("Kaique", "Lima", 24);
            dataSet.clientes.AddclientesRow("Caio", "Lima", 22);
            dataSet.clientes.AddclientesRow("André", "Lima", 30);
            dataSet.clientes.AddclientesRow("Kaique", "Lima", 24);
            dataSet.clientes.AddclientesRow("Caio", "Lima", 22);
            dataSet.clientes.AddclientesRow("André", "Lima", 30);
            dataSet.clientes.AddclientesRow("Kaique", "Lima", 24);
            dataSet.clientes.AddclientesRow("André", "Lima", 30);
            dataSet.clientes.AddclientesRow("Kaique", "Lima", 24);
            dataSet.clientes.AddclientesRow("Caio", "Lima", 22);
            dataSet.clientes.AddclientesRow("André", "Lima", 30);
            dataSet.clientes.AddclientesRow("Kaique", "Lima", 24);
            dataSet.clientes.AddclientesRow("Caio", "Lima", 22);

            dataSet.clientes.AddclientesRow("Caio", "Lima", 22);

            var report = new Microsoft.Reporting.WebForms.LocalReport();
            report.ReportPath = System.Web.Hosting.HostingEnvironment.MapPath("~/Reports/RelClientes.rdlc");
            report.DataSources.Add(new Microsoft.Reporting.WebForms.ReportDataSource("DataSetClientes", (System.Data.DataTable)dataSet.clientes));
            report.Refresh();
 
            string mimeType = "";
            string encoding = "";
            string filenameExtension = "";
            string[] streams = null;
            Microsoft.Reporting.WebForms.Warning[] warnings = null;
            byte[] bytes = report.Render("PDF", null, out mimeType, out encoding, out filenameExtension, out streams, out warnings);
 
            HttpResponseMessage result = new HttpResponseMessage(HttpStatusCode.OK);
            result.Content = new ByteArrayContent(bytes);
            result.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(mimeType);
            return result;
        }
    }
}
