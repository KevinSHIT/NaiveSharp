using System.Net;
using System.Net.NetworkInformation;

namespace NaiveSharp.Controller
{
    class Net
    {
        public static bool IsPortUsed(int port)
        {
            IPGlobalProperties ipProperties = IPGlobalProperties.GetIPGlobalProperties();
            IPEndPoint[] ipEndPoints = ipProperties.GetActiveTcpListeners();
            foreach (IPEndPoint endPoint in ipEndPoints)
            {
                if (endPoint.Port == port)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
