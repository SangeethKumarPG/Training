using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCExampleProject.Models;
using Newtonsoft.Json;

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

        public IActionResult InsertEmployee()
        {
            return View();
        }

        public async Task<dynamic> InsertNewEmployee(string dataString)
        {
            string apiEndPoint = "https://localhost:7045/api/v1/InsertNewEmployee";
            string[] inputArray = dataString.Split("$");
            var data = "";
            using(var client = new HttpClient())
            {
                string requestContent = JsonConvert.SerializeObject(new
                {
                    id = inputArray[0],
                    name = inputArray[1],
                    dept= inputArray[2],
                    designation = inputArray[3]
                });

                var buffer = Encoding.UTF8.GetBytes(requestContent);

                var byteContent = new ByteArrayContent(buffer);

                byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                HttpResponseMessage result = await client.PostAsync(apiEndPoint, byteContent);

                if (result.IsSuccessStatusCode)
                {
                    data = result.Content.ReadAsStringAsync().Result;
                }
            }
            return data;
        }

        public IActionResult ViewEmployeeReportUsingModel()
        {
            return View();
        }

        public List<Employee> getEmployeeDataToModel(string datas)     //Get API Response
        {
            // Split the input string 'datas' using '$' as the delimiter
            //string[] datastring = datas.Split("$");
            // Construct the API path using the second and first elements of the split array
            string ApiPath = "https://localhost:7045/api/v1/" + datas;

            // Create an instance of HttpClient to make the HTTP request
            using (var client = new HttpClient())
            {
                // Initialize a variable to hold the response data
                List<Employee> employees = new List<Employee>();
                
                // Set the base address of the HttpClient to the constructed API path
                client.BaseAddress = new Uri(ApiPath);
                // Make a GET request to the API and wait for the result
                HttpResponseMessage result = client.GetAsync(client.BaseAddress).Result;
                // Check if the response indicates success
                if (result.IsSuccessStatusCode)
                {
                    // Read the response content as a string
                    var jsonData = result.Content.ReadAsStringAsync().Result;
                    var apiResponse = JsonConvert.DeserializeObject<List<dynamic>>(jsonData);
                    foreach(var item in apiResponse)
                    {
                        var employee = new Employee
                        {
                            EmpCode = item.id,
                            EmpName = item.name,
                            Position = item.designation,
                            Department = item.dept
                        };
                        employees.Add(employee);
                    }
                }
                // Return the response data 
                return employees;
            }
        }

        public IActionResult InsertEmployeeModel()
        {
            return View();
        }

        public async Task<dynamic> InsertNewEmployeeUsingModel([FromBody]Employee employee)
        {
            string apiEndPoint = "https://localhost:7045/api/v1/InsertNewEmployee";
            
            var data = "";
            using (var client = new HttpClient())
            {
                var apiData = new
                {
                    id = employee.EmpCode,
                    name = employee.EmpName,
                    designation = employee.Position,
                    dept = employee.Department
                };

                string requestContent = JsonConvert.SerializeObject(apiData);

                var buffer = Encoding.UTF8.GetBytes(requestContent);

                var byteContent = new ByteArrayContent(buffer);

                byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                HttpResponseMessage result = await client.PostAsync(apiEndPoint, byteContent);

                if (result.IsSuccessStatusCode)
                {
                    data = result.Content.ReadAsStringAsync().Result;
                }
            }
            return data;
        }

    }
}
