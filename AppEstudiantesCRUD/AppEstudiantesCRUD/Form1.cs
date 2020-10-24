using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;//manejo de archivos xml
using System.IO;

namespace AppEstudiantesCRUD
{
    public partial class Form1 : Form
    {
        List<Alumno> listaAlumnos = new List<Alumno>();
        Validaciones validar = new Validaciones();
        public Form1()
        {
            InitializeComponent();
        }

        private void tsAddUser_Click(object sender, EventArgs e)
        {
            //el codigo para agregar un alumno

            //validaciones
            if (!validar.Vacio(txtCodigoIn, errorM, "El código no puede estar vacío"))
                if (!validar.TipoNumero(txtCodigoIn, errorM, "Debe de ingresar numeros"))
                    if (!validar.Vacio(txtNombreIn, errorM, "El nombre no puede estar vacío"))
                      if (!validar.TipoTexto(txtNombreIn, errorM, "Debe de ingresar texto"))
                         if (!validar.Vacio(txtCorreoIn, errorM, "El correo no puede estar vacío"))
                                if (validar.TipoCorreo(txtCorreoIn, errorM, "El formato del correo no es válido."))
                                    if (!validar.Vacio(txtNota1In, errorM, "La nota 1 no puede estar vacía"))
                                        if (!validar.TipoNumero(txtNota1In, errorM, "Debe de ingresar numeros"))
                                            if (!validar.Vacio(txtNota2In, errorM, "La nota 2 no puede estar vacía"))
                                                if (!validar.TipoNumero(txtNota2In, errorM, "Debe de ingresar numeros"))
                                                    if (!validar.Vacio(txtNota3In, errorM, "La nota 3 no puede estar vacía"))
                                                        if (!validar.TipoNumero(txtNota3In, errorM, "Debe de ingresar numeros"))
                                                            if (!validar.Vacio(txtNota4In, errorM, "La nota 4 no puede estar vacía"))
                                                                if (!validar.TipoNumero(txtNota4In, errorM, "Debe de ingresar numeros"))
                                                                {
                                                                    if (!ExsiteCodigo(Int32.Parse(txtCodigoIn.Text)))
                                                                    {
                                                                        InsertarDatos();
                                                                        Limpiar();
                                                                        errorM.Clear();
                                                                    }
                                                                    else
                                                                    {
                                                                        errorM.SetError(txtCodigoIn, "el codigo ya existe");
                                                                        txtCodigoIn.Focus();
                                                                        return;
                                                                    }
                                                    
                                                }
            
        }

        private void verArreglo()
        {
            foreach (Alumno itemAlumno in listaAlumnos)
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine(itemAlumno.Codigo);
                Console.WriteLine(itemAlumno.Nombre);
                Console.WriteLine(itemAlumno.Correo);
                Console.WriteLine(itemAlumno.Nota1);
                Console.WriteLine(itemAlumno.Nota2);
                Console.WriteLine(itemAlumno.Nota3);
                Console.WriteLine(itemAlumno.Nota4);
                Console.WriteLine(itemAlumno.NotaFinal);
                Console.WriteLine(itemAlumno.NotaConcepto);
                Console.WriteLine("---------------------------");
            }
        }

        private void tsSaveXML_Click(object sender, EventArgs e)
        {
            //crear archivo xml
            XmlSerializer codificador = new XmlSerializer(typeof(List<Alumno>));
            TextWriter escribirXml = new StreamWriter("..\\..\\..\\..\\Archivos\\listaAlumnos.xml"); ;
            codificador.Serialize(escribirXml, listaAlumnos);
            escribirXml.Close();
        }

        private void tsOpenXml_Click(object sender, EventArgs e)
        {
            //carga los datos del xml
            //generar un lista con esos datos
            //mostrar esa lista en el DG
            listaAlumnos.Clear();
            XmlSerializer codificador = new XmlSerializer(typeof(List<Alumno>));
            FileStream leerXml = File.OpenRead("..\\..\\..\\..\\Archivos\\listaAlumnos.xml");
            listaAlumnos = (List<Alumno>)codificador.Deserialize(leerXml);
            leerXml.Close();
            dgTablaDAtos.DataSource = null;
            dgTablaDAtos.DataSource = listaAlumnos;

        }

        private void InsertarDatos()
        {
            //agregar alumno
            Alumno objAlumno = new Alumno();

            objAlumno.Codigo = Convert.ToInt32(txtCodigoIn.Text);
            objAlumno.Nombre = txtNombreIn.Text;
            objAlumno.Correo = txtCorreoIn.Text;
            objAlumno.Nota1 = Convert.ToDouble(txtNota1In.Text);
            objAlumno.Nota2 = Convert.ToDouble(txtNota2In.Text);
            objAlumno.Nota3 = Convert.ToDouble(txtNota3In.Text);
            objAlumno.Nota4 = Convert.ToDouble(txtNota4In.Text);
            objAlumno.NotaFinal = (objAlumno.Nota1 + objAlumno.Nota2 + objAlumno.Nota3 + objAlumno.Nota4) / 4;
            if (objAlumno.NotaFinal >= 3.5)
            {
                objAlumno.NotaConcepto = "Aprobado";
            }
            else
            {
                objAlumno.NotaConcepto = "No aprobado";
            }

            //agrego el objeto alumno al areglo
            listaAlumnos.Add(objAlumno);

            //alimnti el DG o visualizo informacion
            dgTablaDAtos.DataSource = null;
            dgTablaDAtos.DataSource = listaAlumnos;
            //verArreglo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //carga los datos del xml
            //generar un lista con esos datos
            //mostrar esa lista en el DG
            listaAlumnos.Clear();

            if (File.Exists("..\\..\\..\\..\\Archivos\\listaAlumnos.xml"))
            {
                XmlSerializer codificador = new XmlSerializer(typeof(List<Alumno>));
                FileStream leerXml = File.OpenRead("..\\..\\..\\..\\Archivos\\listaAlumnos.xml");
                listaAlumnos = (List<Alumno>)codificador.Deserialize(leerXml);
                leerXml.Close();
            }
            
            dgTablaDAtos.DataSource = null;
            dgTablaDAtos.DataSource = listaAlumnos;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //crear archivo xml
            XmlSerializer codificador = new XmlSerializer(typeof(List<Alumno>));
            TextWriter escribirXml = new StreamWriter("..\\..\\..\\..\\Archivos\\listaAlumnos.xml"); ;
            codificador.Serialize(escribirXml, listaAlumnos);
            escribirXml.Close();
        }

        private void tsExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //limpiamos
        private void Limpiar()
        {
            txtCodigoIn.Clear();
            txtNombreIn.Clear();
            txtCorreoIn.Clear();
            txtNota1In.Clear();
            txtNota2In.Clear();
            txtNota3In.Clear();
            txtNota4In.Clear();
            txtCodigoIn.Focus();
        }

        //limpiamos
        private void Limpiar2()
        {
            txtNombreIn.Clear();
            txtCorreoIn.Clear();
            txtNota1In.Clear();
            txtNota2In.Clear();
            txtNota3In.Clear();
            txtNota4In.Clear();
            txtCodigoIn.Focus();
        }

        //funcion para validar registros

        //validamos codigo
        private Boolean ExsiteCodigo(int codigo)
        {
            foreach (Alumno miAlumno in listaAlumnos)
            {
                if (miAlumno.Codigo == codigo)
                {
                    return true;
                }
            }
            return false;
        }

        //capturar datos de busqueda
        private Alumno obtenerDatos(int cod)
        {
            foreach (Alumno miAlumno in listaAlumnos)
            {
                if (miAlumno.Codigo == cod)
                {
                    return miAlumno;
                }
            }
            return null;
        }

        private void tsSearchUser_Click(object sender, EventArgs e)
        {
            //VAMOS A BUSCAR UN ALUMNO POR CODIGO
            


            //valido que entrada no este vacia
            if (!validar.Vacio(txtCodigoIn,errorM, "Ingrese el codigo que desea buscar"))
                if (!validar.TipoNumero(txtCodigoIn, errorM, "El valor del codigo debe ser numerico"))
                {
                    if (ExsiteCodigo(Convert.ToInt32(txtCodigoIn.Text)))
                    {
                        Alumno myAlumno = obtenerDatos(Convert.ToInt32(txtCodigoIn.Text));
                        txtNombreIn.Text = myAlumno.Nombre;
                        txtCorreoIn.Text = myAlumno.Correo;
                        txtNota1In.Text = myAlumno.Nota1.ToString();
                        txtNota2In.Text = myAlumno.Nota2.ToString();
                        txtNota3In.Text = myAlumno.Nota3.ToString();
                        txtNota4In.Text = myAlumno.Nota4.ToString();
                    }
                    else
                    {
                        errorM.SetError(txtCodigoIn, "El codigo ingresado no existe");
                        txtCodigoIn.Focus();
                        Limpiar2();
                        return;

                    }

                }
        }
    }
}
