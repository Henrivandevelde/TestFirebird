
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System;

namespace inifiles
{
    public class IniFile
    {
        public string filePath;
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section,
          string key, string val, string filePath);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section,
          string key, string def, StringBuilder retVal,
          int size, string filePath);

        public IniFile()
        {
            string fileName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            filePath = AppDomain.CurrentDomain.BaseDirectory + fileName + ".ini";
        }

        public IniFile(string fName, bool noDirectory)
        {
            if (noDirectory)
                filePath = AppDomain.CurrentDomain.BaseDirectory + fName;
            else
                filePath = fName;
        }
        public bool IniFileExists ()
        {
            return File.Exists (filePath);
        }

        public bool KeyExists(string Key, string Section = null)
        {
            return IniReadValue(Key, Section).Length > 0;
        }

        public void IniWriteValue(string Section, string Key, string Value)
        {
            WritePrivateProfileString(Section, Key, Value, filePath);
        }

        public string IniReadValue(string Section, string Key)
        {
            StringBuilder temp = new StringBuilder(255);
            int i = GetPrivateProfileString(Section, Key, "", temp, 255, filePath);
            return temp.ToString();
        }

        String convertString = "aJi8kaq9kat5ha8gjnvooodfsnLUerkKnfttssüpkemmudt678JKPo17iun";

        public string ToHexString(string str)
        {
            var sb = new StringBuilder();

            var bytes = Encoding.Unicode.GetBytes(str);
            foreach (var t in bytes)
            {
                sb.Append(t.ToString("X2"));
            }

            return sb.ToString(); // returns: "48656C6C6F20776F726C64" for "Hello world"
        }

        public string FromHexString(string hexString)
        {
            var bytes = new byte[hexString.Length / 2];
            for (var i = 0; i < bytes.Length; i++)
            {
                bytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
            }

            return Encoding.Unicode.GetString(bytes); // returns: "Hello world" for "48656C6C6F20776F726C64"
        }


        public string ConvertString (string s, bool reverse = false)
        {

            StringBuilder sb = new StringBuilder();
            if (reverse)
            {
                s = FromHexString(s);
            }
            for (int i = 0; i < s.Length; i++)
                sb.Append((char)(s[i] ^ (char)convertString[i]));

            String result = sb.ToString();

            if (reverse)
                return result;
            else 
                return ToHexString(result);

//            return s2;
        }
        #region Write

        public void WritePanel (string name, Panel pnl)
        {
            IniWriteValue(name, pnl.Name, "Panel");
            IniWriteValue(pnl.Name, "Left",   pnl.Left.ToString());
            IniWriteValue(pnl.Name, "Top",    pnl.Top.ToString());
            IniWriteValue(pnl.Name, "Width",  pnl.Width.ToString());
            IniWriteValue(pnl.Name, "Height", pnl.Height.ToString());
            foreach (Control c in pnl.Controls)
            {
                WriteControl(name, c);
            }
        }

        public void WriteGroupBox (string name, GroupBox box)
        {
            IniWriteValue(name, box.Name, "GroupBox");

            foreach (Control c in box.Controls)
                WriteControl(name, c);
        }
        
        public void WriteControl (string name, Control c)
        {
            if (c.Name == "") return;

            string s = c.GetType().ToString().ToLower();
            string value;

            switch (c.GetType().ToString().ToLower())
            {
                case "system.windows.forms.splitcontainer":

                    break;
                case "system.windows.forms.splitter":
                    Splitter split = (Splitter)c;
                    if (split.Dock == DockStyle.Bottom)
                       IniWriteValue (name,c.Name,split.Location.Y.ToString());
                    else
                        IniWriteValue(name, c.Name,split.Location.X.ToString());

                    break;

                case "system.windows.forms.textbox":
                    if (c.Name.ToLower().Contains("user") || c.Name.ToLower().Contains("password"))
                    {
                        value = ConvertString(((TextBox)c).Text.Replace(Environment.NewLine, "~"));

                    }
                    else
                        value = ((TextBox)c).Text.Replace(Environment.NewLine, "~");

                    IniWriteValue(name, c.Name, value);
                    break;
                case "system.windows.forms.checkbox":
                    IniWriteValue(name, c.Name, ((CheckBox)c).Checked.ToString());
                    break;
                case "system.windows.forms.numericupdown":
                    IniWriteValue(name, c.Name, ((NumericUpDown)c).Value.ToString());
                    break;
                case "system.windows.forms.label":
                    IniWriteValue(name, c.Name, ((Label)c).Text);
                    break;
                case "system.windows.forms.button":
                    IniWriteValue(name, c.Name, ((Button)c).Text);
                    break;
                case "system.windows.forms.panel":
                    WritePanel(name, (Panel)c);
                    break;
                case "system.windows.forms.radiobutton":
                    IniWriteValue(name, c.Name, ((RadioButton)c).Checked.ToString());
                    break;
                case "system.windows.forms.groupbox":
                    WriteGroupBox(name, (GroupBox)c);
                    break;
             }
        }

        public void WriteForm (Form frm)
        {
            if (frm == null) return;

            IniWriteValue(frm.Name, "Left",   frm.Left.ToString());
            IniWriteValue(frm.Name, "Top",    frm.Top.ToString());
            IniWriteValue(frm.Name, "Width",  frm.Width.ToString());
            IniWriteValue(frm.Name, "Height", frm.Height.ToString());

            foreach (Control c in frm.Controls )
            {
                WriteControl(frm.Name, c);
            }

        }
        #endregion

        #region Read
        public int ReadInteger(string section, string field)
        {
            if (KeyExists(section, field))
            {
                return Convert.ToInt32(IniReadValue(section, field));

            }
            return -1;
        }

        public string[] ReadStringList (string section, string field, bool convert)
        {
            if (KeyExists(section, field))
            {
                string res = ReadString(section, field, convert);
                return res.Split('~');
            }
            return null;
        }

        public string ReadString (string section, string field, bool convert)
        {
            string res = string.Empty;
            if (KeyExists(section, field))
            {
                res = IniReadValue(section, field);
                if (convert)
                    res = ConvertString(res, true);
            }
            return res;
        }

        public void ReadControl (string name, Control c)
        {
            if (!KeyExists(name, c.Name))
                return;

            string s = c.GetType().ToString().ToLower();
            string value = IniReadValue(name, c.Name);


            switch (c.GetType().ToString().ToLower())
            {
                case "system.windows.forms.textbox":
                    if (c.Name.ToLower().Contains("user") || c.Name.ToLower().Contains("password"))
                    {
                        value = ConvertString(value, true);
                    }

                    ((TextBox)c).Text = value.Replace("~", Environment.NewLine);
                    break;
                case "system.windows.forms.spitter":
                    break;
                case "system.windows.forms.checkbox":
                    ((CheckBox)c).Checked = Convert.ToBoolean(value);
                    break;

                case "system.windows.forms.numericupdown":
                    ((NumericUpDown)c).Value = Convert.ToDecimal(value);
                    break;

                case "system.windows.forms.label":
                    ((Label)c).Text = value;
                    break;

                case "system.windows.forms.button":
                    ((Button)c).Text = value;
                    break;

                case "system.windows.forms.radiobutton":
                    ((RadioButton)c).Checked = Convert.ToBoolean(value);
                    break;

                case "system.windows.forms.groupbox":
                    ReadGroupBox(name, (GroupBox)c);
                    break;

                case "system.windows.forms.panel":
                    ReadPanel(name, (Panel)c); 
                    break;

            }
        }

        public void ReadGroupBox (string name, GroupBox box)
        {
            foreach (Control c in box.Controls)
            {
                ReadControl(name, c);
            }
        }

        public void ReadPanel (string name, Panel pnl)
        {
            if (KeyExists(pnl.Name, "Left"))
                pnl.Left = Convert.ToInt32(IniReadValue(pnl.Name, "Left"));
            if (KeyExists(pnl.Name, "Top"))
                pnl.Top = Convert.ToInt32(IniReadValue(pnl.Name, "Top"));
            if (KeyExists(pnl.Name, "Width"))
                pnl.Width = Convert.ToInt32(IniReadValue(pnl.Name, "Width"));
            if (KeyExists(pnl.Name, "Height"))
                pnl.Height = Convert.ToInt32(IniReadValue(pnl.Name, "Height"));

            foreach (Control c in pnl.Controls)
            {
                ReadControl(name, c);
            }
        }

        public void ReadForm(Form frm)
        {
            if (frm == null) return;

            if (KeyExists (frm.Name, "Left"))
               frm.Left = Convert.ToInt32(IniReadValue(frm.Name, "Left"));
            if (KeyExists(frm.Name, "Top"))
                frm.Top = Convert.ToInt32(IniReadValue(frm.Name, "Top"));
            if (KeyExists(frm.Name, "Width"))
                frm.Width = Convert.ToInt32(IniReadValue(frm.Name, "Width"));
            if (KeyExists(frm.Name, "Height"))
                frm.Height = Convert.ToInt32(IniReadValue(frm.Name, "Height"));

            foreach (Control c in frm.Controls)
            {
                ReadControl(frm.Name, c);
            }

        }
        #endregion

    }

}

