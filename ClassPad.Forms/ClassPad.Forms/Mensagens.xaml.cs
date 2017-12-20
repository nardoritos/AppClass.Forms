using ClassPad.Forms.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ClassPad.Forms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Mensagens : ContentPage
	{

        private const string Url = "http://localhost:52915/api/user/messagelist";
        private HttpClient _client = new HttpClient();


        private ObservableCollection<MessageModel> _messages;

        protected override async void OnAppearing()
        {
            listView.IsRefreshing = true;
            var content = await _client.GetStringAsync(Url);
            var messages = JsonConvert.DeserializeObject<List<MessageModel>>(content);

            _messages = new ObservableCollection<MessageModel>(messages);
            listView.IsRefreshing = false;
            listView.ItemsSource = _messages;

            base.OnAppearing();
        }
        public Mensagens ()
		{
			InitializeComponent ();

            OnAppearing();
		}


        public IEnumerable<MessageModel> CarregaLista(string filter=null)
        {
            if (String.IsNullOrWhiteSpace(filter)) { return _messages; }

            return _messages.Where(s => s.nomemsg.StartsWith(filter, StringComparison.CurrentCultureIgnoreCase));
        }

        void OnRefreshing(object sender, EventArgs e)
        {
            OnAppearing();
            
            listView.EndRefresh();
        }

        void OnSearchTextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            listView.ItemsSource = CarregaLista(e.NewTextValue);
        }
	}
}