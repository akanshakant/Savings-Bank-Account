using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsApp2
{
 public partial class Withdraw : Form

 {
 public Withdraw()
 {
 InitializeComponent();
 }
 SqlConnection con = new SqlConnection("Data Source=DESKTOPUDH7VMN\\SQLEXPRESS01;Initial Catalog=SavingsBank;Integrated Security=True");
 private void button1_Click(object sender, EventArgs e)
 {
 int test = int.Parse(wdamount.Text);
 if (test <= 0)
 {
 MessageBox.Show("You cannot enter negative amount");
 }
 else
 {
 con.Open();
 SqlCommand cmd = new SqlCommand("update register set balance=balance - "
+ wdamount.Text + " where accountno='" + wdaccno.Text + "'", con);
 cmd.ExecuteNonQuery();
 MessageBox.Show("Withdrawal done successfully!");
 con.Close();
 }
 }
 private void button2_Click(object sender, EventArgs e)
 {
 this.Hide();
 CustomerDetails cd = new CustomerDetails();
 cd.Show();
 }
 private void button3_Click(object sender, EventArgs e)
 {
 this.Hide();
 AdminActivities ad = new AdminActivities();
 ad.Show();
 }
 }
}
