using CodeFirst.A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.A_DAL.Responsitories
{
    internal class VehicleRes
    {
        ParkingManageContext context = new ParkingManageContext();
        public bool CreateVehicle(string vcp,string type,string name,string owneridcard,string parkingmethod,string parkname)
        {
            try
            {

                Vehicle vehicle = new Vehicle();
                vehicle.VCP = vcp;
                vehicle.Type = type;
                vehicle.Name = name;
                vehicle.OwnerIdCard = owneridcard;
                vehicle.ParkingMethod = parkingmethod;
                vehicle.ParkingName = parkname;
                context.Add(vehicle);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool DeleteVehicle(string vcp)
        {
            try
            {
                Vehicle vehicle = context.vehicles.FirstOrDefault(x => x.VCP == vcp);
                context.Remove(vehicle);
                context.SaveChanges();
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }
        public List<Vehicle> ShowAllCar(string namePark)
        {
            var vehicles = context.vehicles.Where(c => c.ParkingName == namePark).ToList();
            return vehicles;
        }
    }
}

