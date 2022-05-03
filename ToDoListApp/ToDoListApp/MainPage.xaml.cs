using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ToDoListApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        /* // Earlier Version
        public void HandleTextChanged(object sender, TextChangedEventArgs args)
        {
            Console.WriteLine(args.NewTextValue);
        }

        public void HandleEnterPress(object sender, EventArgs args)
        {
            Console.WriteLine("Enter Pressed");
            Label newTodo = new Label();
            newTodo.Text = InputField.Text;
            newTodo.FontSize = 20;
            TodoList.Children.Add(newTodo);
            InputField.Text = "";  //clears out the text after adding it to a new Label
        }
        */
    }
}
