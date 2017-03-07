// ----------------------------------------------------------------------
// <copyright file="Program.cs" company="none">

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
// <date>04/06/2012 18:59:45</date>
// -----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace Binedi
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length > 1)
            {
                Quick_Action(args);
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        static void Quick_Action(string[] args)
        {
            if (args[0] != "-if" || args.Length != 4)
                return;

            string log = @"G:\nds\projects\ninokuni\Programas\Errores overlays.txt";
            // Create log
            if (File.Exists(log))
                File.Delete(log);

            // Import xmls
            // XML translated files
            string[] xmls = Directory.GetFiles(args[2], "*.xml", SearchOption.TopDirectoryOnly);
            // Bin files
            string[] bins = Directory.GetFiles(args[1]);
            // Output oflder
            string folder_out = args[3] + Path.DirectorySeparatorChar;

            for (int i = 0; i < bins.Length; i++)
            {
                string xml_file = Array.Find(xmls, a => Path.GetFileNameWithoutExtension(a) == Path.GetFileNameWithoutExtension(bins[i]));
                if (xml_file == null)
                {
                    Console.WriteLine("XML not found: {0}", Path.GetFileName(bins[i]));
                    continue;
                }

                Console.WriteLine("Changing {0}", Path.GetFileName(bins[i]));
                string bin_file = folder_out + Path.GetFileName(bins[i]);
                File.AppendAllText(log, "** Applying file: " + Path.GetFileName(xml_file) + " **\r\n\r\n");

                Parser p = new Parser(bins[i], Application.StartupPath + Path.DirectorySeparatorChar + "replace.xml");
                p.Log = log;
                p.Load_XML(xml_file);
                p.ApplyChange();
                p.WriteBIN(bin_file);
                p = null;
            }
        }

    }
}
