using Ezi.CustomMap.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TK.CustomMap.Overlays;
using Xamarin.Forms;

namespace Ezi.CustomMap.Pages
{
    public partial class HtmlInstructionsPage : ContentPage
    {
        public HtmlInstructionsPage(TKRoute route)
        {
            InitializeComponent();

            this.BindingContext = new HtmlInstructionsViewModel(route);
        }
    }
}
