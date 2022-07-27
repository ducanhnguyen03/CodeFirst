using CodeFirst.A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.A_DAL.Responsitories
{
    internal class ParkingRes
    {
        ParkingManageContext context = new ParkingManageContext();
        public List<Parking> GetAllPark()
        {
            return context.Parkings.ToList();
        }
        public bool AddParking(string name, string location, double area, int capacity, string owner, DateTime establish, List<Vehicle> vehicles)
        {
            try
            {
                Parking pk = new Parking();
                pk.Name = name;
                pk.Location = location;
                pk.Area = area;
                pk.Capacity = capacity;
                pk.Owner = owner;
                pk.Establish = establish;
                pk.Vehicles = vehicles;
                context.Add(pk);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool DeleteParking(string name)
        {
            try
            {
                var vehicles = context.vehicles.Where(c => c.ParkingName == name).ToList();
                var parkings = context.Parkings.Where(c => c.Name == name).ToList();
                context.RemoveRange(vehicles);
                context.RemoveRange(parkings);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
