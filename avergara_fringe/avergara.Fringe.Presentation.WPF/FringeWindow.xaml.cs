using avergara.Fringe.Presentation.WPF.ViewModel;
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

namespace avergara.Fringe.Presentation.WPF
{

  
    /// <summary>
    /// Interaction logic for FringeWindow.xaml
    /// </summary>
    public partial class FringeWindow : Window
    {

        public FringeViewModel fringeViewModel { get; set; }

        /// <summary>
        /// contructor 
        /// </summary>
        public FringeWindow()
        {
            fringeViewModel = new FringeViewModel();
            InitializeComponent();
            DataContext = fringeViewModel;

        }

       
    }
}
