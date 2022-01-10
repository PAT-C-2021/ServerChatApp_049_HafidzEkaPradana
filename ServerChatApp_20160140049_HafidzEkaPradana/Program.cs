using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCFService_2Way_20160140049;

namespace ServerChatApp_20160140049_HafidzEkaPradana
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost hostObjek = null;
            try
            {
                hostObjek = new ServiceHost(typeof(ServiceCallback));
                hostObjek.Open();

                Console.WriteLine("Server Open, Siap Dipakai !!!");
                Console.ReadLine();

                hostObjek.Close();
            }
            catch(Exception ex)
            {
                hostObjek = null;
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
