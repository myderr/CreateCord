﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateCord
{
    public partial class JsonEditForm : Form
    {
        public JsonEditForm()
        {
            InitializeComponent();
        }
        private string String;
        public string str_json_column
        {
            get { return String; }
            set { String = value; }
        }
        private void b_ok_Click(object sender, EventArgs e)
        {
            CodeMain codeGenerator = (CodeMain)this.Owner;
            codeGenerator.str_jsonschame = this.rtb_jsonedit.Text;
            Close();
        }

        private void b_close_Click(object sender, EventArgs e)
        {

        }

        private void JsonEditForm_Load(object sender, EventArgs e)
        {
            this.rtb_jsonedit.Text = str_json_column;
        }
    }
}
