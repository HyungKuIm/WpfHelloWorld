using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using HelloWorld.ViewModel;

namespace HelloWorld.Pages
{
    public class BasePage<VM> : Page
        where VM : BaseViewModel, new()
    {
        private VM mViewModel = null;

        public VM ViewModel
        {
            get { return mViewModel; }
            set
            {
                // 뷰모델의 변경이 없으면 리턴
                if (mViewModel == value)
                    return;
                mViewModel = value;

                // 뷰모델이 변경되면 데이터 컨텍스트를 변경
                this.DataContext = mViewModel;
            }
        }

        public BasePage()
        {
            // 뷰모델을 생성
            ViewModel = new VM();
        }
    }
}
