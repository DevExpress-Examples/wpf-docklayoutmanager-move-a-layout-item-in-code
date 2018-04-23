using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpf.Layout.Core;

namespace DockLayoutManager_MoveItem {
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
        }

        private void buttonMove_Click(object sender, RoutedEventArgs e) {
            #region #1
            dockLayoutManager1.LayoutController.Move(layoutItemEditor1, layoutItemButton1, MoveType.Left);
            #endregion #1
        }

        
    }
}
