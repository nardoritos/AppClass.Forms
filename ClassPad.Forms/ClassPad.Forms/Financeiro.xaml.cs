using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ClassPad.Forms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Financeiro : ContentPage
    {

        private ObservableCollection<FinanceiroModel> _pagtos = new ObservableCollection<FinanceiroModel>{
            new FinanceiroModel{
                status = "",
                referencia = "Boleto de Dezembro",
                venc = "18/12/2017",
                valor = "946,00",
                pag = ""
            },
            new FinanceiroModel{
                status = "OK",
                referencia = "Boleto de Novembro",
                venc = "18/11/2017",
                valor = "946,00",
                pag = "15/11/017"
            },
            new FinanceiroModel{
                status = "OK",
                referencia = "Boleto de Outubro",
                venc = "18/10/2017",
                valor = "946,00",
                pag = "03/10/2017"
            },
            new FinanceiroModel{
                status = "OK",
                referencia = "Boleto de Setembro",
                venc = "18/09/2017",
                valor = "946,00",
                pag = "05/09/2017"
            }
        };
        public Financeiro()
        {
            InitializeComponent();
            listView.ItemsSource = _pagtos;
        }

    }
}