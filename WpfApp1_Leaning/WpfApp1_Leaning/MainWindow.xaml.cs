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

namespace WpfApp1_Leaning
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }



        public  void Button_Click(object sender, RoutedEventArgs e)
        {



            try
            {
                dynamic Income = double.Parse(txtIncome.Text);
                dynamic Expenses = double.Parse(txtexpenses.Text);
                dynamic Want = double.Parse(txtWant.Text);
                

                dynamic Result = Want / (Income - Expenses);
                if (Income>Expenses)
                {
                    txtResult.Text = Result.ToString();                   
                    Discription.Text = "";
                }
                else
                {
                    Discription.Text = "*รายรับน้อยกว่ารายจ่ายไม่สามารถคำนวนได้";
                    
                }

            }
            catch 
            {
                try
                {
                    if ((txtIncome.Text == "") || (txtexpenses.Text == "") || (txtWant.Text == ""))
                    {
                        MessageBox.Show("กรุณากรอกข้อมูลให้ครบทุกช่อง", "แจ้งเตือน");
                    }
                    else if (double.Parse(txtIncome.Text) - double.Parse(txtexpenses.Text) == 0)
                    {
                        Discription.Text = "*รายรับเท่ากับรายจ่ายไม่สามารถนำค่าไปคำนวนได้";
                    }
                    else { MessageBox.Show("กรุณากรอกข้อมูลเป็นตัวเลขเท่านั้น", "แจ้งเตือน"); }
                }
                catch
                {
                    MessageBox.Show("กรุณาตรวจการกรอกข้อมูลใหม่อีกครั้ง", "แจ้งเตือน");
                }

            }
            
        }

        public void txtResult_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

    }
}
