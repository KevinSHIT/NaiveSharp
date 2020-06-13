using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NaiveSharp.Test
{
    [TestClass]
    public class NaiveCmdBuilder
    {
        [TestMethod]
        public void Proxy()
        {
            string scheme   = "https",
                   username = "username",
                   password = "password",
                   host     = "host.com";

            string tartget = "https://username:password@host.com";

            Assert.IsTrue(tartget == Controller.NaiveCmdBuilder.Proxy(scheme, username, password, host));

        }
    }
}
