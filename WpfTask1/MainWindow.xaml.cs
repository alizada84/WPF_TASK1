using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace WpfTask1;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    void btnRight_Click(object sender, MouseButtonEventArgs e)
    {
        Button btn = (Button)sender;
        btn.Visibility = Visibility.Collapsed;
    }

    void btn_Click(object sender, RoutedEventArgs e)
    {
        Button btn = (Button)sender;

        int r = Random.Shared.Next(0, 255);
        int g = Random.Shared.Next(0, 255);
        int b = Random.Shared.Next(0, 255);

        btn.Background = new SolidColorBrush(Color.FromRgb((byte)r, (byte)g, (byte)b));

        MessageBox.Show(btn.Name, "Button Information", MessageBoxButton.OK, MessageBoxImage.Information);
    }
}
