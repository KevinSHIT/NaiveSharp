using System;
using System.Collections.Generic;
using NaiveSharp.Controller.Extension;

namespace NaiveSharp.Controller
{
    public class Nshelper
    {
        public static NsInfo? LoadFromNs(string ns)
        {
            // NS -> Base64([GroupName]) Base64([NodeName]) Base64([NodeUri]) [Padding<bool>]
            var vv = ns.Split(' ');
            var nsInfo = new NsInfo();
            switch (vv.Length)
            {
                case 2:
                    nsInfo.Uri = vv[0].FromBase64();
                    nsInfo.Padding = bool.Parse(vv[1]);
                    break;
                case 3:
                    nsInfo.Name = vv[0].FromBase64();
                    nsInfo.Uri = vv[1].FromBase64();
                    nsInfo.Padding = bool.Parse(vv[2]);
                    break;
                case 4:
                    nsInfo.GroupName = vv[0].FromBase64();
                    nsInfo.Name = vv[1].FromBase64();
                    nsInfo.Uri = vv[2].FromBase64();
                    nsInfo.Padding = bool.Parse(vv[3]);
                    break;
                default:
                    return null;
            }

            return nsInfo;
        }

       
    }
}