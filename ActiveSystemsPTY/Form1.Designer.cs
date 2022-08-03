namespace ActiveSystemsPTY
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ListBoxVehicleDetails = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxVehicleDetails = new System.Windows.Forms.TextBox();
            this.ButtonEnter = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.ButtonTAG = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonOPEN = new System.Windows.Forms.Button();
            this.ButtonBinarySearch = new System.Windows.Forms.Button();
            this.ButtonLinearSearch = new System.Windows.Forms.Button();
            this.ButtonReset = new System.Windows.Forms.Button();
            this.StatusMsg = new System.Windows.Forms.StatusStrip();
            this.toolTip_ListBoxVehicleDetails = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_TextBoxVehicleDetails = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_ButtonOPEN = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_ButtonEnter = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_ButtonExit = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_ButtonTAG = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_ButtonSave = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_ButtonBinarySearch = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_ButtonLinearSearch = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_ButtonReset = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // ListBoxVehicleDetails
            // 
            this.ListBoxVehicleDetails.FormattingEnabled = true;
            this.ListBoxVehicleDetails.ItemHeight = 16;
            this.ListBoxVehicleDetails.Location = new System.Drawing.Point(24, 20);
            this.ListBoxVehicleDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListBoxVehicleDetails.Name = "ListBoxVehicleDetails";
            this.ListBoxVehicleDetails.Size = new System.Drawing.Size(152, 388);
            this.ListBoxVehicleDetails.TabIndex = 0;
            this.ListBoxVehicleDetails.Click += new System.EventHandler(this.ListBoxVehicleDetails_Click);
            this.ListBoxVehicleDetails.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListBoxVehicleDetails_doubleClick);
            this.ListBoxVehicleDetails.MouseHover += new System.EventHandler(this.ListBoxVehicleDetails_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vehicle Plate Details";
            // 
            // TextBoxVehicleDetails
            // 
            this.TextBoxVehicleDetails.Location = new System.Drawing.Point(224, 52);
            this.TextBoxVehicleDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxVehicleDetails.Name = "TextBoxVehicleDetails";
            this.TextBoxVehicleDetails.Size = new System.Drawing.Size(143, 22);
            this.TextBoxVehicleDetails.TabIndex = 2;
            this.TextBoxVehicleDetails.MouseHover += new System.EventHandler(this.TextBoxVehicleDetails_MouseHover);
            // 
            // ButtonEnter
            // 
            this.ButtonEnter.Location = new System.Drawing.Point(253, 98);
            this.ButtonEnter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonEnter.Name = "ButtonEnter";
            this.ButtonEnter.Size = new System.Drawing.Size(75, 23);
            this.ButtonEnter.TabIndex = 3;
            this.ButtonEnter.Text = "Enter";
            this.ButtonEnter.UseVisualStyleBackColor = true;
            this.ButtonEnter.Click += new System.EventHandler(this.ButtonEnter_Click);
            this.ButtonEnter.MouseHover += new System.EventHandler(this.ButtonEnter_MouseHover);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Location = new System.Drawing.Point(253, 142);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(75, 23);
            this.ButtonExit.TabIndex = 4;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            this.ButtonExit.MouseHover += new System.EventHandler(this.ButtonExit_MouseHover);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Location = new System.Drawing.Point(253, 185);
            this.ButtonEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(75, 23);
            this.ButtonEdit.TabIndex = 5;
            this.ButtonEdit.Text = "Edit";
            this.ButtonEdit.UseVisualStyleBackColor = true;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // ButtonTAG
            // 
            this.ButtonTAG.Location = new System.Drawing.Point(253, 230);
            this.ButtonTAG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonTAG.Name = "ButtonTAG";
            this.ButtonTAG.Size = new System.Drawing.Size(75, 23);
            this.ButtonTAG.TabIndex = 6;
            this.ButtonTAG.Text = "TAG";
            this.ButtonTAG.UseVisualStyleBackColor = true;
            this.ButtonTAG.Click += new System.EventHandler(this.ButtonTAG_Click);
            this.ButtonTAG.MouseHover += new System.EventHandler(this.ButtonTAG_MouseHover);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(253, 352);
            this.ButtonSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(75, 23);
            this.ButtonSave.TabIndex = 7;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            this.ButtonSave.MouseHover += new System.EventHandler(this.ButtonSave_MouseHover);
            // 
            // ButtonOPEN
            // 
            this.ButtonOPEN.Location = new System.Drawing.Point(432, 52);
            this.ButtonOPEN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonOPEN.Name = "ButtonOPEN";
            this.ButtonOPEN.Size = new System.Drawing.Size(75, 23);
            this.ButtonOPEN.TabIndex = 8;
            this.ButtonOPEN.Text = "OPEN";
            this.ButtonOPEN.UseVisualStyleBackColor = true;
            this.ButtonOPEN.Click += new System.EventHandler(this.ButtonOPEN_Click);
            this.ButtonOPEN.MouseHover += new System.EventHandler(this.ButtonOPEN_MouseHover);
            // 
            // ButtonBinarySearch
            // 
            this.ButtonBinarySearch.Location = new System.Drawing.Point(445, 185);
            this.ButtonBinarySearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonBinarySearch.Name = "ButtonBinarySearch";
            this.ButtonBinarySearch.Size = new System.Drawing.Size(113, 23);
            this.ButtonBinarySearch.TabIndex = 9;
            this.ButtonBinarySearch.Text = "Binary Search";
            this.ButtonBinarySearch.UseVisualStyleBackColor = true;
            this.ButtonBinarySearch.Click += new System.EventHandler(this.ButtonBinarySearch_Click);
            this.ButtonBinarySearch.MouseHover += new System.EventHandler(this.ButtonBinarySearch_MouseHover);
            // 
            // ButtonLinearSearch
            // 
            this.ButtonLinearSearch.Location = new System.Drawing.Point(445, 230);
            this.ButtonLinearSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonLinearSearch.Name = "ButtonLinearSearch";
            this.ButtonLinearSearch.Size = new System.Drawing.Size(113, 23);
            this.ButtonLinearSearch.TabIndex = 10;
            this.ButtonLinearSearch.Text = "Linear Search";
            this.ButtonLinearSearch.UseVisualStyleBackColor = true;
            this.ButtonLinearSearch.Click += new System.EventHandler(this.ButtonLinearSearch_Click);
            this.ButtonLinearSearch.MouseHover += new System.EventHandler(this.ButtonLinearSearch_MouseHover);
            // 
            // ButtonReset
            // 
            this.ButtonReset.Location = new System.Drawing.Point(456, 352);
            this.ButtonReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(75, 23);
            this.ButtonReset.TabIndex = 11;
            this.ButtonReset.Text = "Reset";
            this.ButtonReset.UseVisualStyleBackColor = true;
            this.ButtonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            this.ButtonReset.MouseHover += new System.EventHandler(this.ButtonReset_MouseHover);
            // 
            // StatusMsg
            // 
            this.StatusMsg.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusMsg.Location = new System.Drawing.Point(0, 444);
            this.StatusMsg.Name = "StatusMsg";
            this.StatusMsg.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.StatusMsg.Size = new System.Drawing.Size(739, 22);
            this.StatusMsg.TabIndex = 12;
            this.StatusMsg.Text = "statusStrip1";
            // 
            // toolTip_ButtonReset
            // 
            this.toolTip_ButtonReset.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 466);
            this.Controls.Add(this.StatusMsg);
            this.Controls.Add(this.ButtonReset);
            this.Controls.Add(this.ButtonLinearSearch);
            this.Controls.Add(this.ButtonBinarySearch);
            this.Controls.Add(this.ButtonOPEN);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonTAG);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ButtonEnter);
            this.Controls.Add(this.TextBoxVehicleDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListBoxVehicleDetails);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Vehicle Registration Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseForm_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxVehicleDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxVehicleDetails;
        private System.Windows.Forms.Button ButtonEnter;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.Button ButtonTAG;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonOPEN;
        private System.Windows.Forms.Button ButtonBinarySearch;
        private System.Windows.Forms.Button ButtonLinearSearch;
        private System.Windows.Forms.Button ButtonReset;
        private System.Windows.Forms.StatusStrip StatusMsg;
        private System.Windows.Forms.ToolTip toolTip_ListBoxVehicleDetails;
        private System.Windows.Forms.ToolTip toolTip_TextBoxVehicleDetails;
        private System.Windows.Forms.ToolTip toolTip_ButtonOPEN;
        private System.Windows.Forms.ToolTip toolTip_ButtonEnter;
        private System.Windows.Forms.ToolTip toolTip_ButtonExit;
        private System.Windows.Forms.ToolTip toolTip_ButtonTAG;
        private System.Windows.Forms.ToolTip toolTip_ButtonSave;
        private System.Windows.Forms.ToolTip toolTip_ButtonBinarySearch;
        private System.Windows.Forms.ToolTip toolTip_ButtonLinearSearch;
        private System.Windows.Forms.ToolTip toolTip_ButtonReset;
    }
}

