using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using EPDM.Interop.epdm;

namespace BatchAddFolders_CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private IEdmVault5 vault1 = null;
        IEdmBatchAddFolders batchAddFolders;
        EdmFolderInfo[] ppoRetFolders = null;

        int i;

        public void Form1_Load(System.Object sender, System.EventArgs e)
        {
            try
            {
                IEdmVault5 vault1 = new EdmVault5();
                IEdmVault8 vault = (IEdmVault8)vault1;
                EdmViewInfo[] Views = null;

                vault.GetVaultViews(out Views, false);
                VaultsComboBox.Items.Clear();
                foreach (EdmViewInfo View in Views)
                {
                    VaultsComboBox.Items.Add(View.mbsVaultName);
                }
                if (VaultsComboBox.Items.Count > 0)
                {
                    VaultsComboBox.Text = (string)VaultsComboBox.Items[0];
                }

            }
            catch (System.Runtime.InteropServices.COMException ex)
            {
                MessageBox.Show("HRESULT = 0x" + ex.ErrorCode.ToString("X") + " " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void AddFolders_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                IEdmVault7 vault2 = null;
                if (vault1 == null)
                {
                    vault1 = new EdmVault5();
                }
                vault2 = (IEdmVault7)vault1;
                if (!vault1.IsLoggedIn)
                {
                    vault1.LoginAuto(VaultsComboBox.Text, this.Handle.ToInt32());
                }

                if (batchAddFolders == null)
                {
                    batchAddFolders = (IEdmBatchAddFolders)vault2.CreateUtility(EdmUtility.EdmUtil_BatchAddFolders);
                }

                batchAddFolders.AddFolder(vault2.RootFolderID, TextBox1.Text, i, (int)EdmBatchAddFolderFlag.Ebaff_GetInterface, null, 0);
                i = i + 1;

                Interaction.MsgBox(TextBox1.Text + " added to the batch.");
                TextBox1.Clear();

            }
            catch (System.Runtime.InteropServices.COMException ex)
            {
                MessageBox.Show("HRESULT = 0x" + ex.ErrorCode.ToString("X") + " " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void CreateFolders_Click(System.Object sender, System.EventArgs e)
        {

            try
            {
                IEdmVault7 vault2 = null;
                if (vault1 == null)
                {
                    vault1 = new EdmVault5();
                }
                vault2 = (IEdmVault7)vault1;
                if (!vault1.IsLoggedIn)
                {
                    vault1.LoginAuto(VaultsComboBox.Text, this.Handle.ToInt32());
                }

                batchAddFolders.Create(this.Handle.ToInt32(), ref ppoRetFolders, (int)EdmBatchCreateFolderFlag.Ebcf_Nothing);

                foreach (EdmFolderInfo FoldName in ppoRetFolders)
                {
                    Interaction.MsgBox("Created " + FoldName.mbsPath + " successfully" + " in " + vault2.RootFolder.Name);
                }

            }
            catch (System.Runtime.InteropServices.COMException ex)
            {
                MessageBox.Show("HRESULT = 0x" + ex.ErrorCode.ToString("X") + " " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}


