﻿using LaCaguamaBackend.Application.Dtos;

namespace LaCaguamaBackend.Domain.Interface
{
    public interface IExtraRepository
    {
        Task<List<ExtrasDto>> GetAllExtras();
        Task<List<ExtrasDto>> GetAllEctraWithName(string nombre);
        Task<ExtrasDto> InsertExtra(string nombre,decimal precio);
    }
}
