using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrainTraining0
{
    public partial class Form1 : Form
    {

        /////////// VARIABLES GLOBALES /////////////

        int segundos, puntos, nAciertos,nivel,rango;
        //el rango determina el intervalo de los numeros disponibles para las operaciones
        double valorCorrecto;
        Random aleatorio = new Random();
        MySqlConnection conexion = new MySqlConnection();


        ////////// METODOS DE FORMULARIO ///////////

        public Form1()
        {
            InitializeComponent();
            puntos = 0; nAciertos = 0;
            //si no se activa el metodo de cambio de tiempo en el menu del juego,
            //se fuerza a coger el valor por defecto
            segundos = Convert.ToInt16(numTiempo.Value);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            conexion.ConnectionString = "Server=remotemysql.com;Database=Pr1mdxAdrh;Uid=Pr1mdxAdrh;Password=fNBUrxid1O";
        }

        ////////////////////////////////////////////
        ////////// FUNCIONES DE EVENTOS ////////////
        ////////////////////////////////////////////

        private void txt1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                double miSolucion = Convert.ToDouble(txt1.Text);
                if (miSolucion == valorCorrecto)
                {
                    //contamos los aciertos consecutivos
                    nAciertos++;
                    //cuando aciertas y quedan 10 sregundos o menos, sumas 2 segundos
                    if (segundos <= 10)
                    {
                        segundos += 2;                    
                    }
                    //si quedan mas de 10 segundos sumas 1 segundo
                    else
                    {
                        segundos += 1;
                    }
                    if (nAciertos >= 5)
                    {
                        puntos += 2;
                    }
                    else
                    {
                        puntos++;
                    } 
                }
                else
                {
                    if (puntos > 0)
                    {
                        puntos--;
                        nAciertos = 0;
                    }
                    nAciertos = 0;
                }
                //actualizo el label de puntos y el de segundos
                lblTime.Text = Convert.ToString(segundos);
                lbl1.Text = Convert.ToString(puntos);
                txt1.Text = "";
                generarPartida();
            }
        }

        ////////////////////////////////////////////
        ///////// FUNCIONES DE CONTROLES ///////////
        ////////////////////////////////////////////

        //timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            segundos--;
            lblTime.Text = Convert.ToString(segundos);
            if (segundos == 0)
            {
                finalPartida();
            }
        }

        //boton guardar resultado
        //metodo para almacenar los datos de partida en la BD
        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();
            String cadenasql = "insert into ranking values(Npartidas,?nombre,?fecha,?puntos)";
            MySqlCommand comando = new MySqlCommand(cadenasql, conexion);
            comando.Parameters.Add("?nombre", MySqlDbType.String).Value = txtName.Text;
            comando.Parameters.Add("?fecha", MySqlDbType.DateTime).Value = DateTime.Now;
            comando.Parameters.Add("?puntos", MySqlDbType.Int16).Value = puntos;
            comando.ExecuteNonQuery();
            conexion.Close();
            //cuando se inserta el nombre y queremos empezar otra vez
            generarMensaje();
            menuConfiguracion();
            //por si el usuario no actualiza el valor del tiempo de la partida
            //se reinicia la ultima configuracion
            segundos = Convert.ToInt16(numTiempo.Value);
            lblTime.Text = Convert.ToString(segundos);
        }

        //boton info
        private void btInfo_Click(object sender, EventArgs e)
        {
            String cadena = "";
            cadena += "\tINFORMACIÓN GENERAL\n";
            cadena += "................................................................................\n";
            cadena += "\tDificultad\n";
            cadena += "1: Suma de numeros del 1 al 10\n";
            cadena += "2: Suma y Resta numeros del 1 al 10\n";
            cadena += "3: Nivel 2 + Multiplicacion\n";
            cadena += "4: Nivel 3 + Division y numeros hasta el 20\n";
            cadena += "..................................................................................\n";
            cadena += "\tControl adicional\n";
            cadena += "Resta: El resultado nunca será negativo\n";
            cadena += "División: El resultado nunca será decimal";
            MessageBox.Show(cadena);
        }

        //lista seleccion nivel
        private void listaNiveles_SelectedIndexChanged(object sender, EventArgs e)
        {
            nivel = Convert.ToInt16(listaNiveles.SelectedIndex) + 1;
            btStart.Enabled = true;
        }

        //cuadro numerico seleccion tiempo
        private void numTiempo_ValueChanged(object sender, EventArgs e)
        {
            segundos = Convert.ToInt16(numTiempo.Value);
            lblTime.Text = Convert.ToString(segundos);
        }

        //boton START
        private void btStart_Click(object sender, EventArgs e)
        {
            puntos = 0; nAciertos = 0;
            gb2.Enabled = false;
            gb2.Visible = false;
            gb1.Enabled = true;
            gb1.Visible = true;
            txt1.Enabled = true;
            btGuardar.Enabled = false;
            btGuardar.Visible = false;
            txtName.Enabled = false;
            txtName.Visible = false;
            txt1.Focus();
            timer1.Enabled = true;
            generarPartida();
        }
        ////////////////////////////////////////////
        ////////// FUNCIONES AUXILIARES ////////////
        ////////////////////////////////////////////

        //metodo para generar parametros de una operacion
        private void generarPartida()
        {
            char operador = operadorYrangoElegido();
            lblOperador.Text = Convert.ToString(operador);
            int num1 = aleatorio.Next(rango)+1;
            int num2 = aleatorio.Next(rango)+1;
            switch (operador)
            {
                case '+':
                    valorCorrecto = (double)num1 + num2;
                    break;
                case '-':
                    if (num1 > num2)
                    {
                        valorCorrecto = (double)num1 - num2;
                    }
                    else
                    {
                        num1 = num1 + num2;//n1 vale n1+n2
                        num2 = num1 - num2;//n2 vale (n1+n2)-n2 = n1
                        num1 = num1 - num2;//n1 vale (n1+n2)-n1 = n2
                        valorCorrecto = (double)num1 - num2;
                    }
                    break;
                case '*':
                    valorCorrecto = (double)num1 * num2;
                    break;
                case '/':
                    while (num1 % num2 != 0)
                    {
                        num2 = aleatorio.Next(rango) + 1;
                    }
                    valorCorrecto = (double)num1 / num2;
                    break;
            }
            
            lbl3.Text = Convert.ToString(num1);
            lbl5.Text = Convert.ToString(num2);
        }

        //al terminar una partida
        private void finalPartida()
        {
            txt1.Enabled = false;
            timer1.Enabled = false;
            //cuando finaliza la partida aparece el cuadro para el nombre
            txtName.Visible = true;
            txtName.Enabled = true;
            btGuardar.Visible = true;
            btGuardar.Enabled = true;   
        }

        //mensaje con la puntuacion de la partida
        private void generarMensaje()
        {
            MessageBox.Show("****PUNTUACIÓN****\n- - - "+txtName.Text+" - - -\n- - - "+puntos.ToString()+" - - -");
        }

        //esconder-desactivar juego y mostrar-activar menu
        private void menuConfiguracion()
        {   
            gb1.Visible = false;
            gb1.Enabled = false;
            gb2.Visible = true;
            gb2.Enabled = true;
        }

        //devolver operador aritmetico segun el nivel seleccionado
        private char operadorYrangoElegido()
        {
            int op;
            char operador='+';
            switch (nivel)
            {
                case 1:
                    operador = '+';
                    rango = 10;
                    break;
                case 2:
                    op = aleatorio.Next(2) + 1;
                    if (op == 1) operador = '+';
                    else operador = '-';
                    rango = 10;
                    break;
                case 3:
                    op = aleatorio.Next(3) + 1;
                    if (op == 1) operador = '+';
                    else if (op == 2) operador = '-';
                    else operador = '*';
                    rango = 10;
                    break;
                case 4:
                    op = aleatorio.Next(4) + 1;
                    if (op == 1) operador = '+';
                    else if (op == 2) operador = '-';
                    else if (op == 3) operador = '*';
                    else operador = '/';
                    rango = 20;
                    break;

            }
             return operador; 
        }
    }
}
