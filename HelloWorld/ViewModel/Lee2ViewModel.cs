using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.ViewModel
{
    public class Lee2ViewModel : BaseViewModel
    {
        // 프로퍼티
        public string Name { get; set; }
        public string Story { get; set; }
        public string Email { get; set; }
        public string ImagePath { get; set; }

        // 생성자(ctor)
        public Lee2ViewModel()
        {
            Name = "이정후";
            Story = "이정후(李政厚, 1998년 8월 20일~)는 대한민국의 야구 선수로 현재 메이저 리그 베이스볼의 샌프란시스코 자이언츠에서 외야수로 활동하고 있다. 야구 선수인 이종범의 아들이며 이로 인해 이종범의 별명인 \"바람의 아들\"에서 유래한 \"바람의 손자\"라는 별명으로 잘 알려져 있다.";
            Email = "jhlee@sfgiants.com";
            ImagePath = "https://img-s-msn-com.akamaized.net/tenant/amp/entityid/AA1CMhGZ.img?w=768&h=512&m=6";
        }
    }
}
