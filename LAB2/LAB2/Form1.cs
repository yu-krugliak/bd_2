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
    public partial class Form1 : Form
    {
        BD_waterfallsEntities entities;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            entities = new BD_waterfallsEntities();
            entities.Animals.Load();
            animalsBindingSource.DataSource = entities.Animals.Local.ToBindingList();
            entities.Waterfalls.Load();
            waterfallsBindingSource.DataSource = entities.Waterfalls.Local.ToBindingList();
            entities.Visits.Load();
            visitsBindingSource.DataSource = entities.Visits.Local.ToBindingList();
            entities.Types.Load();
            typesBindingSource.DataSource = entities.Types.Local.ToBindingList();
            entities.Rivers.Load();
            riversBindingSource.DataSource = entities.Rivers.Local.ToBindingList();

   
            foreach (DataGridViewRow row in dataGridViewWaterfalls.Rows)
            {
                row.Height = 400;
            }
            dataGridViewWaterfalls.Columns[2].Width = 850;
            dataGridViewWaterfalls.Columns[0].Width = 50;
            dataGridViewWaterfalls.RowTemplate.Height = 200;

            //dataGridViewAnimals.Columns[3].Width = 250;
            dataGridViewAnimals.Columns[2].Width = 700;
            dataGridViewAnimals.RowTemplate.Height = 450;

            dataGridViewVisits.Columns[4].Width = 850;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ItemDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if(tabcontrol.SelectedTab.Name == "TabWaterfalls")
                {
                    var selectedWaterfall = (Waterfalls)dataGridViewWaterfalls.CurrentRow.DataBoundItem;
                    if ((from vs in entities.Visits where (vs.VS_ID_WATERFALLS == selectedWaterfall.WF_ID) select vs).Any())
                    {
                        MessageBox.Show("You can't delete, because this waterfall linked to table visits!", "Error of deleting waterfall");
                    }
                    else
                    {
                        waterfallsBindingSource.RemoveCurrent();
                        MessageBox.Show("Click button 'Save' to save the changes", "Save changes");
                        //entities.SaveChanges();
                    }
                }
                else if (tabcontrol.SelectedTab.Name == "TabAnimals")
                {
                    var selectedAnimal = (Animals)dataGridViewAnimals.CurrentRow.DataBoundItem;
                    if ((from vs in entities.Visits where (vs.VS_ID_ANIMALS == selectedAnimal.AN_ID) select vs).Any())
                    {
                        MessageBox.Show("You can't delete, because this animal linked to table visits!", "Error of deleting animal");
                    }
                    else
                    {
                        animalsBindingSource.RemoveCurrent();
                        MessageBox.Show("Click button 'Save' to save the changes", "Save changes");
                        //entities.SaveChanges();
                    }
                }
                else if (tabcontrol.SelectedTab.Name == "TabVisits")
                {

                    visitsBindingSource.RemoveCurrent();
                    MessageBox.Show("Click button 'Save' to save the changes", "Save changes");
                    //entities.SaveChanges();

                }
            }

            catch (Exception)
            {
                MessageBox.Show("Error of deleting!");
                throw;
            }
        }

        private void ItemSave_Click(object sender, EventArgs e)
        {
            entities.SaveChanges();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ItemSearch_Click(object sender, EventArgs e)
        {
            new SearchForm().Show();
        }
    }
}
