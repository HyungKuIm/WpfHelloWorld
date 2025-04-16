using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.ViewModel
{
    // 운동선수 뷰모델
    public class PlayerViewModel : BaseViewModel
    {
        // 프로퍼티
        public string Name { get; set; }
        public string Story { get; set; }
        public string Email { get; set; }
        public string ImagePath { get; set; }

        // 선택 여부(선택하면 true, 아니면 false)
        //public bool IsSelected { get; set; }
        private bool mIsSelected;
        public bool IsSelected
        {
            get { return mIsSelected; }
            set
            {
                if (mIsSelected != value)
                {
                    mIsSelected = value;
                    NotifyPropertyChanged();
                }
            }
        }
    }
}
