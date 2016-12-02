using RegistrationWeb.Client;
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
        public void Test_GetEnrolledStudents()
        {
            DataService data = new DataService();

            var actual = data.GetStudentUsers();

            Assert.NotNull(actual);
        }

    }
}
