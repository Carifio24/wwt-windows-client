namespace TerraViewer
{
    partial class DataWizardColorMap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataWizardColorMap));
            this.ColorMapTypeLabel = new System.Windows.Forms.Label();
            this.ColorMapType = new TerraViewer.WwtCombo();
            this.ColorMapColumn = new TerraViewer.WwtCombo();
            this.label1 = new System.Windows.Forms.Label();
            this.domainList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ColorMapName = new TerraViewer.WwtCombo();
            this.label4 = new System.Windows.Forms.Label();
            this.Normalization = new TerraViewer.WwtCombo();
            this.SuspendLayout();
            // 
            // ColorMapTypeLabel
            // 
            this.ColorMapTypeLabel.AutoSize = true;
            this.ColorMapTypeLabel.Location = new System.Drawing.Point(17, 85);
            this.ColorMapTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ColorMapTypeLabel.Name = "ColorMapTypeLabel";
            this.ColorMapTypeLabel.Size = new System.Drawing.Size(104, 16);
            this.ColorMapTypeLabel.TabIndex = 1;
            this.ColorMapTypeLabel.Text = "Color Map Type";
            // 
            // ColorMapType
            // 
            this.ColorMapType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.ColorMapType.DateTimeValue = new System.DateTime(2009, 12, 11, 8, 2, 12, 711);
            this.ColorMapType.Filter = TerraViewer.Classification.Unfiltered;
            this.ColorMapType.FilterStyle = false;
            this.ColorMapType.Location = new System.Drawing.Point(21, 105);
            this.ColorMapType.Margin = new System.Windows.Forms.Padding(0);
            this.ColorMapType.MasterTime = true;
            this.ColorMapType.MaximumSize = new System.Drawing.Size(331, 41);
            this.ColorMapType.MinimumSize = new System.Drawing.Size(47, 41);
            this.ColorMapType.Name = "ColorMapType";
            this.ColorMapType.SelectedIndex = -1;
            this.ColorMapType.SelectedItem = null;
            this.ColorMapType.Size = new System.Drawing.Size(168, 41);
            this.ColorMapType.State = TerraViewer.State.Rest;
            this.ColorMapType.TabIndex = 2;
            this.ColorMapType.Type = TerraViewer.WwtCombo.ComboType.List;
            this.ColorMapType.SelectionChanged += new TerraViewer.SelectionChangedEventHandler(this.ColorMapType_SelectionChanged);
            // 
            // ColorMapColumn
            // 
            this.ColorMapColumn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.ColorMapColumn.DateTimeValue = new System.DateTime(2009, 12, 11, 8, 2, 12, 711);
            this.ColorMapColumn.Filter = TerraViewer.Classification.Unfiltered;
            this.ColorMapColumn.FilterStyle = false;
            this.ColorMapColumn.Location = new System.Drawing.Point(211, 105);
            this.ColorMapColumn.Margin = new System.Windows.Forms.Padding(0);
            this.ColorMapColumn.MasterTime = true;
            this.ColorMapColumn.MaximumSize = new System.Drawing.Size(331, 41);
            this.ColorMapColumn.MinimumSize = new System.Drawing.Size(47, 41);
            this.ColorMapColumn.Name = "ColorMapColumn";
            this.ColorMapColumn.SelectedIndex = -1;
            this.ColorMapColumn.SelectedItem = null;
            this.ColorMapColumn.Size = new System.Drawing.Size(168, 41);
            this.ColorMapColumn.State = TerraViewer.State.Rest;
            this.ColorMapColumn.TabIndex = 4;
            this.ColorMapColumn.Type = TerraViewer.WwtCombo.ComboType.List;
            this.ColorMapColumn.SelectionChanged += new TerraViewer.SelectionChangedEventHandler(this.ColorMapColumn_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Color Map Column";
            // 
            // domainList
            // 
            this.domainList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(105)))));
            this.domainList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.domainList.ForeColor = System.Drawing.Color.White;
            this.domainList.FormattingEnabled = true;
            this.domainList.ItemHeight = 36;
            this.domainList.Location = new System.Drawing.Point(531, 85);
            this.domainList.Margin = new System.Windows.Forms.Padding(4);
            this.domainList.Name = "domainList";
            this.domainList.Size = new System.Drawing.Size(371, 148);
            this.domainList.TabIndex = 5;
            this.domainList.Visible = false;
            this.domainList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem);
            this.domainList.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.listBox1_MeasureItem);
            this.domainList.SelectedIndexChanged += new System.EventHandler(this.domainList_SelectedIndexChanged);
            this.domainList.DoubleClick += new System.EventHandler(this.domainList_DoubleClick);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(17, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(873, 47);
            this.label2.TabIndex = 0;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Color Map";
            // 
            // ColorMapName
            // 
            this.ColorMapName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.ColorMapName.DateTimeValue = new System.DateTime(2009, 12, 11, 8, 2, 12, 711);
            this.ColorMapName.Filter = TerraViewer.Classification.Unfiltered;
            this.ColorMapName.FilterStyle = false;
            this.ColorMapName.Location = new System.Drawing.Point(21, 177);
            this.ColorMapName.Margin = new System.Windows.Forms.Padding(0);
            this.ColorMapName.MasterTime = true;
            this.ColorMapName.MaximumSize = new System.Drawing.Size(331, 41);
            this.ColorMapName.MinimumSize = new System.Drawing.Size(47, 41);
            this.ColorMapName.Name = "ColorMapName";
            this.ColorMapName.SelectedIndex = -1;
            this.ColorMapName.SelectedItem = null;
            this.ColorMapName.Size = new System.Drawing.Size(168, 41);
            this.ColorMapName.State = TerraViewer.State.Rest;
            this.ColorMapName.TabIndex = 7;
            this.ColorMapName.Type = TerraViewer.WwtCombo.ComboType.List;
            this.ColorMapName.SelectionChanged += new TerraViewer.SelectionChangedEventHandler(this.ColorMapName_SelectionChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 161);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Normalization";
            // 
            // Normalization
            // 
            this.Normalization.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.Normalization.DateTimeValue = new System.DateTime(2009, 12, 11, 8, 2, 12, 711);
            this.Normalization.Filter = TerraViewer.Classification.Unfiltered;
            this.Normalization.FilterStyle = false;
            this.Normalization.Location = new System.Drawing.Point(211, 177);
            this.Normalization.Margin = new System.Windows.Forms.Padding(0);
            this.Normalization.MasterTime = true;
            this.Normalization.MaximumSize = new System.Drawing.Size(331, 41);
            this.Normalization.MinimumSize = new System.Drawing.Size(47, 41);
            this.Normalization.Name = "Normalization";
            this.Normalization.SelectedIndex = -1;
            this.Normalization.SelectedItem = null;
            this.Normalization.Size = new System.Drawing.Size(168, 41);
            this.Normalization.State = TerraViewer.State.Rest;
            this.Normalization.TabIndex = 9;
            this.Normalization.Type = TerraViewer.WwtCombo.ComboType.List;
            this.Normalization.SelectionChanged += new TerraViewer.SelectionChangedEventHandler(this.Normalization_SelectionChanged);
            // 
            // DataWizardColorMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Normalization);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ColorMapName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.domainList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ColorMapTypeLabel);
            this.Controls.Add(this.ColorMapColumn);
            this.Controls.Add(this.ColorMapType);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(920, 283);
            this.Name = "DataWizardColorMap";
            this.Size = new System.Drawing.Size(920, 283);
            this.Load += new System.EventHandler(this.DataWizardColorMap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ColorMapTypeLabel;
        private WwtCombo ColorMapType;
        private WwtCombo ColorMapColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox domainList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private WwtCombo ColorMapName;
        private System.Windows.Forms.Label label4;
        private WwtCombo Normalization;
    }
}
