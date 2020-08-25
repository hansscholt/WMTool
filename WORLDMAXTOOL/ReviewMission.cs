using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WORLDMAXTOOL
{   
    public partial class ReviewMission : Form
    {
        
        DataGridView dataGridView;
        public ReviewMission()
        {
            MaximizeBox = false;
            InitializeComponent();

            this.SizeChanged += ReviewMission_SizeChanged;

            dataGridView = new DataGridView();            

            DataTable table = new DataTable();
            table.Columns.Add("MERCY PASS", typeof(bool));
            table.Columns.Add("CLEAR", typeof(bool));
            table.Columns.Add("LAND", typeof(string));
            table.Columns.Add("NAME", typeof(string));
            table.Columns.Add("TYPE", typeof(string));
            table.Columns.Add("ID", typeof(string));
            table.Columns.Add("IID", typeof(int));

            CheckBox c = new CheckBox();
            c.Text = "DSA";
            c.Checked = true;
            foreach (var item in Mission.allMissionData)
                table.Rows.Add(item.bPass,item.bClear,item.sLand, item.sName, item.sType, item.sId, item.iId);
            

            pnlMission.Size = this.Size;
            dataGridView.Width = pnlMission.Width - 35;
            dataGridView.Height = pnlMission.Height - 100;

            dataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView.RowHeadersVisible = false;
            dataGridView.AutoResizeColumns();
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AllowUserToAddRows = false;

            dataGridView.DataSource = table;
           
            //{
            //    DataGridViewCheckBoxColumn ckPath = new DataGridViewCheckBoxColumn();
            //    ckPath.Name = "OpenPaths?";
            //    ckPath.HeaderText = "OpenPaths?";
            //    ckPath.ReadOnly = false;
            //    ckPath.FillWeight = 10; //if the datagridview is resized (on form resize) the checkbox won't take up too much; value is relative to the other columns' fill values
            //    dataGridView.Columns.Add(ckPath);
           
            //    DataGridViewCheckBoxColumn ckPass = new DataGridViewCheckBoxColumn();
            //    ckPass.Name = "Complete?";
            //    ckPass.HeaderText = "Complete?";
            //    ckPass.ReadOnly = false;
            //    ckPass.FillWeight = 10; //if the datagridview is resized (on form resize) the checkbox won't take up too much; value is relative to the other columns' fill values
            //    dataGridView.Columns.Add(ckPass);
            //}

            
            pnlMission.Controls.Add(dataGridView);
        }

        private void ReviewMission_SizeChanged(object sender, EventArgs e)
        {

            pnlMission.Size = this.Size;
            dataGridView.Width = pnlMission.Width - 35;
            dataGridView.Height = pnlMission.Height - 100;
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           

            foreach (DataGridViewRow item in dataGridView.Rows)
            {
                int iID = (int)item.Cells[6].Value;
                bool bPass = (bool)item.Cells[0].Value;
                bool bClear = (bool)item.Cells[1].Value;
                int iMission = Array.FindIndex(Mission.allMissionData, m => m.iId == iID);
                Mission.allMissionData[iMission].bClear = bClear;
                Mission.allMissionData[iMission].bPass = bPass;
            }
            //for (int i = 0; i < Mission.allMission.Count; i++)
            //{
            //    MissionData m = Mission.allMission[i];
            //    m.bClear = true;
            //    Mission.allMission[i] = m;
            //}

            this.Close();
        }
    }
}
