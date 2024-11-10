using CollegeSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeSystem.Repositories
{
    public class HostelsRepository
    {
        private readonly CollegeDbContext _context;

        public HostelsRepository(CollegeDbContext context)
        {
            _context = context;
        }

        public List<Hostels> GetAllHostels()
        {
            return _context.Hostels.Include(s => s.Students).ToList();
        }

        public Hostels GetHostelById(int HID)
        {
            return _context.Hostels.Find(HID);
        }

        public void AddHostel(Hostels hostel)
        {
            _context.Hostels.Add(hostel);
            _context.SaveChanges();
        }


        public void UpdateHostel(Hostels hostel)
        {
            _context.Hostels.Update(hostel);
            _context.SaveChanges();
        }

        public void DeleteHostel(int HID)
        {
            var hostel = GetHostelById(HID);
            if (hostel != null)
            {
                _context.Hostels.Remove(hostel);
                _context.SaveChanges();
            }
        }

        public Hostels GetHostelsByCity(string City)
        {
            return _context.Hostels.Include(s => s.Students).FirstOrDefault(c => c.City == City);
        }

        public Hostels CountHostelsWithAvailableSeats(int HID)
        {
            return _context.Hostels.Count(No_Of_Seats);
        }
    }
}
