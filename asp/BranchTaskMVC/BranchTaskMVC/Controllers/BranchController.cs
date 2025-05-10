using System.Xml.Linq;
using BranchTaskMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BranchTaskMVC.Controllers
{
    public class BranchController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BranchList()
        {
            return View();
        }

        public string getBranchList()
        {
            string apiEndPoint = "https://localhost:7144/api/v1/GetAllBranches";
            using (var client = new HttpClient())
            {
                string data = "";
                client.BaseAddress = new Uri(apiEndPoint);
                HttpResponseMessage result = client.GetAsync(data).Result;

                if (result.IsSuccessStatusCode)
                {
                    data = result.Content.ReadAsStringAsync().Result;
                }
                return data;
            }
        }

        public IActionResult SearchBranch()
        {
            return View();
        }

        public string filterByName(string name)
        {
            string apiEndPoint = "https://localhost:7144/api/v1/GetBranchByName/" + name;
            using (var client = new HttpClient())
            {
                string data = "";
                client.BaseAddress = new Uri(apiEndPoint);
                HttpResponseMessage result = client.GetAsync(data).Result;

                if (result.IsSuccessStatusCode)
                {
                    data = result.Content.ReadAsStringAsync().Result;
                }
                return data;
            }
        }

        public string findBranchById(string id)
        {
            string apiEndPoint = "https://localhost:7144/api/v1/GetBranchById/" + id;
            using (var client = new HttpClient())
            {
                string data = "";
                client.BaseAddress = new Uri(apiEndPoint);
                HttpResponseMessage result = client.GetAsync(data).Result;

                if (result.IsSuccessStatusCode)
                {
                    data = result.Content.ReadAsStringAsync().Result;
                }
                return data;
            }
        }

        public IActionResult FindBranchAndBindToModel()
        {
            return View();
        }

        public List<Branch> findBranchByNameAndBindToModel(string name)
        {
            var branches = new List<Branch>();
            string apiEndPoint = "https://localhost:7144/api/v1/GetBranchByName/" + name;
            using (var client = new HttpClient())
            {
                string data = "";
                client.BaseAddress = new Uri(apiEndPoint);
                HttpResponseMessage result = client.GetAsync(data).Result;

                if (result.IsSuccessStatusCode)
                {
                    data = result.Content.ReadAsStringAsync().Result;
                    branches = JsonConvert.DeserializeObject<List<Branch>>(data);
                }
                
            }
            return branches;
        }

        public IActionResult LoadReportFromModel()
        {
            return View();
        }

        public List<Branch> getBranchesListToModel()
        {
            string apiEndPoint = "https://localhost:7144/api/v1/GetAllBranches";
            var branches = new List<Branch>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiEndPoint);
                HttpResponseMessage result = client.GetAsync(client.BaseAddress).Result;
                if (result.IsSuccessStatusCode)
                {
                    var jsonData = result.Content.ReadAsStringAsync().Result;
                    branches = JsonConvert.DeserializeObject<List<Branch>>(jsonData);
                }
            }
            return branches;
        }
    }   
}
