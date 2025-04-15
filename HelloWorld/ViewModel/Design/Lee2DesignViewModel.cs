using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.ViewModel
{
    public class Lee2DesignViewModel : Lee2ViewModel
    {
        // 싱글톤
        public static Lee2DesignViewModel Instance 
            => new Lee2DesignViewModel();

        //생성자
        public Lee2DesignViewModel()
        {
            Name = "이승엽";
            Story = "이승엽(李承燁, 1976년 8월 18일 ~ )은 대한민국의 전 야구 선수이자 현 야구 감독이다. 포지션은 1루수이며, 현재 KBO 리그 두산 베어스의 감독으로 재직 중이다.";
            Email = "seungjjang@lions.com";
            ImagePath = "https://search.pstatic.net/common/?src=http%3A%2F%2Fblogfiles.naver.net%2FMjAyNDAzMDhfMTM0%2FMDAxNzA5OTA2NjQ0NjI0.Eq36TPfAeY0kvze2UoXgdmXNEhSthVbpUoXV60t5ncQg.hFGc7CkssBZxqpI1ejFs5qkQErscykhWVMBUjtpbtuIg.JPEG%2Fkp1_2031002t1181.jpg&type=sc960_832";
        }
    }
}
