﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Future {

    public partial class ObjectivesForm : Form {

        private Prompt _prompt;

        public Prompt prompt {
            get {
                return this._prompt;
            }
            set {
                this._prompt = value;
            }
        }

        public ObjectivesForm() {
            InitializeComponent();

            this._prompt = new Prompt();
        }

        private void exit_button_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}