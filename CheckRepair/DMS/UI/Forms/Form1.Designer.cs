﻿namespace DMS.UI.Forms
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
            this.txPanel1 = new TX.Framework.WindowUI.Controls.TXPanel();
            this.txButtonComplete = new TX.Framework.WindowUI.Controls.TXButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelD1 = new System.Windows.Forms.Label();
            this.tbD1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.txPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txPanel1
            // 
            this.txPanel1.BackColor = System.Drawing.Color.Transparent;
            this.txPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.txPanel1.Controls.Add(this.txButtonComplete);
            this.txPanel1.Controls.Add(this.tableLayoutPanel1);
            this.txPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txPanel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txPanel1.Location = new System.Drawing.Point(3, 27);
            this.txPanel1.Name = "txPanel1";
            this.txPanel1.Size = new System.Drawing.Size(971, 275);
            this.txPanel1.TabIndex = 0;
            // 
            // txButtonComplete
            // 
            this.txButtonComplete.Image = null;
            this.txButtonComplete.Location = new System.Drawing.Point(8, 235);
            this.txButtonComplete.Name = "txButtonComplete";
            this.txButtonComplete.Size = new System.Drawing.Size(100, 28);
            this.txButtonComplete.TabIndex = 10;
            this.txButtonComplete.Text = "完  成";
            this.txButtonComplete.UseVisualStyleBackColor = true;
            this.txButtonComplete.Click += new System.EventHandler(this.txButton1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 420F));
            this.tableLayoutPanel1.Controls.Add(this.label8, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelA, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelB, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelC, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(975, 217);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(557, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(281, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "拆解情况和检修结果";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelA
            // 
            this.labelA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelA.BackColor = System.Drawing.Color.White;
            this.labelA.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelA.Location = new System.Drawing.Point(4, 22);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(94, 194);
            this.labelA.TabIndex = 10;
            this.labelA.Text = "labelA";
            this.labelA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(4, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "检修项点";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(105, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "作业内容";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelB
            // 
            this.labelB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelB.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelB.Location = new System.Drawing.Point(105, 22);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(344, 194);
            this.labelB.TabIndex = 12;
            this.labelB.Text = "labelB";
            this.labelB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelD1);
            this.panel1.Controls.Add(this.tbD1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(557, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 188);
            this.panel1.TabIndex = 9;
            // 
            // labelD1
            // 
            this.labelD1.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.labelD1.AutoSize = true;
            this.labelD1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelD1.Location = new System.Drawing.Point(2, 74);
            this.labelD1.Name = "labelD1";
            this.labelD1.Size = new System.Drawing.Size(88, 16);
            this.labelD1.TabIndex = 9;
            this.labelD1.Text = "不良情况：";
            // 
            // tbD1
            // 
            this.tbD1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbD1.Location = new System.Drawing.Point(100, 3);
            this.tbD1.Multiline = true;
            this.tbD1.Name = "tbD1";
            this.tbD1.Size = new System.Drawing.Size(303, 182);
            this.tbD1.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(456, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "质量特性";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelC
            // 
            this.labelC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelC.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelC.Location = new System.Drawing.Point(456, 22);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(94, 194);
            this.labelC.TabIndex = 12;
            this.labelC.Text = "labelC";
            this.labelC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CapitionLogo = null;
            this.ClientSize = new System.Drawing.Size(977, 305);
            this.Controls.Add(this.txPanel1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Form1";
            this.Text = "Form1";
            this.txPanel1.ResumeLayout(false);
            this.txPanel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TX.Framework.WindowUI.Controls.TXPanel txPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelD1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.TextBox tbD1;
        private TX.Framework.WindowUI.Controls.TXButton txButtonComplete;

    }
}