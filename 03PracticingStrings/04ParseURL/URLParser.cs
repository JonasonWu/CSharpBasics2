using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment2;

namespace Assignment3
{
    class URLComponents {
        public string Protocol { get; set; }
        public string Server { get; set; }
        public string Resource { get; set; }

    }
    class URLParser
    {
        public URLComponents ConstructURLComponents(string url)
        {
            string[] split1 = url.Split("://", 2);
            string[] split2 = split1.Length == 2 ? split1[1].Split("/", 2) : split1[0].Split("/", 2);
            URLComponents uRLComponents = new();
            uRLComponents.Protocol = split1.Length == 2 ? split1[0] : "";
            uRLComponents.Server = split2[0];
            uRLComponents.Resource = split2.Length == 2 ? split2[1] : "";
            return uRLComponents;
        
        }

        public void PerformOperation(string url)
        {
            Console.WriteLine(url);
            URLComponents components = ConstructURLComponents(url);
            Console.WriteLine($"[protocol] = \"{components.Protocol}\"");
            Console.WriteLine($"[server] = \"{components.Server}\"");
            Console.WriteLine($"[resource] = \"{components.Resource}\"");

        }
    }
}
