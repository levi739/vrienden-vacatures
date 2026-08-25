using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Diagnostics;

namespace firstProject.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
private void buttonOnClick(object? sender, RoutedEventArgs e)
    {   
        Debug.WriteLine("Naam solicitant:");
        Debug.WriteLine($"{Naam.Text}");

        Debug.WriteLine("Leeftijd:");
        Debug.WriteLine($"{Leeftijd.Text}");

        Debug.WriteLine("Interesses:");
        Debug.WriteLine($"{Interesses.Text}");

        Debug.WriteLine("Arbeidsstatus: purrr");
        Debug.WriteLine($"{Arbeidsstatus.Text}");
    }
}

