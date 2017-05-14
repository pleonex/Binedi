﻿// ----------------------------------------------------------------------
// <copyright file="MainForm.Designer.cs" company="none">

// Copyright (C) 2012
//
//   This program is free software: you can redistribute it and/or modify
//   it under the terms of the GNU General Public License as published by 
//   the Free Software Foundation, either version 3 of the License, or
//   (at your option) any later version.
//
//   This program is distributed in the hope that it will be useful, 
//   but WITHOUT ANY WARRANTY; without even the implied warranty of
//   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//   GNU General Public License for more details. 
//
//   You should have received a copy of the GNU General Public License
//   along with this program.  If not, see <http://www.gnu.org/licenses/>. 
//
// </copyright>

// <author>pleoNeX</author>
// <email>benito356@gmail.com</email>
// -----------------------------------------------------------------------
namespace Binedi
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Reflection;
    using System.Windows.Forms;
    using Be.Windows.Forms;

    partial class MainForm
    {
        private IContainer components;
        private Button btnOpenXML;
        private Button btnNewXML;
        private TreeView treeXml;
        private GroupBox groupEntry;
        private Button btnAddEntry;
        private NumericUpDown numNewSize;
        private NumericUpDown numNewOffset;
        private Label label2;
        private Label label1;
        private Button btnTextSearch;
        private Button btnAddBlock;
        private Button btnWriteXML;
        private Button btnWriteBin;
        private Label label3;
        private TextBox txtBlockName;
        private Label label4;
        private NumericUpDown numBlockOffset;
        private TextBox txt;
        private Label label5;
        private Button btnReboot;
        private HexBox hexBox1;
        private Label label6;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnOpenXML = new Button();
            this.btnNewXML = new Button();
            this.treeXml = new TreeView();
            this.groupEntry = new GroupBox();
            this.btnAddEntry = new Button();
            this.numNewSize = new NumericUpDown();
            this.numNewOffset = new NumericUpDown();
            this.label2 = new Label();
            this.label1 = new Label();
            this.btnAddBlock = new Button();
            this.btnTextSearch = new Button();
            this.btnWriteXML = new Button();
            this.btnWriteBin = new Button();
            this.label3 = new Label();
            this.txtBlockName = new TextBox();
            this.label4 = new Label();
            this.numBlockOffset = new NumericUpDown();
            this.txt = new TextBox();
            this.label5 = new Label();
            this.btnReboot = new Button();
            this.hexBox1 = new HexBox();
            this.label6 = new Label();
            this.groupEntry.SuspendLayout();
            ((ISupportInitialize)(this.numNewSize)).BeginInit();
            ((ISupportInitialize)(this.numNewOffset)).BeginInit();
            ((ISupportInitialize)(this.numBlockOffset)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpenXML
            // 
            this.btnOpenXML.Location = new Point(353, 300);
            this.btnOpenXML.Name = "btnOpenXML";
            this.btnOpenXML.Size = new Size(80, 40);
            this.btnOpenXML.TabIndex = 1;
            this.btnOpenXML.Text = "Open XML";
            this.btnOpenXML.UseVisualStyleBackColor = true;
            this.btnOpenXML.Click += new EventHandler(this.btnOpenXML_Click);
            // 
            // btnNewXML
            // 
            this.btnNewXML.Location = new Point(439, 300);
            this.btnNewXML.Name = "btnNewXML";
            this.btnNewXML.Size = new Size(80, 40);
            this.btnNewXML.TabIndex = 2;
            this.btnNewXML.Text = "New XML";
            this.btnNewXML.UseVisualStyleBackColor = true;
            this.btnNewXML.Click += new EventHandler(this.btnNewXML_Click);
            // 
            // treeXml
            // 
            this.treeXml.Dock = DockStyle.Left;
            this.treeXml.Location = new Point(0, 0);
            this.treeXml.Name = "treeXml";
            this.treeXml.Size = new Size(175, 444);
            this.treeXml.TabIndex = 3;
            this.treeXml.AfterSelect += new TreeViewEventHandler(this.treeXml_AfterSelect);
            // 
            // groupEntry
            // 
            this.groupEntry.Controls.Add(this.btnAddEntry);
            this.groupEntry.Controls.Add(this.numNewSize);
            this.groupEntry.Controls.Add(this.numNewOffset);
            this.groupEntry.Controls.Add(this.label2);
            this.groupEntry.Controls.Add(this.label1);
            this.groupEntry.Enabled = false;
            this.groupEntry.Location = new Point(181, 106);
            this.groupEntry.Name = "groupEntry";
            this.groupEntry.Size = new Size(338, 72);
            this.groupEntry.TabIndex = 4;
            this.groupEntry.TabStop = false;
            this.groupEntry.Text = "New entry";
            // 
            // btnAddEntry
            // 
            this.btnAddEntry.Location = new Point(242, 21);
            this.btnAddEntry.Name = "btnAddEntry";
            this.btnAddEntry.Size = new Size(80, 40);
            this.btnAddEntry.TabIndex = 5;
            this.btnAddEntry.Text = "Add entry";
            this.btnAddEntry.UseVisualStyleBackColor = true;
            this.btnAddEntry.Click += new EventHandler(this.btnAddEntry_Click);
            // 
            // numNewSize
            // 
            this.numNewSize.Hexadecimal = true;
            this.numNewSize.Location = new Point(85, 45);
            this.numNewSize.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numNewSize.Name = "numNewSize";
            this.numNewSize.Size = new Size(120, 20);
            this.numNewSize.TabIndex = 4;
            // 
            // numNewOffset
            // 
            this.numNewOffset.Hexadecimal = true;
            this.numNewOffset.Location = new Point(85, 19);
            this.numNewOffset.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numNewOffset.Name = "numNewOffset";
            this.numNewOffset.Size = new Size(120, 20);
            this.numNewOffset.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Size:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Offset:";
            // 
            // btnAddBlock
            // 
            this.btnAddBlock.Enabled = false;
            this.btnAddBlock.Location = new Point(392, 12);
            this.btnAddBlock.Name = "btnAddBlock";
            this.btnAddBlock.Size = new Size(80, 40);
            this.btnAddBlock.TabIndex = 5;
            this.btnAddBlock.Text = "Add block";
            this.btnAddBlock.UseVisualStyleBackColor = true;
            this.btnAddBlock.Click += new EventHandler(this.btnAddBlock_Click);
            // 
            // btnTextSearch
            // 
            this.btnTextSearch.Enabled = false;
            this.btnTextSearch.Location = new Point(392, 58);
            this.btnTextSearch.Name = "btnTextSearch";
            this.btnTextSearch.Size = new Size(80, 40);
            this.btnTextSearch.TabIndex = 0;
            this.btnTextSearch.Text = "Auto search";
            this.btnTextSearch.UseVisualStyleBackColor = true;
            this.btnTextSearch.Click += new EventHandler(this.btnTextSearch_Click);
            // 
            // btnWriteXML
            // 
            this.btnWriteXML.Enabled = false;
            this.btnWriteXML.Location = new Point(181, 300);
            this.btnWriteXML.Name = "btnWriteXML";
            this.btnWriteXML.Size = new Size(80, 40);
            this.btnWriteXML.TabIndex = 6;
            this.btnWriteXML.Text = "Write XML";
            this.btnWriteXML.UseVisualStyleBackColor = true;
            this.btnWriteXML.Click += new EventHandler(this.btnWriteXML_Click);
            // 
            // btnWriteBin
            // 
            this.btnWriteBin.Enabled = false;
            this.btnWriteBin.Location = new Point(267, 300);
            this.btnWriteBin.Name = "btnWriteBin";
            this.btnWriteBin.Size = new Size(80, 40);
            this.btnWriteBin.TabIndex = 7;
            this.btnWriteBin.Text = "Write BIN";
            this.btnWriteBin.UseVisualStyleBackColor = true;
            this.btnWriteBin.Click += new EventHandler(this.btnWriteBin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new Point(178, 26);
            this.label3.Name = "label3";
            this.label3.Size = new Size(66, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Block name:";
            // 
            // txtBlockName
            // 
            this.txtBlockName.Enabled = false;
            this.txtBlockName.Location = new Point(266, 23);
            this.txtBlockName.Name = "txtBlockName";
            this.txtBlockName.Size = new Size(120, 20);
            this.txtBlockName.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new Point(178, 72);
            this.label4.Name = "label4";
            this.label4.Size = new Size(66, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Block offset:";
            // 
            // numBlockOffset
            // 
            this.numBlockOffset.Enabled = false;
            this.numBlockOffset.Hexadecimal = true;
            this.numBlockOffset.Location = new Point(266, 70);
            this.numBlockOffset.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numBlockOffset.Name = "numBlockOffset";
            this.numBlockOffset.Size = new Size(120, 20);
            this.numBlockOffset.TabIndex = 12;
            // 
            // txt
            // 
            this.txt.Location = new Point(182, 207);
            this.txt.Multiline = true;
            this.txt.Name = "txt";
            this.txt.ReadOnly = true;
            this.txt.ScrollBars = ScrollBars.Both;
            this.txt.Size = new Size(330, 87);
            this.txt.TabIndex = 13;
            this.txt.WordWrap = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new Point(181, 191);
            this.label5.Name = "label5";
            this.label5.Size = new Size(99, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Selected text node:";
            // 
            // btnReboot
            // 
            this.btnReboot.Location = new Point(506, 1);
            this.btnReboot.Name = "btnReboot";
            this.btnReboot.Size = new Size(15, 20);
            this.btnReboot.TabIndex = 15;
            this.btnReboot.Text = "R";
            this.btnReboot.UseVisualStyleBackColor = true;
            this.btnReboot.Click += new EventHandler(this.btnReboot_Click);
            // 
            // hexBox1
            // 
            this.hexBox1.BackColor = Color.Tan;
            this.hexBox1.Dock = DockStyle.Right;
            this.hexBox1.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.hexBox1.LineInfoVisible = true;
            this.hexBox1.Location = new Point(525, 0);
            this.hexBox1.Name = "hexBox1";
            this.hexBox1.ReadOnly = true;
            this.hexBox1.ShadowSelectionColor = Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.hexBox1.Size = new Size(643, 444);
            this.hexBox1.StringViewVisible = true;
            this.hexBox1.TabIndex = 17;
            this.hexBox1.UseFixedBytesPerLine = true;
            this.hexBox1.VScrollBarVisible = true;
            this.hexBox1.SelectionStartChanged += new EventHandler(this.hexBox1_SelectionStartChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new Point(363, 185);
            this.label6.Name = "label6";
            this.label6.Size = new Size(75, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Selected byte:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = SystemColors.GradientInactiveCaption;
            this.ClientSize = new Size(1168, 444);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.hexBox1);
            this.Controls.Add(this.btnReboot);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.numBlockOffset);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBlockName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnWriteBin);
            this.Controls.Add(this.btnWriteXML);
            this.Controls.Add(this.btnAddBlock);
            this.Controls.Add(this.btnTextSearch);
            this.Controls.Add(this.groupEntry);
            this.Controls.Add(this.treeXml);
            this.Controls.Add(this.btnNewXML);
            this.Controls.Add(this.btnOpenXML);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Icon = new Icon(
                Assembly.GetExecutingAssembly()
                .GetManifestResourceStream("Binedi.Resources.icon.ico"));
            this.MaximizeBox = false;
            this.Name = "BinEdi";
            this.Text = "BinEdi ~~ by pleonex";
            this.Load += new EventHandler(this.Form1_Load);
            this.groupEntry.ResumeLayout(false);
            this.groupEntry.PerformLayout();
            ((ISupportInitialize)(this.numNewSize)).EndInit();
            ((ISupportInitialize)(this.numNewOffset)).EndInit();
            ((ISupportInitialize)(this.numBlockOffset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
