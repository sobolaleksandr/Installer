namespace Installer.Dialogs
{
	partial class UninstallDialog
	{
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

	    /// <summary>
	    /// Освободить все используемые ресурсы.
	    /// </summary>
	    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>

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
	    /// Требуемый метод для поддержки конструктора — не изменяйте 
	    /// содержимое этого метода с помощью редактора кода.
	    /// </summary>
        private void InitializeComponent()
		{
            this.imgPanel = new System.Windows.Forms.Panel();
            this.textPanel = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.image = new System.Windows.Forms.PictureBox();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.delete = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.imgPanel.SuspendLayout();
            this.textPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.bottomPanel.SuspendLayout();
            this.table.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgPanel
            // 
            this.imgPanel.Controls.Add(this.textPanel);
            this.imgPanel.Controls.Add(this.image);
            this.imgPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgPanel.Location = new System.Drawing.Point(0, 0);
            this.imgPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imgPanel.Name = "imgPanel";
            this.imgPanel.Size = new System.Drawing.Size(494, 315);
            this.imgPanel.TabIndex = 4;
            // 
            // textPanel
            // 
            this.textPanel.Controls.Add(this.labelTitle);
            this.textPanel.Controls.Add(this.labelDescription);
            this.textPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textPanel.Location = new System.Drawing.Point(234, 0);
            this.textPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textPanel.Name = "textPanel";
            this.textPanel.Size = new System.Drawing.Size(260, 315);
            this.textPanel.TabIndex = 4;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(4, 22);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(247, 94);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "[UninstallDlgTitle]";
            // 
            // labelDescription
            // 
            this.labelDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDescription.BackColor = System.Drawing.Color.Transparent;
            this.labelDescription.Location = new System.Drawing.Point(6, 115);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(245, 190);
            this.labelDescription.TabIndex = 3;
            this.labelDescription.Text = "[UninstallDlgDescription]";
            // 
            // image
            // 
            this.image.BackColor = System.Drawing.Color.White;
            this.image.Dock = System.Windows.Forms.DockStyle.Left;
            this.image.Location = new System.Drawing.Point(0, 0);
            this.image.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.image.Name = "image";
            this.image.Padding = new System.Windows.Forms.Padding(5);
            this.image.Size = new System.Drawing.Size(234, 315);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image.TabIndex = 0;
            this.image.TabStop = false;
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.SystemColors.Control;
            this.bottomPanel.Controls.Add(this.table);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 315);
            this.bottomPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(494, 46);
            this.bottomPanel.TabIndex = 1;
            // 
            // table
            // 
            this.table.ColumnCount = 5;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.table.Controls.Add(this.delete, 2, 0);
            this.table.Controls.Add(this.cancel, 4, 0);
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.table.Name = "table";
            this.table.RowCount = 1;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table.Size = new System.Drawing.Size(494, 46);
            this.table.TabIndex = 6;
            // 
            // delete
            // 
            this.delete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.delete.AutoSize = true;
            this.delete.Location = new System.Drawing.Point(227, 8);
            this.delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.delete.MinimumSize = new System.Drawing.Size(112, 0);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(116, 30);
            this.delete.TabIndex = 0;
            this.delete.Text = "[WixUIDelete]";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.Delete);
            // 
            // cancel
            // 
            this.cancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cancel.AutoSize = true;
            this.cancel.Location = new System.Drawing.Point(372, 8);
            this.cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancel.MinimumSize = new System.Drawing.Size(112, 0);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(118, 30);
            this.cancel.TabIndex = 0;
            this.cancel.Text = "[WixUICancel]";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.Cancel);
            // 
            // UninstallDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(494, 361);
            this.Controls.Add(this.imgPanel);
            this.Controls.Add(this.bottomPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UninstallDialog";
            this.Text = "[UninstallDlg_Title]";
            this.imgPanel.ResumeLayout(false);
            this.textPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            this.table.ResumeLayout(false);
            this.table.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox image;
		private System.Windows.Forms.Panel bottomPanel;
		private System.Windows.Forms.Button delete;
		private System.Windows.Forms.Button cancel;
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.Label labelDescription;
		private System.Windows.Forms.Panel imgPanel;
		private System.Windows.Forms.TableLayoutPanel table;
		private System.Windows.Forms.Panel textPanel;
	}
}