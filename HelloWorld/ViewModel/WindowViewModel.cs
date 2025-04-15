using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using HelloWorld.DataModels;

namespace HelloWorld.ViewModel
{
    public class WindowViewModel : BaseViewModel
    {
        // 프로퍼티
        //public ApplicationPage CurrentPage { get; set; }
        //    = ApplicationPage.ConvertTest;

        public PageModel CurrentPage { get; set; }
        public ObservableCollection<PageModel> Pages { get; set; }

        public WindowViewModel()
        {
            this.Pages = new ObservableCollection<PageModel>();
            this.CurrentPage = new PageModel();

            foreach (ApplicationPage page in Enum.GetValues(typeof(ApplicationPage)))
            {
                this.Pages.Add(new PageModel { Page = page });
            }
        }
    }
}
