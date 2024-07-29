﻿using eCom.Services.CouponAPI.Models.DTO;
using eCom.Web.Models;

namespace eCom.Web.Service.IService
{
	public interface ICartService
	{
		Task<ResponseDTO?> GetCartByUserIdAsync(string userId);	
		Task<ResponseDTO?> UpsertCartAsync(CartDTO cartDTO);	
		Task<ResponseDTO?> RemoveFromCartAsync(int cartDetailsId);	
		Task<ResponseDTO?> ApplyCouponAsync(CartDTO cartDTO)	;	

	}
}