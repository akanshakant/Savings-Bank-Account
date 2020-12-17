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
 public partial class Deposit1 : Form
 {
 public Deposit1()
 {
 InitializeComponent();
 }
 SqlConnection con = new SqlConnection("Data Source=DESKTOPUDH7VMN\\SQLEXPRESS01;Initial Catalog=SavingsBank;Integrated Security=True");
 private void button1_Click(object sender, EventArgs e)
 {

 int test = int.Parse(depositamount.Text);
 if (test <= 0)
 {
 MessageBox.Show("You cannot enter negative amount");
 }
 else
 {
 MessageBox.Show("amount is > 0");
 con.Open();
 SqlCommand cmd = new SqlCommand("update register set balance=balance + "
+ depositamount.Text + " where accountno='" + cbaccno.SelectedItem.ToString() + "'",
con);
 cmd.ExecuteNonQuery();
 SqlCommand comd = new SqlCommand("insert into deposit
(accountno,depamount,balance) values ('" + cbaccno.SelectedItem.ToString() + "'," +
depositamount.Text + "," + depositbalance.Text + ")", con);
 comd.ExecuteNonQuery();
 MessageBox.Show("Deposited successfully!");
 con.Close();
 }

 }
 private void cbaccno_SelectedIndexChanged(object sender, EventArgs e)
 {
 con.Open();

 SqlCommand cmd = new SqlCommand("select balance from register where
accountno='" + cbaccno.SelectedItem.ToString() + "'", con);
 SqlDataReader dr = cmd.ExecuteReader();
 while (dr.Read())
 {
 depositbalance.Text = dr.GetValue(0).ToString();
 }
 dr.Close();
 con.Close();
 }
 private void Deposit1_Load(object sender, EventArgs e)
 {
 con.Open();
 SqlCommand cmd = new SqlCommand("select * from register", con);
 SqlDataReader dr = cmd.ExecuteReader();
 while (dr.Read())
 {
 cbaccno.Items.Add(dr.GetValue(5).ToString());
 }
 dr.Close();
 con.Close();
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
