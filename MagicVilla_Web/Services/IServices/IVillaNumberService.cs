using MagicVilla_Web.Models.Dto;

namespace MagicVilla_Web.Services.IServices
{
	public interface IVillaNumberService
	{
		Task<T> GetAllSync<T>();
		Task<T> GetAsync<T>(int id);
		Task<T> CreateAsync<T>(VillaNumberCreateDTO dto);
		Task<T> UpdateAsync<T>(VillaNumberUpdateDTO dto);
		Task<T> DeleteAsync<T>(int id);
	}
}
