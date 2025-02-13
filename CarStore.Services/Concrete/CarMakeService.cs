﻿using CarStore.Services.Abstract;
using CarStore.Web.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore.Services.Concrete
{
    public class CarMakeService : ICarMakeService
    {
        private readonly ApplicationDbContext _context;

        public CarMakeService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task AddCarMakeAsync(CarMake carMake)
        {
            await _context.CarMakes.AddAsync(carMake);
            await _context.SaveChangesAsync();

        }

        public Task<CarMake> GetCarMakeByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CarMake>> GetCarMakesAsync()
        {
            List<CarMake> carMakes = await _context.CarMakes.ToListAsync();
            return carMakes;
        }

        public Task<CarMake> UpdateCarMakeAsync(CarMake carMake)
        {
            throw new NotImplementedException();
        }
    }
}
