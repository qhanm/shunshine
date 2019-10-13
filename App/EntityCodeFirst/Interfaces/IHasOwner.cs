namespace qhnam.Data.Entity.Interfaces
{
    public interface IHasOwner<T>
    {
        T OwnerId { set; get; }
    }
}