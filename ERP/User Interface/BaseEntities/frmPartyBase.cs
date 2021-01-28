using System;
using System.Windows.Forms;

namespace Primavera.BaseEntities
{
    public partial class frmPartyBase : Form
    {
        #region Public Methods
        public frmPartyBase()
        {
            InitializeComponent();
        }
        #endregion

        #region Private Methods
        private void frmPartyBase_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void ClearControls()
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is TextBox)
                {
                    (ctl as TextBox).Text = "";
                }
                if (ctl is CheckBox)
                {
                    (ctl as CheckBox).Checked = false;
                }
                if (ctl is ListView)
                {
                    (ctl as ListView).Columns.Clear();
                }
            }
        }

        #endregion

        #region Private Events

        /// <summary>
        /// Close.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        /// <summary>
        /// Create a new party on the system.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmdSave_Click(object sender, EventArgs e)
        {
            this.OnSave();
        }

        /// <summary>
        /// Load the entity data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtName_Validated(object sender, EventArgs e)
        {
            this.OnValidateParty();
        }

        /// <summary>
        /// Create a list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtF4_Click(object sender, EventArgs e)
        {
            this.OnF4Custumer();
        }

        #endregion

        #region Virtual Methods
        public virtual void OnSave()
        {
            this.ClearControls();
        }

        public virtual void OnValidateParty()
        { }

        public virtual void OnF4Custumer()
        { }

        #endregion
    }
}
