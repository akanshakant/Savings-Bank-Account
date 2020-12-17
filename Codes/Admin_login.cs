using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsApp2
{
 public partial class AdminLogin : Form
 {
 public AdminLogin()
 {
 InitializeComponent();
 }
 SqlConnection con = new SqlConnection("Data Source=DESKTOPUDH7VMN\\SQLEXPRESS01;Initial Catalog=SavingsBank;Integrated Security=True");
 private void label4_Click(object sender, EventArgs e)
 {
 }
 private void button1_Click(object sender, EventArgs e)
 {
 con.Open();
 SqlCommand cmd = new SqlCommand("select * from admin_login where username='" +
adminid.Text + "' and password='" + adminpwd.Text + "'", con);
 SqlDataReader dr = cmd.ExecuteReader();
 if (dr.Read())
 {
 AdminActivities adminact = new AdminActivities();
 adminact.Show();
 }
 else
 {
 MessageBox.Show("Invalid username");
 }
 dr.Close();
 con.Close();
 }
 }
}
