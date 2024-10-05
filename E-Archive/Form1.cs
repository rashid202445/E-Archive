using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace E_Archive
{
    public partial class Form1 : Form
    {
        //كلاسات استدعاء عرض الصور 
        cg_image cg_image = new cg_image();
        hd_img hd_img = new hd_img();
        qu_img qu_image = new qu_img();
        // متغيرات لحفظ الصورة 
        MemoryStream ms;
        byte[] img;
        string cg_img ="لاتوجد صورة";
        string hd_imge = "لاتوجد صورة";
        string qu_imge = "لاتوجد صورة";
        // تم إضافة الدالة التالية لجلب الصورة و حفظها في قاعدة البيانات 
        void jbgimage()
        {
            ms = new MemoryStream();
            Emp_img.Image.Save(ms, Emp_img.Image.RawFormat);
            img = ms.ToArray();
        }
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E-Archive.accdb");

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (Emb_id.Text != "")
            {

                if (Emp_name.Text != "")
                {
                    if (Emp_phone.Text != "")
                    {
                        if (Emp_date.Value < DateTime.Now)
                        {
                            if (Emp_address.Text != "")
                            {
                                if (Emp_nationality.Text != "")
                                {
                                    if (Emp_img.Image != null)
                                    {
                                        if (Qu_date.Value < DateTime.Now)
                                        {
                                            if (Qu_major.Text != "")
                                            {
                                                if (Emp_salary.Text != "")
                                                {
                                                    if (Hd_id.Text != "")
                                                    {
                                                        if (Hd_date.Value < DateTime.Now)
                                                        {
                                                            if (Jop_title.Text != "")
                                                            {
                                                                try
                                                                {
                                                                    jbgimage();
                                                                    OleDbCommand cmd = con.CreateCommand();
                                                                    con.Open();
                                                                    string s;
                                                                    if (Emp_gender.Checked) s = "ذكر";

                                                                    else s = "انثى";
                                                                    cmd.CommandText = "Insert into Employees(Emp_id,Emp_name,Emp_gender,Emp_date,Birth_date,Emp_image,Emp_nationality,Emp_phone,Emp_address,Jop_title,Emp_salary,Qualific_major,Oualific_date,Qualific_image,HD_ID,HD_image,Insurance_date,CG_image,Record_state,Added_date)Values('" +
                                                                                                             Emb_id.Text + "','" + Emp_name.Text + "','" + s + "','" + Hd_date.Value + "','" + Emp_date.Value + "',@image,'" + Emp_nationality.Text + "','" + Emp_phone.Text + "','" + Emp_address.Text + "','" + Jop_title.Text + "','" + Convert.ToDouble(Emp_salary.Text) + "','" + Qu_major.Text + "','" +
                                                                        Qu_date.Value.Year.ToString() + "','" + Qu_image.Text + "','" + Hd_id.Text + "','" + Hd_img.Text + "','" + Ins_date.Text + "','" + textBox7.Text + "','1','" + DateTime.Now.ToString("MM/dd/yyyy hh:mm tt") + "')";
                                                                    // لاسناد قيمة البتات الى قيمة الادخال تم استدعاء البارمتر التالي 
                                                                    OleDbParameter Parameters = cmd.Parameters.AddWithValue("@image", OleDbType.Binary);
                                                                    Parameters.Value = img;
                                                                    Parameters.Size = img.Length;
                                                                    cmd.Connection = con;
                                                                    if (cmd.ExecuteNonQuery() > 0) MessageBox.Show("Record Submitted", "Congrats");
                                                                    else
                                                                        MessageBox.Show("error", "Congrats");
                                                                    con.Close();

                                                                    // عمل رفرش لعرض البيانات في الداتا جرد فيو 
                                                                    getAll();
                                                                    dataGridView1.Refresh();
                                                                    cler();
                                                                }

                                                                catch (Exception ew)
                                                                {
                                                                    con.Close();
                                                                    MessageBox.Show(ew.Message, "Congrats");
                                                                }
                                                                

                                                            }
                                                            else
                                                            {
                                                                Emp_img.Focus();
                                                                MessageBox.Show("يرجى أدخال المسمى الوظيفي ");
                                                            }

                                                        }
                                                        else
                                                        {
                                                            Emp_img.Focus();
                                                            MessageBox.Show("يرجى أدخال رقم قرار التعيين ");
                                                        }

                                                    }
                                                    else
                                                    {
                                                        Emp_img.Focus();
                                                        MessageBox.Show("يرجى أدخال رقم قرار التعيين ");
                                                    }
                                                }
                                                else
                                                {
                                                    Emp_salary.Focus();
                                                    MessageBox.Show("يرجى أدخال راتب الموظف ");
                                                }

                                            }
                                            else
                                            {
                                                Qu_major.Focus();
                                                MessageBox.Show("يرجى أدخال المؤهل التعليمي ");
                                            }

                                        }
                                        else
                                        {
                                            Qu_date.Focus();
                                            MessageBox.Show("يرجى أدخال سنة التخرج بشكل صحيح ");

                                        }

                                    }
                                    else
                                    {
                                        Emp_img.Focus();
                                        MessageBox.Show("يرجى أدخال صورة الموظف ");
                                    }
                                }
                                else
                                {
                                    Emp_nationality.Focus();
                                    MessageBox.Show("يرجى أدخال الجنسية ");
                                }

                            }
                            else
                            {
                                Emp_address.Focus();
                                MessageBox.Show("يرجى أدخال عنوان الموظف ");
                            }

                        }
                        else
                        {
                            Emp_date.Focus();
                            MessageBox.Show("يرجى أدخال تاريخ الميلاد بشكل صحيح ");

                        }
                    }
                    else
                    {
                        Emp_name.Focus();
                        MessageBox.Show("يرجى أدخال رقم الموظف ");
                    }

                }
                else
                {
                    Emp_name.Focus();
                    MessageBox.Show("يرجى أدخال إسم الموظف ");
                }
            }
            else
            {
                Emb_id.Focus();
                MessageBox.Show("يرجى أدخال رقم الوظيفي ");
            }             
                
                getAll();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getAll();
            button9.Enabled = false;
            button10.Enabled = false;
        }
        void getAll()
        {
           
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT Emp_image as  [صورة الموظف], Emp_id as [رقم الموظف] , Emp_name as  [أسم الموظف],Emp_gender as  [الجنس] ,Emp_date as  [تاريخ التوظيف],Birth_date as  [تاريخ الميلاد],Emp_nationality as  [الجنسية],Emp_phone as  [رقم التلفون],Emp_address as  [العنوان],Jop_title as  [المسمى الوظيفي],Emp_salary as  [الراتب],Qualific_major as  [المؤهل التعليمي],Oualific_date as  [سنة التخرج],Qualific_image as  [صورة المؤهل],HD_ID as  [رقم فرار التعيين],HD_image as  [صورة قرار التعيين],Insurance_date as  [تاريخ الدخول الضمان],CG_image as  [صورة الظمانة],Record_state as  [حالة الموظف],Added_date as  [تاريخ الاضافة],Modify_date as [تاريخ التعديل]  from Employees  WHERE Record_state= true";
            cmd.Connection = con;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if(dt.Rows.Count == 0)
            label19.Text +=" : " + dt.Rows.Count;
            else
                label19.Text += dt.Rows.Count - 1;

            // تم اضافة السطرين التاليين للتحكم في الحقول 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            con.Close();
           dataGridView1.DataSource = dt;
         //   Emp_img = (DataGridViewImageColumn)dataGridView1.Columns[0];

            this.dataGridView1.Columns["حالة الموظف"].Visible = false;
            this.dataGridView1.Columns["صورة الموظف"].Visible = false;          
            this.dataGridView1.Columns["صورة المؤهل"].Visible = false;
            this.dataGridView1.Columns["صورة قرار التعيين"].Visible = false;
            this.dataGridView1.Columns["صورة الظمانة"].Visible = false;
       
            // حساب العملة اليمنية 
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("ar-YE");
            this.dataGridView1.Columns["الراتب"].DefaultCellStyle.Format = "C";


        }
        private void button9_Click(object sender, EventArgs e)
        {
            try
            {


                //
                jbgimage();
                OleDbCommand cmd = con.CreateCommand();
                con.Open();
                string s;
                if (Emp_gender.Checked) s = "ذكر";
                else s = "انثى";
                cmd.CommandText = "UPDATE Employees SET Emp_name= '" + Emp_name.Text + "' , Emp_gender= '" + s + "' , Emp_date= '" + Hd_date.Value.ToShortDateString() + "' , Birth_date= '" + Emp_date.Value.ToShortDateString() + "' , Emp_image='"+Emp_img.Image+"'  , Emp_nationality= '" + Emp_nationality.Text +
                    "' , Emp_phone= '" + Emp_phone.Text + "', Emp_address= '" + Emp_address.Text + "', Jop_title= '" + Jop_title.Text + "', Emp_salary= '" + Convert.ToDouble(Emp_salary.Text) + "', Qualific_major= '" + Qu_major.Text + "', Oualific_date= '" + Qu_date.Value.Year.ToString() + "', Qualific_image= '" + Qu_image.Text + " ', HD_ID= '" + Hd_id.Text + "', HD_image= '" + 
                    Hd_img.Text + "', Insurance_date= '" + Ins_date.Value.ToShortDateString() + "', CG_image= '" + textBox7.Text + "', Modify_date= '" + DateTime.Now.ToString("MM/dd/yyyy hh:mm tt") + "' WHERE Emp_id = '" + Emb_id.Text+"'";
                // لاسناد قيمة البتات الى قيمة الادخال تم استدعاء البارمتر التالي
                  OleDbParameter Parameters = cmd.Parameters.AddWithValue("@image", OleDbType.Binary);
                   Parameters.Value = img;
                   Parameters.Size = img.Length;   
                //
                cmd.Connection = con;
                if (cmd.ExecuteNonQuery() > 0) MessageBox.Show("Record Submitted", "Congrats");
                else
                    MessageBox.Show("error", "Congrats");
                button8.Enabled = true;
                con.Close();
            }
            catch (Exception ew)
            {
                con.Close();
                MessageBox.Show(ew.Message, "Congrats");
            }
            cler();
            getAll();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Emb_id.Text = this.dataGridView1.CurrentRow.Cells["رقم الموظف"].Value.ToString();
                Emp_name.Text = this.dataGridView1.CurrentRow.Cells["أسم الموظف"].Value.ToString();
                if ("ذكر" == this.dataGridView1.CurrentRow.Cells["الجنس"].Value.ToString()) Emp_gender.Checked = true;
                else Emp_gander1.Checked = true;
                Emp_date.Value = Convert.ToDateTime(this.dataGridView1.CurrentRow.Cells["تاريخ الميلاد"].Value);
                try
                {
                    byte[] img = (byte[])dataGridView1.CurrentRow.Cells["صورة الموظف"].Value;
                    MemoryStream mms = new MemoryStream(img);
                    Emp_img.SizeMode = PictureBoxSizeMode.StretchImage;
                    Emp_img.Image = Image.FromStream(mms);
                }
                catch { }
                Emp_nationality.Text = this.dataGridView1.CurrentRow.Cells["الجنسية"].Value.ToString();
                Emp_phone.Text = this.dataGridView1.CurrentRow.Cells["رقم التلفون"].Value.ToString();
                Emp_address.Text = this.dataGridView1.CurrentRow.Cells["العنوان"].Value.ToString();
                Jop_title.Text = this.dataGridView1.CurrentRow.Cells["المسمى الوظيفي"].Value.ToString();
                Emp_salary.Text = this.dataGridView1.CurrentRow.Cells["الراتب"].Value.ToString();
                Qu_major.Text = this.dataGridView1.CurrentRow.Cells["المؤهل التعليمي"].Value.ToString();
               
                if ("" != this.dataGridView1.CurrentRow.Cells["صورة المؤهل"].Value.ToString())
                {
                    Qu_image.Text = "img";
               //     Qu_image.Tag = (byte[])dataGridView1.CurrentRow.Cells["صورة المؤهل"].Value;
                }
                Hd_id.Text = this.dataGridView1.CurrentRow.Cells["رقم فرار التعيين"].Value.ToString();
                if ("" != this.dataGridView1.CurrentRow.Cells["صورة قرار التعيين"].Value.ToString())
                {
                    Hd_img.Text = "img";
                 //   Hd_img.Tag = (byte[])dataGridView1.CurrentRow.Cells["صورة قرار التعيين"].Value;
                }
                Hd_date.Value = Convert.ToDateTime(this.dataGridView1.CurrentRow.Cells["تاريخ التوظيف"].Value);
                Ins_date.Value = Convert.ToDateTime(this.dataGridView1.CurrentRow.Cells["تاريخ الدخول الضمان"].Value);
                if ("" != this.dataGridView1.CurrentRow.Cells["صورة الظمانة"].Value.ToString())
                {
                    textBox7.Text = "img";
                    //   textBox7.Tag = (byte[])dataGridView1.CurrentRow.Cells["صورة الظمانة"].Value;
                }
                button8.Enabled = false;
                button9.Enabled = true;
                button10.Enabled = true;
                Qu_date.Text = this.dataGridView1.CurrentRow.Cells["سنة التخرج"].Value.ToString();
            }
            catch { }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand cmd = con.CreateCommand();
                con.Open();
                
                cmd.CommandText = "UPDATE Employees SET Record_state=false  WHERE Emp_id = '" + Emb_id.Text + "'";
                cmd.Connection = con;
                if (cmd.ExecuteNonQuery() > 0) MessageBox.Show("Record Submitted", "Congrats");
                else
                    MessageBox.Show("error", "Congrats");
                con.Close();
                button8.Enabled = true;
            }
            catch (Exception ew)
            {
                con.Close();
                MessageBox.Show(ew.Message, "Congrats");
            }
            cler();
            getAll();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog openimage = new OpenFileDialog();
            openimage.Title = "Select Image";
            openimage.Filter = "Image Files|*.jpg;*.jpeg;*.png ";
            if (openimage.ShowDialog() == DialogResult.OK)
            {
                Emp_img.SizeMode = PictureBoxSizeMode.StretchImage;
                Emp_img.Image = Image.FromFile(openimage.FileName);
            }


        }

        private void button11_Click(object sender, EventArgs e)
        {
            cler();
        }
        void cler()
        {
            Emp_address.Text = "";
            Emb_id.Text = "";
            Emp_name.Text = "";
            Emp_phone.Text = "";
            Emp_salary.Text = "0";
            Emp_nationality.Text = "";
            Jop_title.Text = "";
            Hd_id.Text = "";
            Hd_img.Text = "";
            CG_img.Text = "";
            Qu_major.Text = "";
            Qu_image.Text = "";
            button8.Enabled = true;
            button9.Enabled = false;
            button10.Enabled = false;
            Emp_img.Image = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png ";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                hd_imge = dlg.FileName;
                Hd_img.Text = dlg.FileName;
                hd_img.hd_pictcher.Image = Image.FromFile(dlg.FileName);
                
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png ";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Qu_image.Text = dlg.FileName;
                qu_imge = dlg.FileName;
                qu_image.qu_pictcher.Image = Image.FromFile(dlg.FileName);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png ";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                cg_img = dlg.FileName;
                textBox7.Text = dlg.FileName;
                cg_image.cg_pictcher.Image = Image.FromFile(dlg.FileName);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cg_image.Show();
            cg_image.Text = cg_img;
            qu_image.Hide();
            hd_img.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            hd_img.Show();
            hd_img.Text = hd_imge;
            qu_image.Hide();
            cg_image.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            qu_image.Show();
            qu_image.Text = qu_imge;
            cg_image.Hide();
            hd_img.Hide();
        }
    }
}
