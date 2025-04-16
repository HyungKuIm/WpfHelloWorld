using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.ViewModel
{
    public class KBOViewModel : BaseViewModel
    {
        // 선수목록
        public List<PlayerViewModel> Players { get; set; }

        // 생성자
        public KBOViewModel()
        {
            //선수 10명 생성
            Players = new List<PlayerViewModel>();
            Players.Add(new PlayerViewModel
            {
                Name = "이정후",
                Story = "이정후 소개",
                Email = "jhlee@nexen.com",
                ImagePath = "/Images/LeeJungHoo.png"
            });
            Players.Add(new PlayerViewModel
            {
                Name = "레이예스",
                Story = "레이예스는 지난 15일 부산 사직구장에서 열린 2025 KBO리그 정규시즌 키움 히어로즈와의 홈 주중 3연전 3차전에 3번·지명타자로 선발 출전, 5타수 3안타를 기록했다. ",
                Email = "reyes@lotte.com",
                ImagePath = "/Images/Reyes.png"
            });
            Players.Add(new PlayerViewModel
            {
                Name = "장두성",
                Story = "장두성 소개",
                Email = "chang@lotte.com",
                ImagePath = "/Images/Chang.png"
            });
            Players.Add(new PlayerViewModel
            {
                Name = "전준우",
                Story = "별명: 많음(전트란...)",
                Email = "chunjw@lotte.com",
                ImagePath = "/Images/Chunjw.png"
            });
            Players.Add(new PlayerViewModel
            {
                Name = "황성빈",
                Story = "황보르기니",
                Email = "whang@lotte.com",
                ImagePath = "/Images/Whang.png"
            });
            Players.Add(new PlayerViewModel
            {
                Name = "유강남",
                Story = "유강남 소개",
                Email = "you@lotte.com",
                ImagePath = "/Images/You.png"
            });
            Players.Add(new PlayerViewModel
            {
                Name = "정보근",
                Story = "정보근 소개",
                Email = "chungbk@lotte.com",
                ImagePath = "/Images/Chungbk.png"
            });
            Players.Add(new PlayerViewModel
            {
                Name = "고승민",
                Story = "고승민 소개",
                Email = "ko@lotte.com",
                ImagePath = "/Images/Ko.png"
            });
            Players.Add(new PlayerViewModel
            {
                Name = "나승엽",
                Story = "나승엽 소개",
                Email = "na@lotte.com",
                ImagePath = "/Images/Na.png"
            });
            Players.Add(new PlayerViewModel
            {
                Name = "손호영",
                Story = "손호영 소개",
                Email = "son@lotte.com",
                ImagePath = "/Images/Son.png"
            });
            //...
        }
    }
}
