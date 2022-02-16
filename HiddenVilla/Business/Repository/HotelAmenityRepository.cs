using AutoMapper;
using Business.Repository.IRepository;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository
{
    public class HotelAmenityRepository : IHotelAmenityRepository
    {
        private readonly AppDbContext _db;
        private readonly IMapper _mapper;

        public HotelAmenityRepository(AppDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<HotelAmenityDTO> CreateHotelAmenity(HotelAmenityDTO hotelAmenityDTO)
        {
            HotelAmenity hotelAmenity = _mapper.Map<HotelAmenityDTO, HotelAmenity>(hotelAmenityDTO);
            var addedHoteAmenity = await _db.HotelAmenities.AddAsync(hotelAmenity);

            await _db.SaveChangesAsync();
            return _mapper.Map<HotelAmenity, HotelAmenityDTO>(addedHoteAmenity.Entity);
        }

        public async Task<int> DeleteHotelAmenity(int amenityId)
        {
            var amenityDetails = await _db.HotelAmenities.FindAsync(amenityId);
            if (amenityDetails != null)
            {
                _db.HotelAmenities.Remove(amenityDetails);
                return await _db.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<IEnumerable<HotelAmenityDTO>> GetAllHotelAmenity()
        {
            try
            {
                IEnumerable<HotelAmenityDTO> hotelAmenityDTO =
                    _mapper.Map<IEnumerable<HotelAmenity>, IEnumerable<HotelAmenityDTO>>(_db.HotelAmenities);

                return hotelAmenityDTO;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public async Task<HotelAmenityDTO> GetHotelAmenity(int amenityId)
        {
            try
            {
                HotelAmenityDTO hotelAmenity = _mapper.Map<HotelAmenity, HotelAmenityDTO>(
                    await _db.HotelAmenities.FirstOrDefaultAsync(x => x.Id == amenityId));

                return hotelAmenity;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public async Task<HotelAmenityDTO> UpdateHotelAmenity(int amenityId, HotelAmenityDTO hotelAmenityDTO)
        {
            try
            {
                if (amenityId == hotelAmenityDTO.Id)
                {
                    //valid
                    HotelAmenity amenityDetails = await _db.HotelAmenities.FindAsync(amenityId);
                    HotelAmenity amenity = _mapper.Map<HotelAmenityDTO, HotelAmenity>(hotelAmenityDTO, amenityDetails);
                    var updateAmenity = _db.HotelAmenities.Update(amenity);

                    await _db.SaveChangesAsync();
                    return _mapper.Map<HotelAmenity, HotelAmenityDTO>(updateAmenity.Entity);
                }
                else
                {
                    //invalid
                    return null;
                }
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}
