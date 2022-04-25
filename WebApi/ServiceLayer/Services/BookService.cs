using AutoMapper;
using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTOs.Book;
using ServiceLayer.DTOs.Customer;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepositry _bookRepository;
        private readonly IMapper _mapper;
        public BookService(IBookRepositry bookRepository,IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public async Task<List<BookListDTO>> GetAllAsync()
        {
            var model = await _bookRepository.GetAllAsync();

            return _mapper.Map<List<BookListDTO>>(model);
        }

        public async Task CreateAsync(BookListDTO bookList)
        {
           var model = _mapper.Map<Book>(bookList);
           await _bookRepository.CreateAsync(model);
        }

        public async Task EditAsync(int id,BookEditDTO bookEdit) 
        {
            var entity = await _bookRepository.GetAsync(id);

            _mapper.Map(bookEdit, entity);

            await _bookRepository.UpdateAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            await _bookRepository.DeleteAsync(await _bookRepository.GetAsync(id));
        }

        public async Task<IEnumerable<BookSearchDTO>> SearchAllByContions(string search)
        {
            return _mapper.Map<IEnumerable<BookSearchDTO>>(await _bookRepository.FindAllAsync((m=>m.Name.Contains(search))));
        }
    }
}
