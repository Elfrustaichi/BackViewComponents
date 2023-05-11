using Microsoft.AspNetCore.Mvc;
using PustokBackTask.DAL;

namespace PustokBackTask.ViewComponents
{
    public class NavGenresViewComponent
    {
        
            private readonly DataContext _context;

            public NavGenresViewComponent(DataContext context)
            {
                _context = context;
            }
            public IViewComponentResult Invoke()
            {
                var data = _context.Genres.ToList();

                return View(data);
            }
        
    }
}
