using MagicVilla_Web.Models.Dto;

namespace MagicVilla_Web.Services.IServices
{
	public interface IVillaService
	{
		Task<T> GetAllSync<T>();
		Task<T> GetAsync<T>(int id);
		Task<T> CreateAsync<T>(VillaCreateDTO dto);
		Task<T>UpadateAsync<T>(VillaUpdateDTO dto);
		Task<T> DeleteAsync<T>(int id);
	}
}
