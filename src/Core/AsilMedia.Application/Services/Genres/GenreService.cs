﻿using AsilMedia.Application.Abstractions.Repositories;
using AsilMedia.Application.DataTransferObjects;
using AsilMedia.Domain.Entities;
using Mapster;

namespace AsilMedia.Application.Services.Genres
{
    public class GenreService : IGenreService
    {
        private readonly IGenreRepository _genreRepository;

        public GenreService(IGenreRepository genreRepository)
            => _genreRepository = genreRepository;

        public async Task<Genre> InsertAsync(GenreDTO genreDTO)
        {
            var genre = genreDTO.Adapt<Genre>();

            genre = await _genreRepository.InsertAsync(genre);

            return genre;
        }

        public async Task<List<Genre>> SelectAllAsync()
            => await _genreRepository.SelectAllAsync();

        public async Task<Genre> SelectByIdAsync(long id)
            => await _genreRepository.SelectByIdAsync(id);

        public async Task<Genre> UpdateAsync(GenreDTO genreDTO, long id)
        {
            var genre = genreDTO.Adapt<Genre>();

            var gerne = await _genreRepository.UpdateAsync(genre, id);

            return genre;
        }

        public async Task<Genre> DeleteAsync(long id)
        {
            var genre = await _genreRepository.DeleteAsync(id);

            return genre;
        }
    }
}
