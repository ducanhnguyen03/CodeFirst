using CodeFirst.A_DAL.Models;
using CodeFirst.A_DAL.Responsitories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.B_BUS.Services
{
    internal class VehicleServices
    {
        VehicleRes vhr = new VehicleRes();
        public string CreateVehicle(string vcp, string type, string name, string owneridcard, string parkingmethod, string parkname)
        {
            if (vhr.CreateVehicle(vcp,type,name,owneridcard,parkingmethod,parkname))
            {
                return "Thêm mới thành công";
            }
            return "Thêm mới thất bại";
        }
        public List<Vehicle> GetAllVehicle(string parkname)
        {
          return vhr.ShowAllCar(parkname);
        }
    }
}

