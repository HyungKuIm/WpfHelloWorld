using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.ViewModel
{
    public class ParisPageViewModel : BaseViewModel
    {
        // 프로퍼티
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }

        // 생성자
        public ParisPageViewModel()
        {
            Title = "파리2";
            Description = "패션과 미식, 예술과 낭만이 있는 세계 문화의 중심지";
            ImagePath = "/Images/paris2.png";
        }

    }
}
