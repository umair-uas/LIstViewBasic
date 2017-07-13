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

namespace ListViewBasics
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {
            string caption = "The description is ";
            MessageBox.Show( this.DescriptionText.Text,caption);
          
            
            //MessageBox.Show("Hi This is MEssage Box Text");

        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            this.WCheckBox.IsChecked = this.BCheckBox.IsChecked = this.NCheckBox.IsChecked = this.LCheckBox.IsChecked
                = this.UCheckBox.IsChecked = TCheckBox.IsChecked = this.ZCheckBox.IsChecked = this.LowCheckBox.IsChecked =
                HartCheckBox.IsChecked = this.NBCheckBox.IsChecked = false;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            this.SelectedProtocolsText.Text += (string)((CheckBox)sender).Content;
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            ((CheckBox)sender).IsChecked=false;
            this.SelectedProtocolsText.Text += (string)((CheckBox)sender).Content;
        }
        
        private void FinishDropDown_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.PText == null)
                return;

            var combo = (ComboBox)sender;
            var value = (ComboBoxItem)combo.SelectedValue;
            this.PText.Text = (string)value.Content;

        }
      
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FinishDropDown_SelectionChanged(this.ProtocolStandardDropdown, null);
            
           
        }

        private void IETFRFCText_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.IRRText.Text = this.IETFRFCText.Text;
        }

        private void TransportLayerDropdown_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.TLText == null)
                return;

            var combo = (ComboBox)sender;
            var value = (ComboBoxItem)combo.SelectedValue;
            this.TLText.Text = (string)value.Content;

        }

        private void IoTDropDown_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            

        }
        
    }
}
