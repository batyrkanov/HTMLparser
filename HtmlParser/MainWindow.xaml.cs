using HtmlParser.Core;
using HtmlParser.Core.OcKg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HtmlParser
{
    

    public partial class MainWindow : Window
    {
        ParserWorker<string[]> parser;

        public MainWindow()
        {
            InitializeComponent();
            parser = new ParserWorker<string[]>(
                    new OsParser()
                );
            parser.OnCompleted += Parser_OnCompleted;
            parser.OnNewData += Parser_OnNewData;
        }

        private void Parser_OnNewData(object arg1, string[] arg2)
        {
            listbox.Items.Add(arg2);
        }

        private void Parser_OnCompleted(object obj)
        {
            MessageBox.Show("All work!");
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            parser.Settings = new OsSettings(Convert.ToInt32(txtstart.Text), Convert.ToInt32(txtendpoint.Text));
            parser.Start();
        }

        private void btnAbort_Click(object sender, RoutedEventArgs e)
        {
            parser.Abort();
        }
    }
}
