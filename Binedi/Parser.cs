// ----------------------------------------------------------------------
// <copyright file="Parser.cs" company="none">

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
// <date>04/06/2012 19:06:46</date>
// -----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;

namespace Binedi
{
    public class Parser
    {
        Encoding enc;
        string log = null;
        XmlElement replace;

        // Bin variables
        byte[] data;

        // XML variables
        bool xmlLoaded = false;
        XmlDocument doc;
        XmlElement root, block;

        public Parser(string binPath, string replaceXML)
        {
            enc = Encoding.GetEncoding("shift_jis");
            data = File.ReadAllBytes(binPath);
            doc = new XmlDocument();

            if (replaceXML != "" && replaceXML is string && File.Exists(replaceXML))
            {
                XmlDocument rdoc = new XmlDocument();
                try { rdoc.Load(replaceXML); }
                catch (Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message + '\n' + ex.StackTrace); }
                replace = (XmlElement)rdoc.ChildNodes[1];
            }
        }

        public void Create_XML()
        {
            doc.AppendChild(doc.CreateXmlDeclaration("1.0", "utf-8", null));
            root = doc.CreateElement("Binedi");
            xmlLoaded = true;
        }
        public void Load_XML(string path)
        {
            if (path == "" || path == null)
                return;

            doc.Load(path);
            root = (XmlElement)doc.ChildNodes[1];
            xmlLoaded = true;
        } 

        public string Add_TextEntry(int offset, int size)
        {
            if (!xmlLoaded || block == null || offset + size > data.Length)
                return null;

            XmlElement e = doc.CreateElement("Text");
            e.InnerText = Read_String(offset, size);
            e.SetAttribute("Offset", offset.ToString("x"));
            e.SetAttribute("Size", size.ToString());

            block.AppendChild(e);
            return e.InnerText;
        }
        public string Add_TextEntry(ref int offset)
        {
            if (!xmlLoaded || block == null || offset >= data.Length)
                return null;

            int offset_old = offset;

            XmlElement e = doc.CreateElement("Text");
            e.InnerText = Read_String(ref offset);
            if (e.InnerText == "")
                return "";

            e.SetAttribute("Offset", offset_old.ToString("x"));
            e.SetAttribute("Size", (offset - offset_old).ToString());

            block.AppendChild(e);

            return e.InnerText;
        }

        public void Add_Block(string name)
        {
            if (!xmlLoaded)
                return;

            if (name == "" || name == null)
                name = "Block" + root.ChildNodes.Count.ToString();
            name = name.Replace(" ", "");

            block = doc.CreateElement(name);
            root.AppendChild(block);
        }
        public void Add_BlockText(string name, ref int pos)
        {
            if (!xmlLoaded)
                return;

            Add_Block(name);

            string text = "";
            do
            {
                try { text = Add_TextEntry(ref pos); }
                catch (Exception ex) { Console.WriteLine(ex.Message); break; }

            } while (text != "");
        }

        public string Get_Text(int block, int element)
        {
            if (block >= root.ChildNodes.Count || element >= root.ChildNodes[block].ChildNodes.Count)
                return null;

            return root.ChildNodes[block].ChildNodes[element].InnerText;
        }

        public void ApplyChange()
        {
            // Create log
            StreamWriter sw = null;
            if (log != null)
                if (!File.Exists(log))
                    sw = File.CreateText(log);
                else
                    sw = File.AppendText(log);

            foreach (XmlElement b in root.ChildNodes.OfType<XmlElement>())
            {
                foreach (XmlElement e in b.ChildNodes.OfType<XmlElement>())
                {
                    int pos = Convert.ToInt32(e.Attributes["Offset"].Value, 16);
                    int size = Convert.ToInt32(e.Attributes["Size"].Value);

                    try { Write_String(pos, size, e.InnerText); }
                    catch (Exception ex)
                    {
                        if (log == null)
                            System.Windows.Forms.MessageBox.Show(ex.Message + '\n' + ex.StackTrace);
                        else
                            sw.Write(ex.Message);

                        Console.WriteLine(ex.Message);
                    }
                }
            }

            if (log != null)
            {
                sw.Flush();
                sw.Close();
                sw.Dispose();
                sw = null;
            }
        }

        public void WriteBIN(string fileOut)
        {
            File.WriteAllBytes(fileOut, data);
        }
        public void WriteXML(string fileOut)
        {
            doc.RemoveAll();
            doc.AppendChild(doc.CreateXmlDeclaration("1.0", "utf-8", null));
            doc.AppendChild(root);
            doc.Save(fileOut);
        }

        private String Read_String(int pos, int size)
        {
            string text = new String(enc.GetChars(data, pos, size));
            text = Format(text);

            return text;
        }
        private String Read_String(ref int pos)
        {
            string text = "";
            List<byte> code = new List<byte>();

            byte b = 0;
            while (true)
            {
                if (pos >= data.Length)
                    throw new EndOfStreamException();

                b = data[pos++];
                if (b == 0)
                    break;

                if (b < 0x20 && b != 0x0A)
                    throw new FormatException("Unknown char found");

                code.Add(b);
            }

            while (pos % 4 != 0)
            {
                b = data[pos++];
                if (b != 0)
                    throw new FormatException("Wrong end pointer!\n0x " + pos.ToString("x"));
            }

            text = new String(enc.GetChars(code.ToArray()));
            text = Format(text);
            return text;
        }

        private void Write_String(int pos, int size, string text)
        {
            string original = (string)text.Clone();
            text = Reformat(text);
            byte[] code = enc.GetBytes(text);

            if (code.Length >= size)
            {
                throw new AccessViolationException("The following string is bigger than the max bytes: " +
                    size.ToString() + " (" + code.Length.ToString() + ") " + 
                    "(offset: 0x" + pos.ToString("X") + ")" +
                    original + "\n");
            }

            for (int i = 0; i < size; i++)
            {
                if (pos >= data.Length)
                    throw new AccessViolationException("Error. Try to write out of file.");

                if (i >= code.Length)
                    data[pos++] = 0;
                else
                    data[pos++] = code[i];
            }
        }

        private String Reformat(string text)
        {
            if (text == "" || text == null)
                return text;

            text = text.Replace("\r", "");
            text = text.Replace("\n      ", "\n");
            text = text.Remove(0, 1);
            text = text.Remove(text.Length - 5, 5);

            if (replace == null)
                return text;

            foreach (XmlElement e in replace.ChildNodes)
                text = text.Replace(e.Attributes["Original"].Value, e.Attributes["New"].Value);

            return text;
        }
        private String Format(string text)
        {
            if (text == "" || text == null)
                return text;

            text = text.Replace("\n", "\n      ");
            text = "\n      " + text + "\n    ";

            if (replace == null)
                return text;

            foreach (XmlElement e in replace.ChildNodes)
                text = text.Replace(e.Attributes["New"].Value, e.Attributes["Original"].Value);

            return text;
        }

        // Properties
        public XmlElement MainNode
        {
            get { return root; }
        }
        public string Log
        {
            set { log = value; }
        }
    }
}
