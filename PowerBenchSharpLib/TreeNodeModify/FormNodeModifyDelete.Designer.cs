﻿namespace PowerBenchSharpLib
{
    partial class FormNodeModifyDelete
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param _name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.button_OK = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.editField1 = new PowerBenchSharpLib.EditField();
            this.comboField_phase = new PowerBenchSharpLib.ComboField();
            this.SuspendLayout();
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(242, 353);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 0;
            this.button_OK.Text = "修改";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(407, 353);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 1;
            this.button_Cancel.Text = "取消";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Top;
            this.propertyGrid1.Location = new System.Drawing.Point(0, 0);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(546, 253);
            this.propertyGrid1.TabIndex = 5;
            // 
            // editField1
            // 
            this.editField1.EnableEmpty = false;
            this.editField1.Location = new System.Drawing.Point(12, 272);
            this.editField1.Name = "editField1";
            this.editField1.PropertyLableLen = 0;
            this.editField1.ReadOnly = false;
            this.editField1.Size = new System.Drawing.Size(305, 28);
            this.editField1.TabIndex = 4;
            // 
            // comboField_phase
            // 
            
            this.comboField_phase.Location = new System.Drawing.Point(12, 319);
            this.comboField_phase.Name = "editField_phase";
            
            this.comboField_phase.ReadOnly = false;
            this.comboField_phase.Size = new System.Drawing.Size(305, 28);
            this.comboField_phase.TabIndex = 6;
            // 
            // FormNodeModifyDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 394);
            this.Controls.Add(this.comboField_phase);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.editField1);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormNodeModifyDelete";
            this.Text = "修改节点信息";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_Cancel;
        private EditField editField1;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private ComboField comboField_phase;
    }
}