using Microsoft.AspNetCore.Mvc;

namespace MVCExampleProject.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult HomePage()
        {
            return View();
        }

        public IActionResult ViewEmployeeReport()
        {
            return View();
        }

        public string getAPIData(string datas)     //Get API Response
        {
            // Split the input string 'datas' using '$' as the delimiter
            //string[] datastring = datas.Split("$");
            // Construct the API path using the second and first elements of the split array
            string ApiPath = "https://localhost:7045/api/v1/" + datas;

            // Create an instance of HttpClient to make the HTTP request
            using (var client = new HttpClient())
            {
                // Initialize a variable to hold the response data
                string data = "";
                // Set the base address of the HttpClient to the constructed API path
                client.BaseAddress = new Uri(ApiPath);
                // Make a GET request to the API and wait for the result
                HttpResponseMessage result = client.GetAsync(client.BaseAddress).Result;
                // Check if the response indicates success
                if (result.IsSuccessStatusCode)
                {
                    // Read the response content as a string
                    data = result.Content.ReadAsStringAsync().Result;
                }
                // Return the response data 
                return data;
            }
        }

        public IActionResult SearchEmployee()
        {
            return View();
        }

        public string GetEmployeeName(string name) {
            string apiEndPoint = "https://localhost:7045/api/v1/SearchEmployeesByName/" + name;
            using (var client = new HttpClient()) {
                string data = "";
                client.BaseAddress = new Uri(apiEndPoint);
                HttpResponseMessage result = client.GetAsync(client.BaseAddress).Result;
                if (result.IsSuccessStatusCode) {
                    data = result.Content.ReadAsStringAsync().Result;

                }
                return data;
            }

        }

        public string GetEmployeeById(string id)
        {
            string apiEndPoint = "https://localhost:7045/api/v1/SearchEmployeesById/" + id;
            using(var client = new HttpClient())
            {
                string data = "";
                client.BaseAddress = new Uri(apiEndPoint);
                HttpResponseMessage result = client.GetAsync(client.BaseAddress).Result;
                if (result.IsSuccessStatusCode)
                {
                    data = result.Content.ReadAsStringAsync().Result;
                }
                return data;
            }
        }
    }
}
