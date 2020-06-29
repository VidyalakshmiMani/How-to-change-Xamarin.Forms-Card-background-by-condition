using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace Card_BackgroundColor
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
    }

    public class CustomDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate ReportTemplate { get; set; }
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if (Convert.ToDouble(((Result)item).Marks) <= 40)
            {
                ((Result)item).BackgroundColor = Color.Red;
                return ReportTemplate;
            }
            else
            {
                ((Result)item).BackgroundColor = Color.LightGreen;
                return ReportTemplate;
            }
        }
    }
   
    public class TestViewModel
    {
        public ObservableCollection<Result> Data { get; set; }

        public TestViewModel()
        {
            Data = new ObservableCollection<Result>();
            Data.Add(new Result { Name = "Jessica", Subject = "Math", Marks = 34 });
            Data.Add(new Result { Name = "Alice", Subject = "Math", Marks = 75 });
            Data.Add(new Result { Name = "Rebecca", Subject = "Math", Marks = 20 });
            Data.Add(new Result { Name = "Alexander", Subject = "Math", Marks = 90 });
        }
    }

    public class Result
    {
        public string Name { get; set; }
       
        public string Subject { get; set; }

        public int Marks { get; set; }

        public Color BackgroundColor { get; set; }
    }
}
