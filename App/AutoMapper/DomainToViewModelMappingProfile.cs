using AutoMapper;
using shunshine.App.EntityCodeFirst;
using shunshine.App.EntityCodeFirst.Entities;
using shunshine.App.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shunshine.App.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<WholePrice, WholePriceViewModel>();
            CreateMap<Advertistment, AdvertistmentViewModel>();
            CreateMap<AdvertistmentPage, AdvertistmentPageViewModel>();
            CreateMap<AdvertistmentPosition, AdvertistmentPositionViewModel>();
            CreateMap<Announcement, AnnouncementViewModel>();
            CreateMap<AnnouncementUser, AnnouncementUserViewModel>();
            CreateMap<AppRole, AppRoleViewModel>();
            CreateMap<AppUser, AppUserViewModel>();
            CreateMap<Bill, BillViewModel>();
            CreateMap<BillDetail, BillDetailViewModel>();
            CreateMap<Blog, BlogViewModel>();
            CreateMap<BlogTag, BlogTagViewModel>();
            CreateMap<Color, ColorViewModel>();
            CreateMap<Contact, ContactViewModel>();
            CreateMap<Feedback, FeedbackViewModel>();
            CreateMap<Footer, FooterViewModel>();
            CreateMap<Function, FunctionViewModel>();
            CreateMap<Language, LanguageViewModel>();
            CreateMap<Page, PageViewModel>();
            CreateMap<Permission, PermissionViewModel>();
            CreateMap<Product, ProductViewModel>();
            CreateMap<ProductCategory, ProductCategoryViewModel>();
            CreateMap<ProductImage, ProductImageViewModel>();
            CreateMap<ProductQuantity, ProductQuantityViewModel>();
            CreateMap<ProductTag, ProductTagViewModel>();
            CreateMap<Size, SizeViewModel>();
            CreateMap<Slide, SlideViewModel>();
            CreateMap<SystemConfig, SystemConfigViewModel>();
            CreateMap<Tag, TagViewModel>();
            CreateMap<Image, ImageViewModel>();
        }
    }
}
