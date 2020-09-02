using Project.Service.Interfaces;
using Project.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Service
{
    public class VehicleService
    {
        private IRepository<VehicleMake> _vhMakeRepo = null;
        private IRepository<VehicleModel> _vhModelRepo = null;

        public VehicleService()
        {
            this._vhMakeRepo = new Repository<VehicleMake>();
            this._vhModelRepo = new Repository<VehicleModel>();
        }

        public async Task<IEnumerable<VehicleMake>> GetAllMakes()
        {
            return await _vhMakeRepo.GetAll();
        }
        public async Task<IEnumerable<VehicleModel>> GetAllModels()
        {
            return await _vhModelRepo.GetAll();
        }

        public async Task<VehicleMake> GetMakeById(int id)
        {
            return await _vhMakeRepo.GetById(id);
        }

        public async Task<VehicleModel> GetModelById(int id)
        {
            return await _vhModelRepo.GetById(id);
        }

        public async Task InsertMake(VehicleMake vehicleMake)
        {
            _vhMakeRepo.Insert(vehicleMake);
            await _vhMakeRepo.Save();
        }
        public async Task InsertModel(VehicleModel vehicleModel)
        {
            _vhModelRepo.Insert(vehicleModel);
            await _vhModelRepo.Save();
        }
        public async Task UpdateMake(VehicleMake vehicleMake)
        {
            _vhMakeRepo.Update(vehicleMake);
            await _vhMakeRepo.Save();
        }
        public async Task UpdateModel(VehicleModel vehicleModel)
        {
            _vhModelRepo.Update(vehicleModel);
            await _vhModelRepo.Save();
        }
        public async Task DeleteMake(VehicleMake vehicleMake)
        {
            _vhMakeRepo.Delete(vehicleMake);
            await _vhMakeRepo.Save();
        }
        public async Task DeleteModel(VehicleModel vehicleModel)
        {
            _vhModelRepo.Delete(vehicleModel);
            await _vhModelRepo.Save();
        }
    }
}
