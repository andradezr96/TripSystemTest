using Models.DTO.Catalogs.Clients;
using Models.DTO.Catalogs.Drivers;
using Models.DTO.Catalogs.Trips;
using Models.DTO.Common;
using Models.Entities.Catalogs.Clients;
using Models.Entities.Catalogs.Drivers;
using Models.Entities.Catalogs.Trips;

namespace TripSystemTest.Mapper
{
    public class EntityMapper : AutoMapper.Profile
    {
        public EntityMapper()
        {

            CreateMap<DTOClient, Client>();
            CreateMap<Client, DTOClient>();


            CreateMap<DTOTrip, Trip>();
            CreateMap<Trip, DTOTrip>()
                .ForMember(dest => dest.TripNumber, opts => opts.MapFrom(src =>  $"TRP-{src.TripId.ToString("00000000")}"))
                .ForMember(dest => dest.DriverName, opts => opts.MapFrom(src => $"{src.Driver.DriverNumber} - {src.Driver.Name} {src.Driver.FirstName} {src.Driver.LastName}"));


            CreateMap<DTODriver, Driver>();
            CreateMap<Driver, DTODriver>();

            CreateMap<DTOOption, Driver>();
            CreateMap<Driver, DTOOption>()
                .ForMember(dest => dest.Text, opts => opts.MapFrom(src => $"{src.DriverNumber} - {src.Name} {src.FirstName} {src.LastName}"))
                .ForMember(dest => dest.Value, opts => opts.MapFrom(src => src.DriverId));


        }
    }
}
