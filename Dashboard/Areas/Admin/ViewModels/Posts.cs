using Dashboard.Infrastructure;
using Dashboard.Models;

namespace Dashboard.Areas.Admin.ViewModels
{
    public class PostsIndex
    {
        public PagedData<Post> Posts { get; set; }
    }
}