﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ClassPad.Forms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageTabs : TabbedPage
    {
        public PageTabs ()
        {
            InitializeComponent();
        }

    }
}