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

namespace W25W6WpfControls;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void btnGetCities_Click(object sender, RoutedEventArgs e)
    {
        string cities = "";

        if (chkToronto.IsChecked == true)
            cities += "Toronto\n";
        if (chkParis.IsChecked == true)
            cities += chkParis.Content + "\n";
        if (chkTokyo.IsChecked == true)
            cities += chkTokyo.Content + "\n";
        if (chkSydney.IsChecked == true)
            cities += chkSydney.Content + "\n";

        lblOutput.Content = cities;
    }

    private void btnGetGender_Click(object sender, RoutedEventArgs e)
    {
        string gender = "No gender selected";

        if (rdoFemale.IsChecked == true)
            gender = rdoFemale.Content.ToString();
        else if (rdoMale.IsChecked == true)
            gender = rdoMale.Content.ToString();
        else if (rdoOther.IsChecked == true)
            gender = rdoOther.Content.ToString();

        lblOutput.Content = "Gender = " + gender;
    }
}