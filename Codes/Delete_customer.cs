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
 public partial class DeleteCustomer : Form
 {
 public DeleteCustomer()

 {
 InitializeComponent();
 }
 SqlConnection con = new SqlConnection("Data Source=DESKTOPUDH7VMN\\SQLEXPRESS01;Initial Catalog=SavingsBank;Integrated Security=True");
 private void button1_Click(object sender, EventArgs e)
 {
 con.Open();
 SqlCommand cmd = new SqlCommand("delete from register where accountno='" +
textBox1.Text + "'", con);
 cmd.ExecuteNonQuery();
 MessageBox.Show("Deleted successfully!");
 con.Close();
 }
 private void DeleteCustomer_Load(object sender, EventArgs e)
 {
 Refresh();
 }
 private void button2_Click(object sender, EventArgs e)
 {
 int rowindx = dgv_deletecustomer.SelectedCells[0].RowIndex;
 con.Open();
 SqlCommand cmd = new SqlCommand("delete from register where accountno='" +
dgv_deletecustomer.Rows[rowindx].Cells[5].Value.ToString() + "'", con);
 cmd.ExecuteNonQuery();
 MessageBox.Show("Deleted successfully!");
 con.Close();
 Refresh();
 }
 void Refresh()
 {
 con.Open();
 SqlDataAdapter ada = new SqlDataAdapter("select * from register", con);
 DataSet ds = new DataSet();
 ada.Fill(ds, "register");
 dgv_deletecustomer.DataSource = ds;
 dgv_deletecustomer.DataMember = "register";
 con.Close();
 }
 private void label2_Click(object sender, EventArgs e)
 {
 }
 private void dgv_deletecustomer_CellContentClick(object sender,
DataGridViewCellEventArgs e)
 {
 }
 private void button3_Click(object sender, EventArgs e)
 {
 this.Hide();
 AdminActivities ad = new AdminActivities();
 ad.Show();
 }
 }
}
