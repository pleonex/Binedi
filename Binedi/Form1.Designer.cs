// ----------------------------------------------------------------------
// <copyright file="Form1.Designer.cs" company="none">

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
// <date>04/06/2012 18:59:19</date>
// -----------------------------------------------------------------------
namespace Binedi
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnOpenXML = new System.Windows.Forms.Button();
            this.btnNewXML = new System.Windows.Forms.Button();
            this.treeXml = new System.Windows.Forms.TreeView();
            this.groupEntry = new System.Windows.Forms.GroupBox();
            this.btnAddEntry = new System.Windows.Forms.Button();
            this.numNewSize = new System.Windows.Forms.NumericUpDown();
            this.numNewOffset = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddBlock = new System.Windows.Forms.Button();
            this.btnTextSearch = new System.Windows.Forms.Button();
            this.btnWriteXML = new System.Windows.Forms.Button();
            this.btnWriteBin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBlockName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numBlockOffset = new System.Windows.Forms.NumericUpDown();
            this.txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReboot = new System.Windows.Forms.Button();
            this.txtError = new System.Windows.Forms.TextBox();
            this.hexBox1 = new Be.Windows.Forms.HexBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupEntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNewSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNewOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBlockOffset)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpenXML
            // 
            this.btnOpenXML.Location = new System.Drawing.Point(353, 300);
            this.btnOpenXML.Name = "btnOpenXML";
            this.btnOpenXML.Size = new System.Drawing.Size(80, 40);
            this.btnOpenXML.TabIndex = 1;
            this.btnOpenXML.Text = "Open XML";
            this.btnOpenXML.UseVisualStyleBackColor = true;
            this.btnOpenXML.Click += new System.EventHandler(this.btnOpenXML_Click);
            // 
            // btnNewXML
            // 
            this.btnNewXML.Location = new System.Drawing.Point(439, 300);
            this.btnNewXML.Name = "btnNewXML";
            this.btnNewXML.Size = new System.Drawing.Size(80, 40);
            this.btnNewXML.TabIndex = 2;
            this.btnNewXML.Text = "New XML";
            this.btnNewXML.UseVisualStyleBackColor = true;
            this.btnNewXML.Click += new System.EventHandler(this.btnNewXML_Click);
            // 
            // treeXml
            // 
            this.treeXml.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeXml.Location = new System.Drawing.Point(0, 0);
            this.treeXml.Name = "treeXml";
            this.treeXml.Size = new System.Drawing.Size(175, 444);
            this.treeXml.TabIndex = 3;
            this.treeXml.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeXml_AfterSelect);
            // 
            // groupEntry
            // 
            this.groupEntry.Controls.Add(this.btnAddEntry);
            this.groupEntry.Controls.Add(this.numNewSize);
            this.groupEntry.Controls.Add(this.numNewOffset);
            this.groupEntry.Controls.Add(this.label2);
            this.groupEntry.Controls.Add(this.label1);
            this.groupEntry.Enabled = false;
            this.groupEntry.Location = new System.Drawing.Point(181, 106);
            this.groupEntry.Name = "groupEntry";
            this.groupEntry.Size = new System.Drawing.Size(338, 72);
            this.groupEntry.TabIndex = 4;
            this.groupEntry.TabStop = false;
            this.groupEntry.Text = "New entry";
            // 
            // btnAddEntry
            // 
            this.btnAddEntry.Location = new System.Drawing.Point(242, 21);
            this.btnAddEntry.Name = "btnAddEntry";
            this.btnAddEntry.Size = new System.Drawing.Size(80, 40);
            this.btnAddEntry.TabIndex = 5;
            this.btnAddEntry.Text = "Add entry";
            this.btnAddEntry.UseVisualStyleBackColor = true;
            this.btnAddEntry.Click += new System.EventHandler(this.btnAddEntry_Click);
            // 
            // numNewSize
            // 
            this.numNewSize.Hexadecimal = true;
            this.numNewSize.Location = new System.Drawing.Point(85, 45);
            this.numNewSize.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numNewSize.Name = "numNewSize";
            this.numNewSize.Size = new System.Drawing.Size(120, 20);
            this.numNewSize.TabIndex = 4;
            // 
            // numNewOffset
            // 
            this.numNewOffset.Hexadecimal = true;
            this.numNewOffset.Location = new System.Drawing.Point(85, 19);
            this.numNewOffset.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numNewOffset.Name = "numNewOffset";
            this.numNewOffset.Size = new System.Drawing.Size(120, 20);
            this.numNewOffset.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Size:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Offset:";
            // 
            // btnAddBlock
            // 
            this.btnAddBlock.Enabled = false;
            this.btnAddBlock.Location = new System.Drawing.Point(392, 12);
            this.btnAddBlock.Name = "btnAddBlock";
            this.btnAddBlock.Size = new System.Drawing.Size(80, 40);
            this.btnAddBlock.TabIndex = 5;
            this.btnAddBlock.Text = "Add block";
            this.btnAddBlock.UseVisualStyleBackColor = true;
            this.btnAddBlock.Click += new System.EventHandler(this.btnAddBlock_Click);
            // 
            // btnTextSearch
            // 
            this.btnTextSearch.Enabled = false;
            this.btnTextSearch.Location = new System.Drawing.Point(392, 58);
            this.btnTextSearch.Name = "btnTextSearch";
            this.btnTextSearch.Size = new System.Drawing.Size(80, 40);
            this.btnTextSearch.TabIndex = 0;
            this.btnTextSearch.Text = "Auto search";
            this.btnTextSearch.UseVisualStyleBackColor = true;
            this.btnTextSearch.Click += new System.EventHandler(this.btnTextSearch_Click);
            // 
            // btnWriteXML
            // 
            this.btnWriteXML.Enabled = false;
            this.btnWriteXML.Location = new System.Drawing.Point(181, 300);
            this.btnWriteXML.Name = "btnWriteXML";
            this.btnWriteXML.Size = new System.Drawing.Size(80, 40);
            this.btnWriteXML.TabIndex = 6;
            this.btnWriteXML.Text = "Write XML";
            this.btnWriteXML.UseVisualStyleBackColor = true;
            this.btnWriteXML.Click += new System.EventHandler(this.btnWriteXML_Click);
            // 
            // btnWriteBin
            // 
            this.btnWriteBin.Enabled = false;
            this.btnWriteBin.Location = new System.Drawing.Point(267, 300);
            this.btnWriteBin.Name = "btnWriteBin";
            this.btnWriteBin.Size = new System.Drawing.Size(80, 40);
            this.btnWriteBin.TabIndex = 7;
            this.btnWriteBin.Text = "Write BIN";
            this.btnWriteBin.UseVisualStyleBackColor = true;
            this.btnWriteBin.Click += new System.EventHandler(this.btnWriteBin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Block name:";
            // 
            // txtBlockName
            // 
            this.txtBlockName.Enabled = false;
            this.txtBlockName.Location = new System.Drawing.Point(266, 23);
            this.txtBlockName.Name = "txtBlockName";
            this.txtBlockName.Size = new System.Drawing.Size(120, 20);
            this.txtBlockName.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Block offset:";
            // 
            // numBlockOffset
            // 
            this.numBlockOffset.Enabled = false;
            this.numBlockOffset.Hexadecimal = true;
            this.numBlockOffset.Location = new System.Drawing.Point(266, 70);
            this.numBlockOffset.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numBlockOffset.Name = "numBlockOffset";
            this.numBlockOffset.Size = new System.Drawing.Size(120, 20);
            this.numBlockOffset.TabIndex = 12;
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(182, 207);
            this.txt.Multiline = true;
            this.txt.Name = "txt";
            this.txt.ReadOnly = true;
            this.txt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt.Size = new System.Drawing.Size(330, 87);
            this.txt.TabIndex = 13;
            this.txt.WordWrap = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Selected text node:";
            // 
            // btnReboot
            // 
            this.btnReboot.Location = new System.Drawing.Point(506, 1);
            this.btnReboot.Name = "btnReboot";
            this.btnReboot.Size = new System.Drawing.Size(15, 20);
            this.btnReboot.TabIndex = 15;
            this.btnReboot.Text = "R";
            this.btnReboot.UseVisualStyleBackColor = true;
            this.btnReboot.Click += new System.EventHandler(this.btnReboot_Click);
            // 
            // txtError
            // 
            this.txtError.Location = new System.Drawing.Point(181, 347);
            this.txtError.Multiline = true;
            this.txtError.Name = "txtError";
            this.txtError.ReadOnly = true;
            this.txtError.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtError.Size = new System.Drawing.Size(338, 97);
            this.txtError.TabIndex = 16;
            // 
            // hexBox1
            // 
            this.hexBox1.BackColor = System.Drawing.Color.Tan;
            this.hexBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.hexBox1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hexBox1.LineInfoVisible = true;
            this.hexBox1.Location = new System.Drawing.Point(525, 0);
            this.hexBox1.Name = "hexBox1";
            this.hexBox1.ReadOnly = true;
            this.hexBox1.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.hexBox1.Size = new System.Drawing.Size(643, 444);
            this.hexBox1.StringViewVisible = true;
            this.hexBox1.TabIndex = 17;
            this.hexBox1.UseFixedBytesPerLine = true;
            this.hexBox1.VScrollBarVisible = true;
            this.hexBox1.SelectionStartChanged += new System.EventHandler(this.hexBox1_SelectionStartChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(363, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Selected byte:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1168, 444);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.hexBox1);
            this.Controls.Add(this.txtError);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Binedi ~~ by pleonex";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupEntry.ResumeLayout(false);
            this.groupEntry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNewSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNewOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBlockOffset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenXML;
        private System.Windows.Forms.Button btnNewXML;
        private System.Windows.Forms.TreeView treeXml;
        private System.Windows.Forms.GroupBox groupEntry;
        private System.Windows.Forms.Button btnAddEntry;
        private System.Windows.Forms.NumericUpDown numNewSize;
        private System.Windows.Forms.NumericUpDown numNewOffset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTextSearch;
        private System.Windows.Forms.Button btnAddBlock;
        private System.Windows.Forms.Button btnWriteXML;
        private System.Windows.Forms.Button btnWriteBin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBlockName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numBlockOffset;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnReboot;
        private System.Windows.Forms.TextBox txtError;
        private Be.Windows.Forms.HexBox hexBox1;
        private System.Windows.Forms.Label label6;

    }
}

