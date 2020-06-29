using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Card_BackgroundColor
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContentLayout : Grid
    {
        public ContentLayout()
        {
            InitializeComponent();
        }
    }
}