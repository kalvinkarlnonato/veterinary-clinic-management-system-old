﻿namespace AppUI
{
    partial class VisitsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisitsForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cellphone = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.petGroup = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sex = new System.Windows.Forms.Label();
            this.petName = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.breed = new System.Windows.Forms.Label();
            this.species = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.notes = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.colorMarking = new System.Windows.Forms.Label();
            this.visitContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitsData = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientGroup = new System.Windows.Forms.GroupBox();
            this.pic = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.petGroup.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.visitContext.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitsData)).BeginInit();
            this.clientGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 899F));
            this.tableLayoutPanel1.Controls.Add(this.cellphone, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.address, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.name, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.nameLabel, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(62, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1088, 40);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // cellphone
            // 
            this.cellphone.AutoSize = true;
            this.cellphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellphone.Location = new System.Drawing.Point(241, 0);
            this.cellphone.Name = "cellphone";
            this.cellphone.Size = new System.Drawing.Size(148, 20);
            this.cellphone.TabIndex = 4;
            this.cellphone.Text = "[Cellphone Number]";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(81, 20);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(76, 20);
            this.address.TabIndex = 4;
            this.address.Text = "[Address]";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(163, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "CP#:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Address:";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(81, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(69, 20);
            this.name.TabIndex = 4;
            this.name.Text = "<Name>";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(3, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(55, 20);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // petGroup
            // 
            this.petGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.petGroup.Controls.Add(this.tableLayoutPanel2);
            this.petGroup.Location = new System.Drawing.Point(12, 104);
            this.petGroup.Name = "petGroup";
            this.petGroup.Size = new System.Drawing.Size(1156, 94);
            this.petGroup.TabIndex = 12;
            this.petGroup.TabStop = false;
            this.petGroup.Text = "Patient\'s Information";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.label5, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.sex, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.petName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label10, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.breed, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.species, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label8, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.age, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.notes, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.label7, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.colorMarking, 5, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 26);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1144, 60);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(170, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Note:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pet name:";
            // 
            // sex
            // 
            this.sex.AutoSize = true;
            this.sex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sex.Location = new System.Drawing.Point(244, 20);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(44, 20);
            this.sex.TabIndex = 4;
            this.sex.Text = "[Sex]";
            // 
            // petName
            // 
            this.petName.AutoSize = true;
            this.petName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petName.Location = new System.Drawing.Point(90, 0);
            this.petName.Name = "petName";
            this.petName.Size = new System.Drawing.Size(41, 20);
            this.petName.TabIndex = 4;
            this.petName.Text = "[Pet]";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(170, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "Sex:";
            // 
            // breed
            // 
            this.breed.AutoSize = true;
            this.breed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breed.Location = new System.Drawing.Point(90, 20);
            this.breed.Name = "breed";
            this.breed.Size = new System.Drawing.Size(60, 20);
            this.breed.TabIndex = 4;
            this.breed.Text = "[Breed]";
            // 
            // species
            // 
            this.species.AutoSize = true;
            this.species.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.species.Location = new System.Drawing.Point(90, 40);
            this.species.Name = "species";
            this.species.Size = new System.Drawing.Size(74, 20);
            this.species.TabIndex = 4;
            this.species.Text = "[Species]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Breed:";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(170, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Age:";
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age.Location = new System.Drawing.Point(244, 0);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(46, 20);
            this.age.TabIndex = 4;
            this.age.Text = "[Age]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Species:";
            // 
            // notes
            // 
            this.notes.AutoSize = true;
            this.notes.Location = new System.Drawing.Point(244, 40);
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(131, 20);
            this.notes.TabIndex = 5;
            this.notes.Text = "<READ NOTES>";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(381, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Color Marking:";
            // 
            // colorMarking
            // 
            this.colorMarking.AutoSize = true;
            this.colorMarking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorMarking.Location = new System.Drawing.Point(513, 0);
            this.colorMarking.Name = "colorMarking";
            this.colorMarking.Size = new System.Drawing.Size(54, 20);
            this.colorMarking.TabIndex = 5;
            this.colorMarking.Text = "[Color]";
            // 
            // visitContext
            // 
            this.visitContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.selectAllToolStripMenuItem});
            this.visitContext.Name = "visitContext";
            this.visitContext.Size = new System.Drawing.Size(121, 92);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.selectAllToolStripMenuItem.Text = "Select all";
            // 
            // visitsData
            // 
            this.visitsData.AllowUserToAddRows = false;
            this.visitsData.AllowUserToDeleteRows = false;
            this.visitsData.AllowUserToResizeRows = false;
            this.visitsData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.visitsData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.visitsData.BackgroundColor = System.Drawing.Color.White;
            this.visitsData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.visitsData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.visitsData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.visitsData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.visitsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visitsData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.visitsData.GridColor = System.Drawing.Color.LightGray;
            this.visitsData.Location = new System.Drawing.Point(12, 198);
            this.visitsData.Name = "visitsData";
            this.visitsData.ReadOnly = true;
            this.visitsData.RowHeadersVisible = false;
            this.visitsData.RowTemplate.ContextMenuStrip = this.visitContext;
            this.visitsData.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.visitsData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.visitsData.Size = new System.Drawing.Size(1156, 406);
            this.visitsData.TabIndex = 13;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Date";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 180;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "WT./T.";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 170;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Complaint/Diagnosis";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 270;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Treatment";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 270;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Notes";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 200;
            // 
            // Column6
            // 
            dataGridViewCellStyle2.NullValue = "No appointment";
            this.Column6.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column6.HeaderText = "Followup";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 180;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Payment";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = " ";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column8.Width = 500;
            // 
            // clientGroup
            // 
            this.clientGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientGroup.Controls.Add(this.tableLayoutPanel1);
            this.clientGroup.Controls.Add(this.pic);
            this.clientGroup.Location = new System.Drawing.Point(12, 24);
            this.clientGroup.Name = "clientGroup";
            this.clientGroup.Size = new System.Drawing.Size(1156, 74);
            this.clientGroup.TabIndex = 11;
            this.clientGroup.TabStop = false;
            this.clientGroup.Text = "Client\'s Information";
            // 
            // pic
            // 
            this.pic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic.BackgroundImage")));
            this.pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic.Location = new System.Drawing.Point(6, 19);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(50, 50);
            this.pic.TabIndex = 7;
            this.pic.TabStop = false;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.closeButton.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(1130, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(50, 28);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "✕";
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // VisitsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1180, 616);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.petGroup);
            this.Controls.Add(this.clientGroup);
            this.Controls.Add(this.visitsData);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "VisitsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VisitsForm";
            this.Load += new System.EventHandler(this.VisitsForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.petGroup.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.visitContext.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.visitsData)).EndInit();
            this.clientGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label cellphone;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.GroupBox petGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sex;
        private System.Windows.Forms.Label petName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label breed;
        private System.Windows.Forms.Label species;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label notes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label colorMarking;
        private System.Windows.Forms.ContextMenuStrip visitContext;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.DataGridView visitsData;
        private System.Windows.Forms.GroupBox clientGroup;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}