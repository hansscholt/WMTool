using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WORLDMAXTOOL
{
    public partial class MainForm : Form
    {
        byte[] uncSave;
        byte[] encSave;
        int saveAvatar;

        public MainForm()
        {
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;            
            InitializeComponent();
        }

        private void btnPick_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "NXA Data Files|*.bin";
            openFileDialog.Title = "Select your nxasave file";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.DefaultExt = "bin";
            openFileDialog.InitialDirectory = Environment.CurrentDirectory;

         
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (openFileDialog.SafeFileName == "nxasave.bin")
                {
                    OpenSaveFile(openFileDialog.FileName);
                }
                else
                {
                    MessageBox.Show("just nxasave.bin is supported");
                }
               
            }
        }

        void OpenSaveFile(string sPath)
        {
            Directory.CreateDirectory("BACKUP");
            File.Copy(sPath, "BACKUP/nxasave.bin", true);

            byte[] saveFile = File.ReadAllBytes(sPath);
            uncSave = saveFile.SubArray(0, 0x144);

            encSave = saveFile.SubArray(0x144, saveFile.Length - 0x144);

            Tools.Decode(encSave);



            Mission.ReadMisson(encSave);

            string sName = Encoding.UTF8.GetString(saveFile.SubArray(0x0, 8));
            string sSerial = Encoding.UTF8.GetString(encSave.SubArray(0x4, 24));
            int iAvatar = encSave.SubArray(0x4C, 1)[0];
            saveAvatar = iAvatar;
            numAvatar.Value = saveAvatar;
            picAvatar.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("CH_" + (iAvatar + 1).ToString("000"));
            txtName.Text = sName;
            txtSerial.Text = sSerial;


            string bbb = Encoding.UTF8.GetString(encSave.SubArray(0x8984, 24));

            //================================================//
            Util util = new Util();
            util.LoadFromBuffer(saveFile);
            txtAMCRC.Text = util.stateArea.crc.ToString();
            txtToolCRC.Text = MyCRC(encSave).ToString();

            txtCurrentLand.Text = util.stateArea.currentland.ToStringFromUTF8();
            txtCurrentMission.Text = util.stateArea.currentmission.ToStringFromUTF8();
            txtCurrentMileage.Text = util.stateArea.playcount.ToString();

            panelData.Enabled = true;
            groupCheat.Enabled = true;
            groupItem.Enabled = true;
            btnSave.Enabled = true;
        }




        uint MyCRC(byte[] enc)
        {
            byte[] newArray = new byte[enc.Length - 4];
            Array.Copy(encSave, 4, newArray, 0, newArray.Length);
            File.WriteAllBytes("other/dec", newArray);
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.RedirectStandardInput = true;
                cmd.StartInfo.RedirectStandardOutput = true;
                cmd.StartInfo.CreateNoWindow = true;
                cmd.StartInfo.UseShellExecute = false;
                cmd.Start();

                cmd.StandardInput.WriteLine("cd other");
                cmd.StandardInput.Flush();
                cmd.StandardInput.WriteLine("rehash.exe -none -adler32 dec -out:raw");
                cmd.StandardInput.Flush();
                cmd.StandardInput.Close();
                cmd.WaitForExit();
                string ss = cmd.StandardOutput.ReadToEnd().Split(new string[] { "Adler32" }, StringSplitOptions.None)[1];
                ss = ss.Trim();
                ss = ss.Substring(2, 8);

                cmd.Close();
                File.Delete("other/dec");
                return Convert.ToUInt32(ss, 16);
            }
        }

        private void btnMission_Click(object sender, EventArgs e)
        {
            ReviewMission r = new ReviewMission();
            r.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string usb = txtSerial.Text;
            string sName = txtName.Text;

            int serialSize = usb.Length < 24 ? usb.Length : 24;
            int nameSize = sName.Length < 8 ? sName.Length : 8;

            //Tools.Encode(encSave);
            //if (NXALoaded)
            //File.WriteAllBytes("nxasave.bin.bak", Tools.Combine(uncSave, encSave, new byte[0]));            
            //Tools.Decode(encSave);

            //Change Serial:
            //string usb = "0000000000000030";
            for (int i = 0; i < serialSize; i++)
            {
                //encSave[i + Constants.SAVE_SERIAL] = (byte)usbSerialLabel.Text[i];
                encSave[i + 0x4] = (byte)usb[i];
            }
            for (int i = serialSize; i < 24; i++)
            {
                encSave[i + 0x4] = 0x00; // Fill remaining bytes if needed
            }

            //Change Name1:
            for (int i = 0; i < nameSize; i++)
            {
                uncSave[i + 0x0] = (byte)sName[i];
            }
            for (int i = nameSize; i < 8; i++)
            {
                uncSave[i + 0x0] = 0x00; // Fill remaining bytes if needed
            }

            //Change Name2:
            for (int i = 0; i < nameSize; i++)
            {
                encSave[i + 0x58] = (byte)sName[i];
            }
            for (int i = nameSize; i < 8; i++)
            {
                encSave[i + 0x58] = 0x00; // Fill remaining bytes if needed
            }

            encSave[0x4C] = (byte)(saveAvatar & 0xFF);

            //string s = "";

            int iBaseM = 384;
            int iBaseI = 5504;
            //primer ciclo es "legacy"
            for (int i = 0; i < Mission.allMissionData.Length; i++)
            {
                if (Mission.allMissionData[i].bClear)
                {
                    //pasar todas(o casi todas)
                    encSave[iBaseM + Mission.allMissionData[i].iId] = 31;
                }
                else
                {
                    encSave[iBaseM + Mission.allMissionData[i].iId] = 0;
                }

                if (Mission.allMissionData[i].bPass)
                {
                    //abrir todos los caminos(o casi todos)
                    encSave[iBaseI + (Mission.allMissionData[i].iId * 4)] = 3;
                    encSave[iBaseI + (Mission.allMissionData[i].iId * 4) + 1] = 0;
                    encSave[iBaseI + (Mission.allMissionData[i].iId * 4) + 2] = 0;
                    encSave[iBaseI + (Mission.allMissionData[i].iId * 4) + 3] = 0;
                }
                else
                {
                    encSave[iBaseI + (Mission.allMissionData[i].iId * 4)] = 0;
                    encSave[iBaseI + (Mission.allMissionData[i].iId * 4) + 1] = 0;
                    encSave[iBaseI + (Mission.allMissionData[i].iId * 4) + 2] = 0;
                    encSave[iBaseI + (Mission.allMissionData[i].iId * 4) + 3] = 0;
                }
            }

            //segundo es para los cerdos
            for (int i = 0; i < Mission.allMissionData.Length; i++)
            {
                if (ckClear.Checked)
                {
                    //pasar todas(o casi todas)
                    encSave[iBaseM + Mission.allMissionData[i].iId] = 31;
                }

                if (ckPath.Checked)
                {
                    //abrir todos los caminos(o casi todos)
                    encSave[iBaseI + (Mission.allMissionData[i].iId * 4)] = 3;
                    encSave[iBaseI + (Mission.allMissionData[i].iId * 4) + 1] = 0;
                    encSave[iBaseI + (Mission.allMissionData[i].iId * 4) + 2] = 0;
                    encSave[iBaseI + (Mission.allMissionData[i].iId * 4) + 3] = 0;
                }
            }
            if (ckPath.Checked)
            {
                //repasar portales
                encSave[35208] = 16;
                encSave[35209] = 16;
                encSave[35210] = 16;
                encSave[35211] = 16;
                encSave[35212] = 16;
                encSave[35213] = 16;
                encSave[35214] = 16;
                encSave[35215] = 16;
                encSave[35216] = 16;
            }

            if (ckBarrier.Checked)
            {
                //barreras
                encSave[9601] = 1;  //azul?
                encSave[9603] = 1;  //verde?
                encSave[9604] = 1;  //gris?
                encSave[9606] = 1;  //amarillo?
                encSave[9607] = 1;  //púrpura?
                encSave[9609] = 1;  //rojo?
            }

            if(ckPortal.Checked)
            {
                encSave[35129] = 1;  //arowahi?     N
                encSave[35130] = 1;  //rootinia?    X

                encSave[35131] = 1;  //barharn?     AB
                encSave[35132] = 1;  //morigin?     SO

                encSave[35133] = 1;  //mirtain?     LU
                encSave[35134] = 1;  //ladania?     T

                encSave[35135] = 1;  //cryomiston?  E
            }

            if (ckPandonus.Checked)
                encSave[1382] = 1;
            else
                encSave[1382] = 0;
            if (ckPhantomia.Checked)
                encSave[1383] = 1;
            else
                encSave[1383] = 0;
            
            if (ckMileage.Checked)
            {
                //99999 millas
                encSave[100] = 159;
                encSave[101] = 134;
                encSave[102] = 1;
                encSave[103] = 0;
            }

            if (ckItem.Checked)
            {
                encSave[35144] = 1;
                encSave[35145] = 1;
                encSave[35146] = 1;
                encSave[35147] = 1;
                encSave[35148] = 1;

                encSave[35152] = 1;
                encSave[35153] = 1;
                encSave[35154] = 1;
                encSave[35155] = 1;
                encSave[35156] = 1;
            }

            if (ckRootinia.Checked)
            {
                encSave[116] = 4;
                encSave[117] = 204;
            }
            //{
            //    encSave[35192] = 1; //barreras grises
            //}
            if (ckShield.Checked)            
                encSave[35196] = 2; //escudo
            else
                encSave[35196] = 0;

            if (ckBGAOFF.Checked)
                encSave[35200] = 2; //bgaoff for ever
            else
                encSave[35200] = 0;

            if (ck30Time.Checked)
                encSave[35204] = 3; //+30
            else
                encSave[35204] = 0;
            //encSave[108] = 96;
            //encSave[109] = 133;

            //encSave[112] = 177;
            //encSave[113] = 104;
            //encSave[114] = 1;

            //encSave[90508] = 153;

            //encSave[90512] = 232;
            //encSave[90513] = 72;

            //encSave[90516] = 161;
            //encSave[90517] = 10;

            //encSave[90520] = 139;
            //encSave[90521] = 24;

            //encSave[90524] = 148;
            //encSave[90525] = 1;
            // Calculate CRC
            //uint crc = Tools.adler32(encSave, 4, encSave.Length - 4, 1);
            uint crc = MyCRC(encSave);
            //Console.WriteLine("CRC: {0}", crc);
            encSave[0] = (byte)((crc & 0x000000FF) >> 0);
            encSave[1] = (byte)((crc & 0x0000FF00) >> 8);
            encSave[2] = (byte)((crc & 0x00FF0000) >> 16);
            encSave[3] = (byte)((crc & 0xFF000000) >> 24);



            Tools.Encode(encSave);

            //if (NXALoaded)
            {
                File.WriteAllBytes("nxasave.bin", Tools.Combine(uncSave, encSave, new byte[0]));
            }
            MessageBox.Show("Saved\n\nNew File:\t\tTHIS FOLDER\nBackUp:\t\t/BackUp");


            this.Controls.Clear();
            this.InitializeComponent();
        }

        private void ckItem_CheckedChanged(object sender, EventArgs e)
        {
            ckItem.Enabled = false;
        }

        private void ckBarrier_CheckedChanged(object sender, EventArgs e)
        {
            ckBarrier.Enabled = false;
        }

        private void ckMileage_CheckedChanged(object sender, EventArgs e)
        {
            ckMileage.Enabled = false;
        }

        private void ckPath_CheckedChanged(object sender, EventArgs e)
        {
            ckPath.Enabled = false;
        }

        private void ckClear_CheckedChanged(object sender, EventArgs e)
        {
            ckClear.Enabled = false;
        }

        private void ckPortal_CheckedChanged(object sender, EventArgs e)
        {
            ckPortal.Enabled = false;
        }

        private void btnSerial_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To make your USB works with the NXA game the correct USBSerial must be here\nI recommend to use USBDeview.exe to grab the correct USBSerial for your device.");
        }

        private void numAvatar_ValueChanged(object sender, EventArgs e)
        {
            saveAvatar = (int)numAvatar.Value;
            picAvatar.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("CH_" + (saveAvatar + 1).ToString("000"));
        }

        private void CkRootinia_CheckedChanged(object sender, EventArgs e)
        {
            ckRootinia.Enabled = false;
        }
    }
}
