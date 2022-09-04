using Acme.BookStore.Books.ViewModels;
using AutoMapper;

namespace Acme.BookStore.Blazor
{
    public class BookStoreBlazorAutoMapperProfile : Profile
    {
        public BookStoreBlazorAutoMapperProfile()
        {
            CreateMap<BookViewModel, CreateOrUpdateBookViewModel>();
        }
    }
}
