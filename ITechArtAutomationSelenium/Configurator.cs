using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITechArtAutomationSelenium
{
    public class Configurator
    {
        private const string BaseUrlProperty = "baseUrl";
        public static readonly string BaseUrl = TestContext.Parameters[BaseUrlProperty];
    }
}
