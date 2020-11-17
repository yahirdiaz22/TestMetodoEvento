﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestMetodoEvento
{
    public partial class Form1 : Form
    {
        double valor1, valor2;
        string operacion = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        private void MiMetodo_Click(object sender, EventArgs e)
        {
            string textoBoton = ((Button)sender).Text;
            if (textoBoton == "+")
            {

            }
            switch (textoBoton)
            {
                case "R":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    //operacion = textoBoton;
                    valor1 = double.Parse(lblNumeros.Text);
                    double resultado = Math.Sqrt(valor1);
                    lblNumeros.Text = resultado+"";
                    break;
                case "+":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    operacion = textoBoton;
                    valor1 = double.Parse(lblNumeros.Text);                   
                    lblNumeros.Text = "";
                    break;
                case "-":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    operacion = textoBoton;
                    valor1 = double.Parse(lblNumeros.Text);                    
                    lblNumeros.Text = "";
                    break;
                case "*":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    operacion = textoBoton;
                    valor1 = double.Parse(lblNumeros.Text);                   
                    lblNumeros.Text = "";
                    break;
                case "/":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    operacion = textoBoton;
                    valor1 = double.Parse(lblNumeros.Text);                   
                    lblNumeros.Text = "";
                    break;

                case "=":
                    if (lblNumeros.Text=="")
                    {
                        break;
                    }
                    switch (operacion)
                    {
                        case "+":
                           valor2 = double.Parse(lblNumeros.Text);
                            lblNumeros.Text = (valor1 + valor2) + "";
                          break;
                        case "-":
                            valor2 = double.Parse(lblNumeros.Text);
                            lblNumeros.Text = (valor1 - valor2) + "";
                            
                            break;
                        case "*":

                            valor2 = double.Parse(lblNumeros.Text);
                            lblNumeros.Text = (valor1 * valor2) + "";
                            break;
                        case "/":
                           valor2 = double.Parse(lblNumeros.Text);
                            lblNumeros.Text = (valor1 / valor2) + "";                            
                            break;
                        case "=":
                            valor2 = double.Parse(lblNumeros.Text);
                            lblNumeros.Text = (valor1 = valor2) + "";
                            
                            break;
                    }
                    break;
                case "AC":
                    lblNumeros.Text = "";
                    break;
                case ".":
                    if (lblNumeros.Text.IndexOf(".") == -1)
                    {
                        lblNumeros.Text += textoBoton; ;
                    }
                    break;
                default:
                    lblNumeros.Text += textoBoton;
                    break;
                   
            }






        }
    }
}
