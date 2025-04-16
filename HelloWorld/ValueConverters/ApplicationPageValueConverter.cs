using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using HelloWorld.DataModels;
using HelloWorld.Pages;

namespace HelloWorld.ValueConverters
{
    public class ApplicationPageValueConverter 
        : BaseValueConverter<ApplicationPageValueConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (((PageModel)value).Page)
            {
                case ApplicationPage.MyPage:
                    return new MyPage();
                case ApplicationPage.MyPanel:
                    return new MyPanel();
                case ApplicationPage.ParisPage:
                    return new ParisPage();
                case ApplicationPage.ResourceTest:
                    return new ResourceTest();
                case ApplicationPage.ButtonTest:
                    return new ButtonTest();
                case ApplicationPage.LeeTest2:
                    return new LeeTest2();
                case ApplicationPage.ConvertTest:
                    return new ConverterTest();
                case ApplicationPage.KBO:
                    return new KBOListPage();
                case ApplicationPage.ScoreCompletion:
                    return new ScoreCompletion();
                default:
                    return null;

            }
        }


        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

    }
}
