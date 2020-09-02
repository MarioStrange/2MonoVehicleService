using Project.Service;
using Project.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TestCRUDApp
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleService service = new VehicleService();
            //VehicleModel noviModel = new VehicleModel();
            //noviModel.Name = "Fićo";
            //noviModel.VehicleMakeId = 1;
            //noviModel.Abrv = "FI";
            //testVehicleModel.Insert(noviModel);

            List<VehicleModel> vModels = service.GetAllModels().Result.ToList();

            foreach (VehicleModel item in vModels)
            {
                Console.WriteLine(item.Name + "\t" + item.Abrv);
            }


            Console.ReadKey();
            Console.WriteLine("Hello World!");
        }
    }
}
