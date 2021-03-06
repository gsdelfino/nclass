namespace NClass.DiagramEditor.ClassDiagram.Editors
{
	partial class ClassTypeEditor
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.lblStereotype = new System.Windows.Forms.Label();
            this.txtStereotype = new NClass.DiagramEditor.ClassDiagram.Editors.BorderedTextBox();
            this.pnlAdvancedOptions = new System.Windows.Forms.Panel();
            this.cboIdentityGenerator = new System.Windows.Forms.ComboBox();
            this.txtNHMTableName = new NClass.DiagramEditor.ClassDiagram.Editors.BorderedTextBox();
            this.lblNHMTableName = new System.Windows.Forms.Label();
            this.lblIdentityGenerator = new System.Windows.Forms.Label();
            this.toolStripAdvancedOptions = new System.Windows.Forms.ToolStrip();
            this.toolAdvancedOptions = new System.Windows.Forms.ToolStripButton();
            this.pnlGeneratorParameters = new System.Windows.Forms.Panel();
            this.prgGeneratorParameters = new System.Windows.Forms.PropertyGrid();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlAdvancedOptions.SuspendLayout();
            this.toolStripAdvancedOptions.SuspendLayout();
            this.pnlGeneratorParameters.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Size = new System.Drawing.Size(298, 20);
            // 
            // lblStereotype
            // 
            this.lblStereotype.AutoSize = true;
            this.lblStereotype.Location = new System.Drawing.Point(-2, 4);
            this.lblStereotype.Name = "lblStereotype";
            this.lblStereotype.Size = new System.Drawing.Size(61, 13);
            this.lblStereotype.TabIndex = 10;
            this.lblStereotype.Text = "Stereotype:";
            // 
            // txtStereotype
            // 
            this.txtStereotype.Location = new System.Drawing.Point(59, 1);
            this.txtStereotype.Name = "txtStereotype";
            this.txtStereotype.Padding = new System.Windows.Forms.Padding(1);
            this.txtStereotype.ReadOnly = false;
            this.txtStereotype.SelectionStart = 0;
            this.txtStereotype.Size = new System.Drawing.Size(240, 20);
            this.txtStereotype.TabIndex = 9;
            this.txtStereotype.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStereotype_KeyDown);
            this.txtStereotype.Validating += new System.ComponentModel.CancelEventHandler(this.txtStereotype_Validating);
            // 
            // pnlAdvancedOptions
            // 
            this.pnlAdvancedOptions.Controls.Add(this.cboIdentityGenerator);
            this.pnlAdvancedOptions.Controls.Add(this.txtNHMTableName);
            this.pnlAdvancedOptions.Controls.Add(this.lblNHMTableName);
            this.pnlAdvancedOptions.Controls.Add(this.lblStereotype);
            this.pnlAdvancedOptions.Controls.Add(this.txtStereotype);
            this.pnlAdvancedOptions.Controls.Add(this.lblIdentityGenerator);
            this.pnlAdvancedOptions.Location = new System.Drawing.Point(3, 52);
            this.pnlAdvancedOptions.Name = "pnlAdvancedOptions";
            this.pnlAdvancedOptions.Size = new System.Drawing.Size(323, 77);
            this.pnlAdvancedOptions.TabIndex = 12;
            // 
            // cboIdentityGenerator
            // 
            this.cboIdentityGenerator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdentityGenerator.FormattingEnabled = true;
            this.cboIdentityGenerator.Location = new System.Drawing.Point(148, 53);
            this.cboIdentityGenerator.Name = "cboIdentityGenerator";
            this.cboIdentityGenerator.Size = new System.Drawing.Size(110, 21);
            this.cboIdentityGenerator.TabIndex = 12;
            this.cboIdentityGenerator.SelectedIndexChanged += new System.EventHandler(this.cboIdGenerator_SelectedIndexChanged);
            // 
            // txtNHMTableName
            // 
            this.txtNHMTableName.Location = new System.Drawing.Point(59, 27);
            this.txtNHMTableName.Name = "txtNHMTableName";
            this.txtNHMTableName.Padding = new System.Windows.Forms.Padding(1);
            this.txtNHMTableName.ReadOnly = false;
            this.txtNHMTableName.SelectionStart = 0;
            this.txtNHMTableName.Size = new System.Drawing.Size(240, 20);
            this.txtNHMTableName.TabIndex = 10;
            this.txtNHMTableName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.borderedTextBox1_KeyDown);
            this.txtNHMTableName.Validating += new System.ComponentModel.CancelEventHandler(this.borderedTextBox1_Validating);
            // 
            // lblNHMTableName
            // 
            this.lblNHMTableName.AutoSize = true;
            this.lblNHMTableName.Location = new System.Drawing.Point(-3, 31);
            this.lblNHMTableName.Name = "lblNHMTableName";
            this.lblNHMTableName.Size = new System.Drawing.Size(65, 13);
            this.lblNHMTableName.TabIndex = 10;
            this.lblNHMTableName.Text = "NHM Table:";
            // 
            // lblIdentityGenerator
            // 
            this.lblIdentityGenerator.AutoSize = true;
            this.lblIdentityGenerator.Location = new System.Drawing.Point(56, 56);
            this.lblIdentityGenerator.Name = "lblIdentityGenerator";
            this.lblIdentityGenerator.Size = new System.Drawing.Size(94, 13);
            this.lblIdentityGenerator.TabIndex = 13;
            this.lblIdentityGenerator.Text = "Identity Generator:";
            // 
            // toolStripAdvancedOptions
            // 
            this.toolStripAdvancedOptions.AutoSize = false;
            this.toolStripAdvancedOptions.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripAdvancedOptions.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripAdvancedOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolAdvancedOptions});
            this.toolStripAdvancedOptions.Location = new System.Drawing.Point(304, 26);
            this.toolStripAdvancedOptions.Name = "toolStripAdvancedOptions";
            this.toolStripAdvancedOptions.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripAdvancedOptions.Size = new System.Drawing.Size(25, 25);
            this.toolStripAdvancedOptions.TabIndex = 0;
            // 
            // toolAdvancedOptions
            // 
            this.toolAdvancedOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolAdvancedOptions.Image = global::NClass.DiagramEditor.Properties.Resources.ExpandSingle;
            this.toolAdvancedOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAdvancedOptions.Name = "toolAdvancedOptions";
            this.toolAdvancedOptions.Size = new System.Drawing.Size(23, 22);
            this.toolAdvancedOptions.Click += new System.EventHandler(this.toolAdvancedOptions_Click);
            // 
            // pnlGeneratorParameters
            // 
            this.pnlGeneratorParameters.Controls.Add(this.prgGeneratorParameters);
            this.pnlGeneratorParameters.Controls.Add(this.label3);
            this.pnlGeneratorParameters.Location = new System.Drawing.Point(3, 132);
            this.pnlGeneratorParameters.Name = "pnlGeneratorParameters";
            this.pnlGeneratorParameters.Size = new System.Drawing.Size(323, 50);
            this.pnlGeneratorParameters.TabIndex = 13;
            // 
            // prgGeneratorParameters
            // 
            this.prgGeneratorParameters.HelpVisible = false;
            this.prgGeneratorParameters.Location = new System.Drawing.Point(59, 0);
            this.prgGeneratorParameters.Name = "prgGeneratorParameters";
            this.prgGeneratorParameters.Size = new System.Drawing.Size(240, 47);
            this.prgGeneratorParameters.TabIndex = 14;
            this.prgGeneratorParameters.ToolbarVisible = false;
            this.prgGeneratorParameters.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.prgGeneratorParameters_PropertyValueChanged);
            this.prgGeneratorParameters.Validating += new System.ComponentModel.CancelEventHandler(this.prgGeneratorParameters_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Identity Generator:";
            // 
            // ClassTypeEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlGeneratorParameters);
            this.Controls.Add(this.pnlAdvancedOptions);
            this.Controls.Add(this.toolStripAdvancedOptions);
            this.Name = "ClassTypeEditor";
            this.Size = new System.Drawing.Size(330, 186);
            this.Controls.SetChildIndex(this.toolStripAdvancedOptions, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.pnlAdvancedOptions, 0);
            this.Controls.SetChildIndex(this.pnlGeneratorParameters, 0);
            this.pnlAdvancedOptions.ResumeLayout(false);
            this.pnlAdvancedOptions.PerformLayout();
            this.toolStripAdvancedOptions.ResumeLayout(false);
            this.toolStripAdvancedOptions.PerformLayout();
            this.pnlGeneratorParameters.ResumeLayout(false);
            this.pnlGeneratorParameters.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblStereotype;
		private BorderedTextBox txtStereotype;
		private System.Windows.Forms.Panel pnlAdvancedOptions;
		private System.Windows.Forms.ToolStrip toolStripAdvancedOptions;
		private System.Windows.Forms.ToolStripButton toolAdvancedOptions;
        private System.Windows.Forms.Label lblNHMTableName;
        private BorderedTextBox txtNHMTableName;
        private System.Windows.Forms.ComboBox cboIdentityGenerator;
        private System.Windows.Forms.Label lblIdentityGenerator;
        private System.Windows.Forms.Panel pnlGeneratorParameters;
        private System.Windows.Forms.PropertyGrid prgGeneratorParameters;
        private System.Windows.Forms.Label label3;
	}
}
