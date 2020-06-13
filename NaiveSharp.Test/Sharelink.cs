using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;

namespace NaiveSharp.Test
{
    [TestClass]
    public class Sharelink
    {
        [TestMethod]
        public void LoadFromShareLink1()
        {
            var d = "naive+https://what:happened@test.someone.cf?padding=false#Naive!";
            var r = Controller.Sharelink.LoadFromShareLink(d);

            Console.WriteLine("Name =>" + r.Value.Name);
            Console.WriteLine("Scheme =>" + r.Value.Scheme);
            Console.WriteLine("Host =>" + r.Value.Host);
            Console.WriteLine("Username =>" + r.Value.Username);
            Console.WriteLine("Password =>" + r.Value.Password);
            Console.WriteLine("Padding =>" + r.Value.Padding);

            Assert.AreEqual(r.Value.Name, "Naive!");
            Assert.AreEqual(r.Value.Scheme, "https");
            Assert.AreEqual(r.Value.Host, "test.someone.cf");
            Assert.AreEqual(r.Value.Username, "what");
            Assert.AreEqual(r.Value.Password, "happened");
            Assert.AreEqual(r.Value.Padding, false);
        }

        [TestMethod]
        public void LoadFromShareLink2()
        {
            var d = "naive+https://some.public.rs?padding=true#Public-01";
            var r = Controller.Sharelink.LoadFromShareLink(d);
            Console.WriteLine("Name =>" + r.Value.Name);
            Console.WriteLine("Scheme =>" + r.Value.Scheme);
            Console.WriteLine("Host =>" + r.Value.Host);
            Console.WriteLine("Username =>" + r.Value.Username);
            Console.WriteLine("Password =>" + r.Value.Password);
            Console.WriteLine("Padding =>" + r.Value.Padding);

            Assert.AreEqual(r.Value.Name, "Public-01");
            Assert.AreEqual(r.Value.Scheme, "https");
            Assert.AreEqual(r.Value.Host, "some.public.rs");
            Assert.AreEqual(r.Value.Username, "");
            Assert.AreEqual(r.Value.Password, "");
            Assert.AreEqual(r.Value.Padding, false);
        }

        [TestMethod]
        public void LoadFromShareLink3()
        {
            var d = "naive+quic://manhole:114514@quic.test.me";
            var r = Controller.Sharelink.LoadFromShareLink(d);
            Console.WriteLine("Name =>" + r.Value.Name);
            Console.WriteLine("Scheme =>" + r.Value.Scheme);
            Console.WriteLine("Host =>" + r.Value.Host);
            Console.WriteLine("Username =>" + r.Value.Username);
            Console.WriteLine("Password =>" + r.Value.Password);
            Console.WriteLine("Padding =>" + r.Value.Padding);

            Assert.AreEqual(r.Value.Name, "");
            Assert.AreEqual(r.Value.Scheme, "quic");
            Assert.AreEqual(r.Value.Host, "quic.test.me");
            Assert.AreEqual(r.Value.Username, "manhole");
            Assert.AreEqual(r.Value.Password, "114514");
            Assert.AreEqual(r.Value.Padding, false);
        }
    }
}
