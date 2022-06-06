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

namespace Urovnenie
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        void Uravnenie_reshenie(double constanta1,double constanta2,double constanta3)
        {
            double diskriminant = 0;
            double x1 = 0;
            double x2 = 0;
            diskriminant = constanta2 * constanta2 - 4 * constanta1 * constanta3; //b * b - 4 * a * c
            if (diskriminant < 0)
            {
                Vivod.Text = "Решения нет";
            }
            else if (diskriminant == 0)
            {
                x1 = (-constanta2) / (2 * constanta1);
                Vivod.Text = "У данного уровнения один корень" + x1;   
            }
            else
            {
                x1 = (-constanta2 + Math.Sqrt(diskriminant)) / 2 * constanta1;
                x2 = (-constanta2 - Math.Sqrt(diskriminant)) / 2 * constanta1;
                Vivod.Text = "У данного уровнения 2 воможных корня, так как дискриминант больше 0 \nX1 = " + x1 + "\nx2 = " + x2;

            }
        }
        bool Text_box_ISEmpty()
        {
            return (Xkva.Text != "" && B.Text != ""&& C.Text != "");
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (Text_box_ISEmpty())
            {
                try
                {
                    Uravnenie_reshenie(Convert.ToDouble(Xkva.Text), Convert.ToDouble(B.Text), Convert.ToDouble(C.Text));
                }
                catch
                {
                    MessageBox.Show("Не коректный ввод", "Ошибка");
                }
            }
            else
                MessageBox.Show("Не все поля заполнены");
        
        }

        private void Xkva_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
