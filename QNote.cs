﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Diagnostics;

namespace QNote
{
    public partial class QNote : Form
    {
        /// <summary>
        /// This are all the Fields 
        /// </summary>
        private string CurrentFile { get; set; }
        private OpenFileDialog OpenFile;
        private SaveFileDialog SaveFile;

        public QNote()
        {
            InitializeComponent();
            this.InitComponents();

        }
        private void InitComponents()
        {
            RichTextBox box = this.InputBox;
            //box.Size = new Size(this.Width - 22, this.Height - 147);
            box.Size = new Size(this.Width - 22, this.Height - 100);
            this.Controls.Add(box);
            //focusing on the inputBox
            //to start writting inmidiatly
            //this.InputBox.Focus();
            this.InputBox.Select();

        }
        private void Settings_Click(object sender, EventArgs e)
        {
            this.Hide();
            new QNoteSettings().Show();
        }

        private void QNote_Resize(object sender, EventArgs e)
        {
            //width 22
            //height 147
            //this.InputBox = new Control()
            //{

            //};
            ////this.InputBox.Size.Height = this.Height - 147; 
            //this.Text = $"X{this.Width} Y{this.Height}";
            RichTextBox box = this.InputBox;
            //box.Size = new Size(this.Width - 22, this.Height - 147);
            box.Size = new Size(this.Width - 22, this.Height - 100);
            this.Controls.Add(box);
        }



        /// <summary>
        /// EXit the system
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ViewStatusBar_Click(object sender, EventArgs e)
        {
          switch(this.ViewStatusBar.Checked)
            {
                case true:
                    this.ViewStatusBar.Checked = false;
                    this.StatusBar.Visible = false; 
                    break;
                case false:
                    this.ViewStatusBar.Checked = true;
                    this.StatusBar.Visible = true;
                    break;

            }
        }
     
        private void FileOpen_Click(object sender, EventArgs e)
        {
            try
            {
                this.OpenFile = new OpenFileDialog();
                this.OpenFile.Title = "Open File";
                this.OpenFile.Filter = "Text File|*.txt" + "|All Files|*.*";
                //this.OpenFile.Filter = "Word Documents|*.doc|Excel Worksheets|*.xls|PowerPoint Presentations|*.ppt" +
                // "|Office Files|*.doc;*.xls;*.ppt" +
                // "|All Files|*.*";
                this.OpenFile.ShowDialog();
                string text;
                string file;
                file = this.OpenFile.FileName;
                text = File.ReadAllText(file);
                this.Text = file;
                this.CurrentFile = file;
                this.InputBox.Text = text;
                //  data = File.Read
            }catch(Exception error)
            {
            // ShowError(error);
            }
        }

        private void FileSave_Click(object sender, EventArgs e)
        {
            try
            {
           
                if (this.CurrentFile == "" || this.CurrentFile == null)
                {

                    this.SaveFile = new SaveFileDialog();
                    this.SaveFile.Title = "Save File";
                    this.SaveFile.Filter = "Text File|*.txt" + "|All Files|*.*";
                    string file, text;
                    DialogResult dialog;
                    this.SaveFile.ShowDialog();
                    file = this.SaveFile.FileName;
                    text = this.InputBox.Text;
                    //MessageBox.Show(file);

                    if (File.Exists(file))
                    {
                        dialog = MessageBox.Show("Warning", "The File exist Would you like to rewrite it", MessageBoxButtons.YesNo);
                        if (dialog == DialogResult.Yes)
                        {
                            File.WriteAllText(file, text);
                            this.CurrentFile = file;
                            this.Text = file;
                            return;
                        }
                        // FileSave_Click(sender, e);
                    }

                    File.WriteAllText(file, text);
                    this.CurrentFile = file;
                    this.Text = file;
                    return;
                }
                else
                {
                    File.WriteAllText(this.CurrentFile, this.InputBox.Text);
                }
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }
        private void ShowError(Exception ex)
        {
            MessageBox.Show( ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void InputBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void FilePrint_Click(object sender, EventArgs e)
        {
            //Writer.Write(cvFile, cv);
            if(this.CurrentFile == null || this.CurrentFile == "")
            {
                return;
            }
            string file,text;
            file = $"{QTool.RemoveFileNameExtention(this.CurrentFile)}.html";
            text = $"<html>" +
                $"<head>" +
                $"<title>" +
                $"{this.CurrentFile}" +
                $"</title>" +
                $"</head>" +
                $"<body>{this.InputBox.Text}</body>" +
                $"</html>";

            //MessageBox.Show(file);
            File.WriteAllText(file,text);
            ProcessStartInfo processInfo = new ProcessStartInfo();
            processInfo.FileName = file;
            processInfo.UseShellExecute = true;
            Process.Start(processInfo);
        }

        private void FileSaveAs_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.InputBox.Text == "" || this.InputBox.Text == null)
                {
                    return;
                }
                this.SaveFile = new SaveFileDialog();
                this.SaveFile.Title = "Save File";
                this.SaveFile.Filter = "Text File|*.txt" + "|All Files|*.*";
                string file, text;
                DialogResult dialog;
                this.SaveFile.ShowDialog();
                file = this.SaveFile.FileName;
                text = this.InputBox.Text;
                //MessageBox.Show(file);

                if (File.Exists(file) && this.SaveFile.OverwritePrompt)
                {
                    //dialog = MessageBox.Show("Warning", "The File exist Would you like to rewrite it", MessageBoxButtons.YesNo);
                    //if (dialog == DialogResult.Yes)
                    //{
                    File.WriteAllText(file, text);
                    this.CurrentFile = file;
                    this.Text = file;
                    return;
                    //}
                    // FileSave_Click(sender, e);
                }
                File.WriteAllText(file, text);
                this.CurrentFile = file;
                this.Text = file;
                return;
            }catch(Exception error)
            {
                ShowError(error);
            }
               
            
        }

        private void QNote_KeyDown(object sender, KeyEventArgs e)
        {
            this.ProcessFunction(e);
        }
        private void InputBox_KeyDown(object sender, KeyEventArgs e)
        {
            this.ProcessFunction(e); 
        }
        private void ProcessFunction(KeyEventArgs e)
        {
            
            //Save File Triger
            if (e.Control && e.KeyCode == Keys.S)       // Ctrl-S Save
            {
                //MessageBox.Show("Pressed");
                this.FileSave_Click(this, e);
                // Do what you want here
                e.SuppressKeyPress = true;  // Stops other controls on the form receiving event.
            }
            //Open File Triger
            if (e.Control && e.KeyCode == Keys.O)       // Ctrl-S Save
            {
                //MessageBox.Show("Pressed");
                this.FileOpen_Click(this, e);
                // Do what you want here
                e.SuppressKeyPress = true;  // Stops other controls on the form receiving event.
            }
            if(e.Control && e.KeyCode == Keys.F)
            {
                this.EditFind_Click(this, e);   
            }
            if (e.Control && e.KeyCode == Keys.Oemplus)
            {
                this.ViewSoomIn_Click(this, e);
            }
            if (e.Control && e.KeyCode == Keys.OemMinus)
            {
                this.ViewZoomOut_Click(this, e);
            }
        }

        private void EditUndu_Click(object sender, EventArgs e)
        {
            this.InputBox.Undo();
        }

        private void EditCopy_Click(object sender, EventArgs e)
        {
            this.InputBox.Copy();
        }

        private void EditPaste_Click(object sender, EventArgs e)
        {
            this.InputBox.Paste();
        }

        private void EditDelete_Click(object sender, EventArgs e)
        {
            this.InputBox.Cut();
        }

        private void EditFind_Click(object sender, EventArgs e)
        {
            this.InputBoxFind.Visible = true;
            this.InputBoxFind.Focus();
        }

        private void InputBoxFind_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)       // Ctrl-S Save
            {
                //MessageBox.Show("Pressed");
                //this.FileOpen_Click(this, e);
                // Do what you want here
                foreach(string word in this.InputBox.Text.Split(' '))
                {
                    if (word.Contains(this.InputBox.Text))
                    {
                        this.InputBox.Find(this.InputBoxFind.Text, 0, this.InputBox.TextLength, RichTextBoxFinds.None);
                        this.InputBox.SelectionBackColor = Color.White;
                        this.InputBox.SelectionColor = Color.Black;
                        //MessageBox.Show(this.InputBox.SelectedText);
                    }
                }
                
                e.SuppressKeyPress = true;  // Stops other controls on the form receiving event.
            }
        }

        private void InputBoxFind_Leave(object sender, EventArgs e)
        {
            InputBoxFind.Visible = false; 
        }

        private void EditDate_Click(object sender, EventArgs e)
        {
            this.InputBox.Text += $" {DateTime.Now} "; 
        }

        private void ViewSoomIn_Click(object sender, EventArgs e)
        {
            this.InputBox.Font = new Font(FontFamily.GenericSansSerif, float.Parse((this.InputBox.Font.Size+1).ToString()));
        }

        private void ViewZoomOut_Click(object sender, EventArgs e)
        {
            this.InputBox.Font = new Font(FontFamily.GenericSansSerif, float.Parse((this.InputBox.Font.Size-1).ToString()));
        }

        private void ViewZoomReset_Click(object sender, EventArgs e)
        {
            this.InputBox.Font = new Font(FontFamily.GenericSansSerif,8);

        }
    }
}
