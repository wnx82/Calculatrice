﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatrice
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        public bool IsValidLogin { get; private set; }
        private void Btn_Valider_Click(object sender, EventArgs e)
        {
            if (TxtB_Id.Text == "" && TxtB_Pass.Text == "")
            {
                //this.Dispose();
                //this.Close();
                IsValidLogin = true;
                Close();

                //.Show() peut reouvrir en boucle alors que ShowDialog n'ouvre qu'une fois et plus accès à l'autre
            }
            else
            {
                MessageBox.Show("Vous n'êtes pas autorisé à vous connecter !!!", "login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtB_Id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                TxtB_Pass.Focus();
            }
        }

        private void TxtB_Pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Btn_Valider_Click(sender, e);
            }
            
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                TxtB_Pass.PasswordChar = '\0';
            }
            else
            { TxtB_Pass.PasswordChar = '*';
            }

            //TxtB_Pass.UseSystemPasswordChar = !checkBox1.Checked;

        }
    }
}