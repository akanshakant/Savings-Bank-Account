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
 public partial class AddCustomer : Form
 {
 public AddCustomer()
 {
 InitializeComponent();
 }
 SqlConnection con = new SqlConnection("Data Source=DESKTOPUDH7VMN\\SQLEXPRESS01;Initial Catalog=SavingsBank;Integrated Security=True");
 private void button1_Click(object sender, EventArgs e)
 {
 con.Open();
 SqlCommand cmd = new SqlCommand("insert into register
(name,dob,gender,age,balance,accountno,email,phoneno,aadharno) values ('" + tname.Text +
"','" + tdob.Text + "','" + cbgender.Text + "'," + tage.Text + "," + tbalance.Text + ",'"
+ taccno.Text + "','" + temail.Text + "'," + tphone.Text + "," + taadhar.Text + ")",
con);
 cmd.ExecuteNonQuery();
 MessageBox.Show("Registered successfully!");
 con.Close();
 }
 private void TextBox4_TextChanged(object sender, EventArgs e)
 {
 }
 private void TextBox6_TextChanged(object sender, EventArgs e)
 {
 }
 private void tdob_TextChanged(object sender, EventArgs e)
 {
 }
 private void Label12_Click(object sender, EventArgs e)
 {
 }
 private void AddCustomer_Load(object sender, EventArgs e)
 {
 }
 private void button2_Click(object sender, EventArgs e)
 {
 con.Open();
 SqlCommand cmd = new SqlCommand("update register set phoneno=" + tphone.Text
+ ", balance=" + tbalance.Text + " where accountno='" + taccno.Text + "'", con);
 cmd.ExecuteNonQuery();
 MessageBox.Show("Updated successfully!");
 con.Close();
 }
 private void button3_Click(object sender, EventArgs e)
 {
 this.Hide();
 AdminActivities ad = new AdminActivities();
 ad.Show();
 }
 private void label3_Click(object sender, EventArgs e)
 {
 }
 private void label13_Click(object sender, EventArgs e)
 {
 }
 private void Label4_Click(object sender, EventArgs e)
 {
 }
 private void Label5_Click(object sender, EventArgs e)
 {
 }
 private void Label6_Click(object sender, EventArgs e)
 {
 }
 private void Label7_Click(object sender, EventArgs e)
 {
 }
 private void Label9_Click(object sender, EventArgs e)
 {
 }
 private void Label10_Click(object sender, EventArgs e)
 {
 }
 private void Label11_Click(object sender, EventArgs e)
 {
 }
 private void taadhar_TextChanged(object sender, EventArgs e)
 {
 }
 private void temail_TextChanged(object sender, EventArgs e)
 {
 }
 private void taccno_TextChanged(object sender, EventArgs e)
 {
 }
 private void tbalance_TextChanged(object sender, EventArgs e)
 {
 }
 private void tage_TextChanged(object sender, EventArgs e)
 {
 }
 private void cbgender_SelectedIndexChanged(object sender, EventArgs e)
 {
 }
 private void tname_TextChanged(object sender, EventArgs e)
 {
 }
 }
}
