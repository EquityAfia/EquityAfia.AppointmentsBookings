﻿
using System.Collections.Generic;
using System.Threading.Tasks;
using EquityAfia.AppointmentsBookings.Domain.Entities;

namespace EquityAfia.AppointmentsBookings.Domain.Interfaces
{
    public interface IAppointmentRepository
    {
        Task AddAsync(AppointmentBooking appointmentBooking);
        Task<IEnumerable<AppointmentBooking>> GetAllAppointments();
        Task<AppointmentBooking> GetAppointmentById(string id);
    }
}


