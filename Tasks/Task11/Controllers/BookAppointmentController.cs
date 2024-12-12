using Microsoft.AspNetCore.Mvc;
using Task11.Data;
using Task11.Models;

namespace Task11.Controllers
{
    public class BookAppointmentController : Controller
    {
        private ApplicationDbContext _context = new();
        public IActionResult Index(int doctorId)
        {
            var doctor = _context.doctors.Find(doctorId);
            return View(doctor);
        }

        public IActionResult SendData(Patient patient)
        {
            _context.patients.Add(new Patient
            {
                Name = patient.Name,
                AppointmentDate = patient.AppointmentDate,
                AppointmentTime = patient.AppointmentTime,
                DoctorID = patient.DoctorID
            });
            _context.SaveChanges();
            return RedirectToAction("BookingList", "Home");
        }
    }
}
