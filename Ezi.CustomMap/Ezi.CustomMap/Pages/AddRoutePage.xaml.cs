using Ezi.CustomMap.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TK.CustomMap;
using TK.CustomMap.Overlays;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace Ezi.CustomMap.Pages
{
    public partial class AddRoutePage : ContentPage
    {
        public AddRoutePage(ObservableCollection<TKRoute> routes, ObservableCollection<TKCustomMapPin> pins, MapSpan bounds)
        {
            InitializeComponent();

            var googleImage = new Image
            {
                Source = "powered_by_google_on_white.png"
            };

            var searchFrom = new PlacesAutoComplete(true) { ApiToUse = PlacesAutoComplete.PlacesApi.Google, Bounds = bounds, Placeholder = "From" };
            searchFrom.SetBinding(PlacesAutoComplete.PlaceSelectedCommandProperty, "FromSelectedCommand");
            var searchTo = new PlacesAutoComplete(true) { ApiToUse = PlacesAutoComplete.PlacesApi.Google, Bounds = bounds, Placeholder = "To" };
            searchTo.SetBinding(PlacesAutoComplete.PlaceSelectedCommandProperty, "ToSelectedCommand");

            if (Device.OS == TargetPlatform.Android)
            {
                this._baseLayout.Children.Add(
                    googleImage,
                    Constraint.Constant(10),
                    Constraint.RelativeToParent(l => l.Height - 30));
            }

            this._baseLayout.Children.Add(
                searchTo,
                yConstraint: Constraint.RelativeToView(searchFrom, (l, v) => searchFrom.HeightOfSearchBar + 10));

            this._baseLayout.Children.Add(
                searchFrom,
                Constraint.Constant(0),
                Constraint.Constant(10));

            this.BindingContext = new AddRouteViewModel(routes, pins, bounds);
        }
    }
}
