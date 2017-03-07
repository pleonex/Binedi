// ----------------------------------------------------------------------
// <copyright file="Form1.cs" company="none">
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
// <date>04/06/2012 18:59:05</date>
// -----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Xml;
using System.Text;
using System.Windows.Forms;
using Be.Windows.Forms;
using System.IO;

namespace Binedi
{
    public partial class Form1 : Form
    {
        Parser p;
        StringBuilder sb;

        public Form1()
        {
            InitializeComponent();

            sb = new StringBuilder();
            TextWriter tw = new StringWriter(sb);
            Console.SetOut(tw);
        }

        void Form1_Load(object sender, EventArgs e)
        {
            // Set the bin file
            OpenFileDialog o = new OpenFileDialog();
            o.CheckFileExists = true;
            if (o.ShowDialog() != DialogResult.OK)
            {
                Application.Exit();
                return;
            }

            string replaceXML = Application.StartupPath + Path.DirectorySeparatorChar + "replace.xml";
            p = new Parser(o.FileName, replaceXML);

            hexBox1.ByteProvider = new DynamicByteProvider(File.ReadAllBytes(o.FileName));
            hexBox1.ByteCharConverter = new ByteCharConveter("shift_jis");

            Text = "Binedi ~~ by pleonex       " + Path.GetFileName(o.FileName);
            Activate();

            txtError.Text += sb + "\n";
            sb.Length = 0;
        }

        void UpdateXML()
        {
            XmlElement root = p.MainNode;
            treeXml.Nodes.Clear();

            treeXml.BeginUpdate();

            int b = 0;
            foreach (XmlElement eblock in root.ChildNodes)
            {
                TreeNode tblock = new TreeNode(eblock.Name);

                int e = 0;
                foreach (XmlElement entry in eblock.ChildNodes)
                {
                    TreeNode tentry = new TreeNode(entry.Name);
                    tentry.Nodes.Add("Offset: " + entry.Attributes["Offset"].Value);
                    tentry.Nodes.Add("Size: " + entry.Attributes["Size"].Value);
                    tentry.Tag = b.ToString() + ',' + e.ToString();
                    tblock.Nodes.Add(tentry);
                    e++;
                }

                treeXml.Nodes.Add(tblock);
                b++;
            }

            treeXml.EndUpdate();
        }

        void btnOpenXML_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.CheckFileExists = true;
            o.DefaultExt = "xml";
            o.Filter = "XML|*.xml";
            if (o.ShowDialog() != DialogResult.OK)
                return;

            p.Load_XML(o.FileName);

            btnOpenXML.Enabled = false;
            btnNewXML.Enabled = false;
            btnWriteBin.Enabled = true;
            btnWriteXML.Enabled = true;
            groupEntry.Enabled = true;
            txtBlockName.Enabled = true;
            btnAddBlock.Enabled = true;
            btnTextSearch.Enabled = true;
            numBlockOffset.Enabled = true;

            UpdateXML();

            txtError.Text += sb + "\n";
            sb.Length = 0;
        }

        void btnNewXML_Click(object sender, EventArgs e)
        {
            p.Create_XML();

            btnOpenXML.Enabled = false;
            btnNewXML.Enabled = false;
            btnWriteBin.Enabled = true;
            btnWriteXML.Enabled = true;
            groupEntry.Enabled = true;
            txtBlockName.Enabled = true;
            btnAddBlock.Enabled = true;
            btnTextSearch.Enabled = true;
            numBlockOffset.Enabled = true;

            txtError.Text += sb + "\n";
            sb.Length = 0;
        }

        void btnWriteXML_Click(object sender, EventArgs e)
        {
            SaveFileDialog o = new SaveFileDialog();
            o.AddExtension = true;
            o.DefaultExt = "xml";
            o.Filter = "XML|*.xml";

            if (o.ShowDialog() != DialogResult.OK)
                return;

            p.WriteXML(o.FileName);

            o = null;

            txtError.Text += sb + "\n";
            sb.Length = 0;
        }

        void btnWriteBin_Click(object sender, EventArgs e)
        {
            SaveFileDialog o = new SaveFileDialog();
            if (o.ShowDialog() != DialogResult.OK)
                return;

            p.ApplyChange();
            p.WriteBIN(o.FileName);

            o = null;

            txtError.Text += sb + "\n";
            sb.Length = 0;
        }

        void btnAddBlock_Click(object sender, EventArgs e)
        {
            p.Add_Block(txtBlockName.Text);
            UpdateXML();

            txtError.Text += sb + "\n";
            sb.Length = 0;
        }

        void btnTextSearch_Click(object sender, EventArgs e)
        {
            int pos = (int)numBlockOffset.Value;
            p.Add_BlockText(txtBlockName.Text, ref pos);
            UpdateXML();

            numBlockOffset.Value = pos;
            hexBox1.SelectionStart = pos;

            txtError.Text += sb + "\n";
            sb.Length = 0;
        }

        void btnAddEntry_Click(object sender, EventArgs e)
        {
            p.Add_TextEntry((int)numNewOffset.Value, (int)numNewSize.Value);
            UpdateXML();

            txtError.Text += sb + "\n";
            sb.Length = 0;
        }


        void treeXml_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode s = e.Node;
            if (!(s.Tag is string))
                return;

            string tag = (string)s.Tag;
            int b = Convert.ToInt32(tag.Split(new char[] { ',' })[0]);
            int el = Convert.ToInt32(tag.Split(new char[] { ',' })[1]);

            txt.Text = p.Get_Text(b, el).Replace("\n", "\r\n");
        }

        void btnReboot_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        void hexBox1_SelectionStartChanged(object sender, EventArgs e)
        {
            label6.Text = "Selected byte: 0x" + hexBox1.SelectionStart.ToString("x");
            numBlockOffset.Value = hexBox1.SelectionStart;
        }
    }

    public class ByteCharConveter : IByteCharConverter
    {
        Encoding encoding;
        List<byte> requeridedChar;

        public ByteCharConveter(string encoding)
        {
            this.encoding = Encoding.GetEncoding(encoding);
            requeridedChar = new List<byte>();
        }

        public byte ToByte(char c)
        {
            if (encoding.WebName == "shift_jis")
                return ToByteShiftJis(c);

            return (byte)c;
        }

        public char ToChar(byte b)
        {
            if (encoding.WebName == "shift_jis")
                return ToCharShiftJis(b);

            return encoding.GetChars(new byte[] { b })[0];
        }

        public byte ToByteShiftJis(char c)
        {
            return (byte)c;
        }

        public char ToCharShiftJis(byte b)
        {
            if (requeridedChar.Count == 0 && b > 0x7F)
            {
                requeridedChar.Add(b);
                return '\x20';
            }

            requeridedChar.Add(b);
            string c = new string(encoding.GetChars(requeridedChar.ToArray()));
            requeridedChar.Clear();
            return (c[0] > '\x1F' ? c[0] : '.');

        }
    }

}
