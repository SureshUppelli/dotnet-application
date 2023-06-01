using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dotnet_application.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        
        public void OnGet()
        {

        }
        // vulneravle code
        [HttpGet]
public ActionResult DownloadFile(string fileName)
{
    var filePath = $"~/files/{fileName}";
    var fullPath = Server.MapPath(filePath);
    return File(fullPath, "application/octet-stream", fileName);
}
[HttpPost]
public ActionResult ParseXML()
{
    var xmlInput = Request.InputStream;
    var xmlDoc = new XmlDocument();
    xmlDoc.Load(xmlInput);
    // Process XML
}
var query = "SELECT * FROM Users WHERE Username = '" + userInput + "'";
var command = new SqlCommand(query, connection);
var json = "{ \"type\": \"MyApp.User\", \"data\": \"some malicious payload\" }";
var user = JsonConvert.DeserializeObject(json);

[HttpGet]
public ActionResult ViewOrder(int orderId)
{
    Order order = dbContext.Orders.FirstOrDefault(o => o.Id == orderId);
    return View(order);
}

var command = "ping " + ipAddress;
var process = new Process
{
    StartInfo = new ProcessStartInfo
    {
        FileName = "cmd.exe",
        Arguments = "/c " + command,
        RedirectStandardOutput = true,
        UseShellExecute = false,
        CreateNoWindow = true
    }
};

        //end of vulneralble code 
    }
}
