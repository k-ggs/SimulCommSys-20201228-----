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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static SimulCommSys.globalvariabel;

namespace SimulCommSys
{
    /// <summary>
    /// Body1_main.xaml 的交互逻辑
    /// </summary>
    public partial class Body1_main : Page
    {
        public Body1_main()
        {
            InitializeComponent();

       

        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //  globalvariabel.aforge_Usbcamera.StartCamera();



            #region 偏振相机初始化
            //    ArenaManager Arena;

            this.img1_litterlgt.DataContext = globalvariabel.camera_Litter;
            globalvariabel.camera_Litter.StartStream();


            #endregion


        }


        #region 界面放大缩小

        private void Button_bing_Click(object sender, RoutedEventArgs e)
        {
            var colum = 1;
            var row = 1;

            var max_colum = this.Grid_.ColumnDefinitions.Count();
            var max_row = this.Grid_.RowDefinitions.Count();

            if (Grid.GetColumnSpan(this.border_bing) < max_colum)
            {
                Grid.SetRow(this.border_bing, 0);
                Grid.SetColumn(this.border_bing, 0);
                Grid.SetRowSpan(this.border_bing, max_row);
                Grid.SetColumnSpan(this.border_bing, max_colum);
                Panel.SetZIndex(this.border_bing, 2);
            }
            else
            {
                Grid.SetRow(this.border_bing, row);
                Grid.SetColumn(this.border_bing, colum);
                Grid.SetRowSpan(this.border_bing, 1);
                Grid.SetColumnSpan(this.border_bing, 1);
                Panel.SetZIndex(this.border_bing, 1);

            }
        }

        private void Button_litter_Click(object sender, RoutedEventArgs e)
        {
            var colum =0;
            var row = 0;

            var max_colum = this.Grid_.ColumnDefinitions.Count();
            var max_row = this.Grid_.RowDefinitions.Count();
     


            if (Grid.GetColumnSpan(this.border_litter) < max_colum)
            {
                Grid.SetRow(this.border_litter, 0);
                Grid.SetColumn(this.border_litter, 0);
                Grid.SetRowSpan(this.border_litter, max_row);
                Grid.SetColumnSpan(this.border_litter, max_colum);
                Panel.SetZIndex(this.border_litter, 2);
            }
            else
            {
                Grid.SetRow(this.border_litter, row);
                Grid.SetColumn(this.border_litter, colum);
                Grid.SetRowSpan(this.border_litter, 1);
                Grid.SetColumnSpan(this.border_litter, 1);
             
                Panel.SetZIndex(this.border_litter, 1);

                
            }
        }

        private void Button_normal_Click(object sender, RoutedEventArgs e)
        {
            var colum = 1;
            var row = 0;
            var max_colum = this.Grid_.ColumnDefinitions.Count();
            var max_row = this.Grid_.RowDefinitions.Count();

          
            if (Grid.GetColumnSpan(this.border_normal) < max_colum)
            {
                Grid.SetRow(this.border_normal, 0);
                Grid.SetColumn(this.border_normal, 0);
                Grid.SetRowSpan(this.border_normal, max_row);
                Grid.SetColumnSpan(this.border_normal, max_colum);
                Panel.SetZIndex(this.border_normal, 2);
            }
            else
            {

                Grid.SetRow(this.border_normal, row);
                Grid.SetColumn(this.border_normal, colum);
                Grid.SetRowSpan(this.border_normal, 1);
                Grid.SetColumnSpan(this.border_normal, 1);
                Panel.SetZIndex(this.border_normal, 1);
              
            }
        }

        private void Button_red_Click(object sender, RoutedEventArgs e)
        {
            var colum = 0;
            var row = 1;
            var max_colum = this.Grid_.ColumnDefinitions.Count();
            var max_row = this.Grid_.RowDefinitions.Count();

         
            if (Grid.GetColumnSpan(this.border_red) < max_colum)
            {
                Grid.SetRow(this.border_red, 0);
                Grid.SetColumn(this.border_red, 0);
                Grid.SetRowSpan(this.border_red, max_row);
                Grid.SetColumnSpan(this.border_red, max_colum);
                Panel.SetZIndex(this.border_red,2);
            }
            else
            {
                Grid.SetRow(this.border_red, row);
                Grid.SetColumn(this.border_red, colum);
                Grid.SetRowSpan(this.border_red, 1);
                Grid.SetColumnSpan(this.border_red, 1);
                Panel.SetZIndex(this.border_red, 1);

            }
        }
        #endregion

     
    }
}
