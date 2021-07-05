using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace garantiTakip
{
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }
 

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

      

        private void viewMenu_Click(object sender, EventArgs e)
        {
            

            AnasayfaFrm childForm = new AnasayfaFrm();
            childForm.MdiParent = this;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Text = "Pencere " + childFormNumber++;
            childForm.Show();
        }

        private void garantiVeHizmetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GarantiDurumFrm childForm = new GarantiDurumFrm();
            childForm.MdiParent = this;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Text = "Pencere " + childFormNumber++;
            childForm.Show();

        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {
            GarantiDurumFrm form2 = new GarantiDurumFrm();
           
            if (form2.Getir3().Count!=0) 
            {
                GarantiRaporForm form = new GarantiRaporForm();
                form.Show();
            }
            AnasayfaFrm childForm = new AnasayfaFrm();
            childForm.MdiParent = this;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Text = "Pencere " + childFormNumber++;
            childForm.Show();
            
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
    
            CariEklemeForm childForm = new CariEklemeForm();
            childForm.MdiParent = this;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Text = "Pencere " + childFormNumber++;
            childForm.Show();
        }

        private void cariRaporlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RaporlarForm childForm = new RaporlarForm();
            childForm.MdiParent = this;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Text = "Pencere " + childFormNumber++;
            childForm.Show();
        }

        private void müşteriYetkiliRaporlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RaporlarMusterilerFrm childForm = new RaporlarMusterilerFrm();
            childForm.MdiParent = this;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Text = "Pencere " + childFormNumber++;
            childForm.Show();
        }

        //private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    frmGuncelle childfrm = new frmGuncelle();
        //    childfrm.MdiParent = this;
        //    childfrm.WindowState = FormWindowState.Maximized;
        //    childfrm.Text = "Pencere" + childFormNumber++;
        //    childfrm.Show();
        //}

        //private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    frmSil childfrm = new frmSil();
        //    childfrm.MdiParent = this;
        //    childfrm.WindowState = FormWindowState.Maximized;
        //    childfrm.Text = "Pencere" + childFormNumber++;
        //    childfrm.Show();
        //}

        //private void listeleToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    frmListele childfrm = new frmListele();
        //    childfrm.MdiParent = this;
        //    childfrm.WindowState = FormWindowState.Maximized;
        //    childfrm.Text = "Pencere" + childFormNumber++;
        //    childfrm.Show();
        //}

        //private void hizmetToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    frmHizmetTuru childfrm = new frmHizmetTuru();
        //    childfrm.MdiParent = this;
        //    childfrm.WindowState = FormWindowState.Maximized;
        //    childfrm.Text = "Pencere" + childFormNumber++;
        //    childfrm.Show();
        //}
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void raporlarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
