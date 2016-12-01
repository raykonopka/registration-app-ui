using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RegistrationWeb.Tests
{
    public class WebTests
    {

        [Fact]
        public void Test_LoadIndexPage()
        {
            HttpClient httpClient = new HttpClient();

            var actual = httpClient.GetAsync("http://34.193.163.157/registration-app-ui/").Result;

            if (actual.IsSuccessStatusCode)
            {
                Debug.WriteLine("Index Page Sucessfully Loaded.");
            }
            else
            {
                Debug.WriteLine("Index Page Failed To Load.");
            }

            Assert.True(actual.IsSuccessStatusCode);
        }

    }
}
