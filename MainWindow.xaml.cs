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

namespace EsercizioBiblioteca
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            biblioteca = new Biblioteca("biblioteca", "via Roma", 8, 16);
            Libro l = new Libro("a", "a", 2012, "a", 120);
            biblioteca.AggiungiLibro(l);
            
            rbt_titolo.IsChecked = true;
            lbl_nLibri.Content = biblioteca.GetNLibri();
            RiempiListBox();
        }

        Biblioteca biblioteca;

        private void btn_cerca_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                lbx_libri.Items.Clear();
                if (rbt_titolo.IsChecked == true)
                {
                    foreach (Libro l in biblioteca.GetLibriStessoTitolo(tbx_cerca.Text))
                    {
                        lbx_libri.Items.Add(l);
                    }
                }
                else
                {
                    foreach (Libro l in biblioteca.GetLibriStessoAutore(tbx_cerca.Text))
                    {
                        lbx_libri.Items.Add(l);
                    }
                }
                tbx_cerca.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
        }

        private void btn_aggiungiLibro_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Libro libro = new Libro(tbx_autore.Text, tbx_titolo.Text, int.Parse(tbx_annoDiPubblicazione.Text), tbx_editore.Text, int.Parse(tbx_nPagine.Text));
                biblioteca.AggiungiLibro(libro);
                tbx_autore.Text = "";
                tbx_titolo.Text = "";
                tbx_annoDiPubblicazione.Text = "";
                tbx_editore.Text = "";
                tbx_nPagine.Text = "";
                lbl_nLibri.Content = biblioteca.GetNLibri();
                RiempiListBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
        }

        void RiempiListBox()
        {
            lbx_libri.Items.Clear();
            List<Libro> libri = biblioteca.Libri;
            foreach (Libro l in libri)
            {
                lbx_libri.Items.Add(l);
            }
        }
    }
}
