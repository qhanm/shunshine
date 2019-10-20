using AutoMapper;
using shunshine.App.EntityCodeFirst;
using shunshine.App.EntityCodeFirst.Entities;
using shunshine.App.Models.ViewModels;

namespace shunshine.App.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<WholePriceViewModel, WholePrice>().ConstructUsing(c => new WholePrice(c.ProductId, c.FromQuantity, c.ToQuantity, c.Price));
            CreateMap<AdvertistmentViewModel, Advertistment>().ConstructUsing(c => new Advertistment(c.Name, c.Description, c.Image, c.Url, c.PositionId, c.Status, c.DateCreated, c.DateModified, c.SortOrder));
            CreateMap<AdvertistmentPageViewModel, AdvertistmentPage>().ConstructUsing(c => new AdvertistmentPage(c.Name));
            CreateMap<AdvertistmentPositionViewModel, AdvertistmentPosition>().ConstructUsing(c => new AdvertistmentPosition(c.PageId, c.Name));
            CreateMap<AnnouncementViewModel, Announcement>().ConstructUsing(c => new Announcement(c.Title, c.Content, c.UserId, c.Status));
            CreateMap<AnnouncementUserViewModel, AnnouncementUser>().ConstructUsing(c => new AnnouncementUser(c.AnnouncementId, c.UserId, c.HasRead));
            CreateMap<AppRoleViewModel, AppRole>().ConstructUsing(c => new AppRole(c.Name, c.Description));
            CreateMap<AppUserViewModel, AppUser>().ConstructUsing(c => new AppUser(c.FullName, c.UserName, c.Email, c.PhoneNumber, c.Avatar, c.Balance, c.Status));
            CreateMap<BillViewModel, Bill>().ConstructUsing(c => new Bill(c.CustomerName, c.CustomerAddress, c.CustomerMobile, c.CustomerMessage, c.BillStatus, c.PaymentMethod, c.Status, c.CustomerId));
            CreateMap<BillDetailViewModel, BillDetail>().ConstructUsing(c => new BillDetail(c.BillId, c.ProductId, c.Quantity, c.Price, c.ColorId, c.SizeId));
            CreateMap<BlogViewModel, Blog>().ConstructUsing(c => new Blog(c.Name, c.Image, c.Description, c.Content, c.HomeFlag, c.HotFlag, c.Tags, c.Status, c.SeoPageTitle, c.SeoAlias, c.SeoKeywords, c.SeoDescription));
            CreateMap<BlogTagViewModel, BlogTag>().ConstructUsing(c => new BlogTag(c.BlogId, c.TagId));
            CreateMap<ColorViewModel, Color>().ConstructUsing(c => new Color(c.Name, c.Code));
            CreateMap<ContactViewModel, Contact>().ConstructUsing(c => new Contact(c.Name, c.Phone, c.Email, c.Website, c.Address, c.Other, c.Lng, c.Lat, c.Status));
            CreateMap<FeedbackViewModel, Feedback>().ConstructUsing(c => new Feedback(c.Name, c.Email, c.Message, c.Status));
            CreateMap<FooterViewModel, Footer>().ConstructUsing(c => new Footer(c.Content));
            CreateMap<FunctionViewModel, Function>().ConstructUsing(c => new Function(c.Name, c.URL, c.ParentId, c.IconCss, c.SortOrder));
            CreateMap<LanguageViewModel, Language>().ConstructUsing(c => new Language(c.Name, c.IsDefault, c.Resources, c.Status));
            CreateMap<PageViewModel, Page>().ConstructUsing(c => new Page(c.Name, c.Alias, c.Content, c.Status));
            CreateMap<PermissionViewModel, Permission>().ConstructUsing(c => new Permission(c.RoleId, c.FunctionId, c.CanCreate, c.CanRead, c.CanUpdate, c.CanDelete));
            CreateMap<ProductViewModel, Product>().ConstructUsing(c => new Product(c.Name, c.CategoryId, c.Image, c.Price, c.OriginalPrice, c.PromotionPrice, c.Description, c.Content, c.HomeFlag, c.HotFlag, c.Tags, c.Unit, c.Status, c.SeoPageTitle, c.SeoAlias, c.SeoKeywords, c.SeoDescription));
            CreateMap<ProductCategoryViewModel, ProductCategory>().ConstructUsing(c => new ProductCategory(c.Id, c.Name, c.Description, c.ParentId, c.HomeOrder, c.Image, c.HomeFlag, c.SortOrder, c.Status, c.SeoPageTitle, c.SeoAlias, c.SeoKeywords, c.SeoDescription));
            CreateMap<ProductImageViewModel, ProductImage>().ConstructUsing(c => new ProductImage(c.ProductId, c.Path, c.Caption));
            CreateMap<ProductQuantityViewModel, ProductQuantity>().ConstructUsing(c => new ProductQuantity(c.ProductId, c.SizeId, c.ColorId, c.Quantity));
            CreateMap<ProductTagViewModel, ProductTag>().ConstructUsing(c => new ProductTag(c.ProductId, c.TagId));
            CreateMap<SizeViewModel, Size>().ConstructUsing(c => new Size(c.Name));
            CreateMap<SlideViewModel, Slide>().ConstructUsing(c => new Slide(c.Name, c.Description, c.Image, c.Url, c.DisplayOrder, c.Status, c.Content, c.GroupAlias));
            CreateMap<SystemConfigViewModel, SystemConfig>().ConstructUsing(c => new SystemConfig(c.Name, c.Value1, c.Value2, c.Value3, c.Value4, c.Status));
            CreateMap<TagViewModel, Tag>().ConstructUsing(c => new Tag(c.Name, c.Type));
            CreateMap<ImageViewModel, Image>().ConstructUsing(c => new Image(c.Name, c.UserId, c.Caption, c.Description, c.Alt, c.Url, c.Year, c.Month, c.Type, c.Size, c.Extension));
        }
    }
}