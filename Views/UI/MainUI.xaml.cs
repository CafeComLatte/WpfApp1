using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Views.UI
{
    /// <summary>
    /// MainUI.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainUI : UserControl
    {
        DoubleAnimation dba1;
        public MainUI()
        {
            InitializeComponent();

            /*
            // 애니메이션 설정
            dba1 = new DoubleAnimation();  // 애니메이션 생성
            dba1.From = 0;   // start 값
            dba1.To = 360;   // end 값
            dba1.Duration = new Duration(TimeSpan.FromSeconds(1));  // 1.5초 동안 실행
            dba1.RepeatBehavior = RepeatBehavior.Forever;  // 무한 반복

            RotateTransform rt = new RotateTransform();
            imgLoading.RenderTransform = rt;
            rt.CenterX += imgLoading.Width / 2;
            rt.CenterY += imgLoading.Height / 2;

            rt.BeginAnimation(RotateTransform.AngleProperty, dba1);
            */
            this.xLoading.IsVisibleChanged += XLoading_IsVisibleChanged;
        }

        private void XLoading_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if((bool)e.NewValue != true)
            {
                this.xStoryboard.Stop();
            }
            else
            {
                this.xStoryboard.Begin();
            }



        }
    }
}
