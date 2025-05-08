using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;

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
    }
}
