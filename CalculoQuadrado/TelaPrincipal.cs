﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoQuadrado
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numero = 0;
            int quadrado = 0;

            numero = Convert.ToInt32(txtQuadrado.Text);
            quadrado = numero * numero;

            lblResultado.Text = ("O Quadrado de " + numero + " é " + quadrado);

            txtQuadrado.Text = "";
            //txtQuadrado.Focus();
        }
    }
}
