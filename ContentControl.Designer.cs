namespace CrossWordCraft
{
    partial class ContentControl
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
            this.splitter = new System.Windows.Forms.Splitter();
            this.VariantsScrollBar = new System.Windows.Forms.HScrollBar();
            this.labelVariant = new System.Windows.Forms.Label();
            this.MaxVariantsCountcheckBox = new System.Windows.Forms.CheckBox();
            this.MaxVariantsCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.labelVariants = new System.Windows.Forms.Label();
            this.ResultPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.MaxVariantsCountNumericUpDown)).BeginInit();
            this.ResultPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitter
            // 
            this.splitter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter.Location = new System.Drawing.Point(0, -2);
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(307, 2);
            this.splitter.TabIndex = 1;
            this.splitter.TabStop = false;
            // 
            // VariantsScrollBar
            // 
            this.VariantsScrollBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VariantsScrollBar.LargeChange = 1;
            this.VariantsScrollBar.Location = new System.Drawing.Point(0, 52);
            this.VariantsScrollBar.Maximum = 0;
            this.VariantsScrollBar.Name = "VariantsScrollBar";
            this.VariantsScrollBar.Size = new System.Drawing.Size(303, 35);
            this.VariantsScrollBar.TabIndex = 0;
            this.VariantsScrollBar.ValueChanged += new System.EventHandler(this.VariantSelected);
            // 
            // labelVariant
            // 
            this.labelVariant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelVariant.AutoSize = true;
            this.labelVariant.Location = new System.Drawing.Point(1, 36);
            this.labelVariant.Name = "labelVariant";
            this.labelVariant.Size = new System.Drawing.Size(80, 13);
            this.labelVariant.TabIndex = 1;
            this.labelVariant.Text = "Вибір варіанта";
            // 
            // MaxVariantsCountcheckBox
            // 
            this.MaxVariantsCountcheckBox.AutoSize = true;
            this.MaxVariantsCountcheckBox.Checked = true;
            this.MaxVariantsCountcheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MaxVariantsCountcheckBox.Location = new System.Drawing.Point(7, 10);
            this.MaxVariantsCountcheckBox.Name = "MaxVariantsCountcheckBox";
            this.MaxVariantsCountcheckBox.Size = new System.Drawing.Size(94, 17);
            this.MaxVariantsCountcheckBox.TabIndex = 2;
            this.MaxVariantsCountcheckBox.Text = "Шукати перші";
            this.MaxVariantsCountcheckBox.UseVisualStyleBackColor = true;
            this.MaxVariantsCountcheckBox.CheckedChanged += new System.EventHandler(this.MaxVariantsCountcheckBox_CheckedChanged);
            // 
            // MaxVariantsCountNumericUpDown
            // 
            this.MaxVariantsCountNumericUpDown.Location = new System.Drawing.Point(115, 10);
            this.MaxVariantsCountNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.MaxVariantsCountNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MaxVariantsCountNumericUpDown.Name = "MaxVariantsCountNumericUpDown";
            this.MaxVariantsCountNumericUpDown.Size = new System.Drawing.Size(39, 20);
            this.MaxVariantsCountNumericUpDown.TabIndex = 3;
            this.MaxVariantsCountNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // labelVariants
            // 
            this.labelVariants.AutoSize = true;
            this.labelVariants.Location = new System.Drawing.Point(160, 11);
            this.labelVariants.Name = "labelVariants";
            this.labelVariants.Size = new System.Drawing.Size(52, 13);
            this.labelVariants.TabIndex = 4;
            this.labelVariants.Text = "варіантів";
            // 
            // ResultPanel
            // 
            this.ResultPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ResultPanel.Controls.Add(this.labelVariants);
            this.ResultPanel.Controls.Add(this.MaxVariantsCountNumericUpDown);
            this.ResultPanel.Controls.Add(this.MaxVariantsCountcheckBox);
            this.ResultPanel.Controls.Add(this.labelVariant);
            this.ResultPanel.Controls.Add(this.VariantsScrollBar);
            this.ResultPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ResultPanel.Location = new System.Drawing.Point(0, 0);
            this.ResultPanel.Name = "ResultPanel";
            this.ResultPanel.Size = new System.Drawing.Size(307, 91);
            this.ResultPanel.TabIndex = 0;
            // 
            // ContentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitter);
            this.Controls.Add(this.ResultPanel);
            this.Name = "ContentControl";
            this.Size = new System.Drawing.Size(307, 91);
            ((System.ComponentModel.ISupportInitialize)(this.MaxVariantsCountNumericUpDown)).EndInit();
            this.ResultPanel.ResumeLayout(false);
            this.ResultPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Splitter splitter;
        private System.Windows.Forms.HScrollBar VariantsScrollBar;
        private System.Windows.Forms.Label labelVariant;
        private System.Windows.Forms.CheckBox MaxVariantsCountcheckBox;
        private System.Windows.Forms.NumericUpDown MaxVariantsCountNumericUpDown;
        private System.Windows.Forms.Label labelVariants;
        private System.Windows.Forms.Panel ResultPanel;
    }
}
