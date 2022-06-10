using M120_und_M226B_Projektarbeit_Studer_Huber.Models;
using M120_und_M226B_Projektarbeit_Studer_Huber.ViewModels;
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
using System.Windows.Shapes;

namespace M120_und_M226B_Projektarbeit_Studer_Huber.Views
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class PostDetailWindow : Window
    {
        public PostDetailWindow(Post post)
        {
            this.DataContext = new PostDetailWindowViewModel(post);
            InitializeComponent();
        }
    }
}
