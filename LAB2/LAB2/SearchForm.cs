using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace LAB2
{
    public partial class SearchForm : Form
    {
        BD_waterfallsEntities entities;
        public SearchForm()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var query = entities.Waterfalls.AsQueryable();

            if (!String.IsNullOrWhiteSpace(textBoxRiver.Text))
            {
                var rv = entities.Rivers.FirstOrDefault(m => m.RV_NAME.StartsWith(textBoxRiver.Text));
                if(rv != null)
                {
                    query = query.Where(wf => wf.WF_RIVER_ID == rv.RV_ID);
                }
                
            }

            if (!String.IsNullOrWhiteSpace(textBoxType.Text))
            {
                var tp = entities.Types.FirstOrDefault(m => m.TP_NAME.StartsWith(textBoxType.Text));
                if (tp != null)
                {
                    query = query.Where(wf => wf.WF_TYPE_ID == tp.TP_ID);
                }
                
            }

            if (!String.IsNullOrWhiteSpace(textBoxName.Text))
            {
                var wf1 = entities.Waterfalls.FirstOrDefault(m => m.WF_NAME.StartsWith(textBoxName.Text));
                if (wf1 != null)
                {
                    query = query.Where(wf => wf.WF_ID == wf1.WF_ID);
                }

            }

            if (!String.IsNullOrWhiteSpace(textBoxHeight.Text))
            {
                int hh = Convert.ToInt32(textBoxHeight.Text);
                var wf1 = entities.Waterfalls.FirstOrDefault(m=> m.WF_HEIGHT == hh);
                if (wf1 != null)
                {
                    query = query.Where(wf => wf.WF_ID == wf1.WF_ID);
                }

            }

            dataGridView1.DataSource = query.ToList();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            entities = new BD_waterfallsEntities();
            entities.Waterfalls.Load();
            waterfallsBindingSource.DataSource = entities.Waterfalls.Local.ToBindingList();
            /*entities.Visits.Load();
            visitsBindingSource.DataSource = entities.Visits.Local.ToBindingList();*/
            entities.Types.Load();
            typesBindingSource.DataSource = entities.Types.Local.ToBindingList();
            entities.Rivers.Load();
            riversBindingSource.DataSource = entities.Rivers.Local.ToBindingList();

            dataGridView1.Columns[2].Width = 800;
            dataGridView1.Columns[0].Width = 50;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Height = 400;
            }


        }
    }
}
