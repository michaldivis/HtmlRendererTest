using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows;
using TheArtOfDev.HtmlRenderer.WPF;

namespace HtmlRendererTest.Wpf
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private string _htmlTooltip;
        public string HtmlTooltip
        {
            get => _htmlTooltip;
            set
            {
                _htmlTooltip = value;
                OnPropertyChanged(nameof(HtmlTooltip));
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;

            HtmlTooltip = "Isn't <b>this</b> kinda <br> cool?";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
