using Windows.UI.Xaml.Controls;

// https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x804 上介绍了“空白页”项模板

namespace ShadowTest
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void TestButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            var btn = (Button)sender;
            if ((string)btn.Content == "Add Button")
            {
                btn.Content = "Remove Button";

                var btn2 = new Button()
                {
                    Height = 80,
                    Content = "Second Button",
                    CornerRadius = new Windows.UI.Xaml.CornerRadius(2),
                    HorizontalAlignment = Windows.UI.Xaml.HorizontalAlignment.Center,
                    VerticalAlignment = Windows.UI.Xaml.VerticalAlignment.Center,
                    Margin = new Windows.UI.Xaml.Thickness(0,60,0,0)
                };

                ShadowHelper.SetIsEnabled(btn2, true);

                ((Panel)((Panel)Content).Children[0]).Children.Add(btn2);
            }
            else
            {
                btn.Content = "Add Button";
                ((Panel)((Panel)Content).Children[0]).Children.RemoveAt(1);
            }
        }
    }
}
