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
        List<Alumno> listaAlumnosEliminados = new List<Alumno>();
        Validaciones validar = new Validaciones();
        public Form1()
        {
            InitializeComponent();
        }


        //BOTON AGREGAR ALUMNO
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

        
        //BOTON GUARDAR XML
        private void tsSaveXML_Click(object sender, EventArgs e)
        {
            //crear archivo xml
            XmlSerializer codificador = new XmlSerializer(typeof(List<Alumno>));
            TextWriter escribirXml = new StreamWriter("..\\..\\..\\..\\Archivos\\listaAlumnos.xml"); ;
            codificador.Serialize(escribirXml, listaAlumnos);
            escribirXml.Close();
        }


        //boton abrir XML
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

        


        //EVENTO CARGAR FORMULARIO
        private void Form1_Load(object sender, EventArgs e)
        {
            //carga los datos del xml
            //generar un lista con esos datos
            //mostrar esa lista en el DG
            listaAlumnos.Clear();
            listaAlumnosEliminados.Clear();

            if (File.Exists("..\\..\\..\\..\\Archivos\\listaAlumnos.xml"))
            {
                XmlSerializer codificador = new XmlSerializer(typeof(List<Alumno>));
                FileStream leerXml = File.OpenRead("..\\..\\..\\..\\Archivos\\listaAlumnos.xml");
                listaAlumnos = (List<Alumno>)codificador.Deserialize(leerXml);
                leerXml.Close();
            }


            if (File.Exists("..\\..\\..\\..\\Archivos\\listaAlumnosEliminados.xml"))
            {
                XmlSerializer codificador = new XmlSerializer(typeof(List<Alumno>));
                FileStream leerXml = File.OpenRead("..\\..\\..\\..\\Archivos\\listaAlumnosEliminados.xml");
                listaAlumnosEliminados = (List<Alumno>)codificador.Deserialize(leerXml);
                leerXml.Close();
            }

            //llenamos grid estudiantes activos
            dgTablaDAtos.DataSource = null;
            dgTablaDAtos.DataSource = listaAlumnos;

            //llenamos grid estudiantes eliminados
            dgTablaDAtosEliminados.DataSource = null;
            dgTablaDAtosEliminados.DataSource = listaAlumnosEliminados;
        }


        //EVENTO CERRAR FORMULARIO
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Cuando se cierra se guarda la informacion
            //crear archivo xml
            XmlSerializer codificador = new XmlSerializer(typeof(List<Alumno>));
            TextWriter escribirXml = new StreamWriter("..\\..\\..\\..\\Archivos\\listaAlumnos.xml"); 
            codificador.Serialize(escribirXml, listaAlumnos);
            escribirXml.Close();

            //crar archivo con lista de alumnos eliminados
            TextWriter escribirXmlEliminados = new StreamWriter("..\\..\\..\\..\\Archivos\\listaAlumnosEliminados.xml");
            codificador.Serialize(escribirXmlEliminados, listaAlumnosEliminados);
            escribirXmlEliminados.Close();
        }

        //BOTON SALIR
        private void tsExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        
        //BOTON BUSCAR DEL MENU
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


                        //activar botones
                        tsEditUser.Enabled = true;
                        tsDeleteUser.Enabled = true;
                        txtCodigoIn.Enabled = false;
                        tsRecoverUser.Enabled = false;
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

        private void tsEditUser_Click(object sender, EventArgs e)
        {
            //editar 
            //hace las validaciones
            //validaciones
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
                                                            GuardarCambios();

                                                                }

            

        }

       

        private void tsDeleteUser_Click(object sender, EventArgs e)
        {
            //borrar ddatos del estudiante

            DialogResult confirmarBorrar = MessageBox.Show("Esta seguro que desea borrar?", "Confirmar Borrada", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (confirmarBorrar == DialogResult.OK)
            {
                Alumno miAlumno = obtenerDatos(Convert.ToInt32(txtCodigoIn.Text));
                InsertarDatosEliminados(miAlumno);
                listaAlumnos.Remove(miAlumno);
                dgTablaDAtos.DataSource = null;
                dgTablaDAtos.DataSource = listaAlumnos;

                //activar los botones
                tsEditUser.Enabled = false;
                tsDeleteUser.Enabled = false;
                txtCodigoIn.Enabled = true;
                Limpiar();
            }
            
        }


        private void tsRecoverUser_Click(object sender, EventArgs e)
        {
            //VAMOS A BUSCAR UN ALUMNO POR CODIGO

            
            int idMayor;

            DialogResult confirmarBorrar = MessageBox.Show("Desea recuperar el alumno del codigo que ingreso?", "Confirmar restauración", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (confirmarBorrar == DialogResult.OK) { 
                //valido que entrada no este vacia
                if (!validar.Vacio(txtCodigoIn, errorM, "Ingrese el codigo que desea buscar"))
                if (!validar.TipoNumero(txtCodigoIn, errorM, "El valor del codigo debe ser numerico"))
                {
                    if (ExsiteCodigoEliminado(Convert.ToInt32(txtCodigoIn.Text)))
                    {
                        if (!ExsiteCodigo(Convert.ToInt32(txtCodigoIn.Text)))
                        {
                            Alumno myAlumno = obtenerDatosEliminado(Convert.ToInt32(txtCodigoIn.Text));
                            txtNombreIn.Text = myAlumno.Nombre;
                            txtCorreoIn.Text = myAlumno.Correo;
                            txtNota1In.Text = myAlumno.Nota1.ToString();
                            txtNota2In.Text = myAlumno.Nota2.ToString();
                            txtNota3In.Text = myAlumno.Nota3.ToString();
                            txtNota4In.Text = myAlumno.Nota4.ToString();
                            //agregamos alumno a lista de estudiantes activos
                            listaAlumnos.Add(myAlumno);

                            //removemos alumno recuperado de la lista de eliminados
                            listaAlumnosEliminados.Remove(myAlumno);

                            //actualizo el DG o visualizo informacion
                            dgTablaDAtos.DataSource = null;
                            dgTablaDAtos.DataSource = listaAlumnos;

                            //actualizo el DG de alumnos eliminados o visualizo informacion
                            dgTablaDAtosEliminados.DataSource = null;
                            dgTablaDAtosEliminados.DataSource = listaAlumnosEliminados;
                        }
                        else
                        {
                            idMayor = BuscarCodigoMayor(Convert.ToInt32(txtCodigoIn.Text));
                            idMayor++;


                            Alumno myAlumno = obtenerDatosEliminado(Convert.ToInt32(txtCodigoIn.Text));

                            //removemos alumno recuperado de la lista de eliminados
                            listaAlumnosEliminados.Remove(myAlumno);


                            myAlumno.Codigo = idMayor;
                            txtCodigoIn.Text = myAlumno.Codigo.ToString();
                            txtNombreIn.Text = myAlumno.Nombre;
                            txtCorreoIn.Text = myAlumno.Correo;
                            txtNota1In.Text = myAlumno.Nota1.ToString();
                            txtNota2In.Text = myAlumno.Nota2.ToString();
                            txtNota3In.Text = myAlumno.Nota3.ToString();
                            txtNota4In.Text = myAlumno.Nota4.ToString();

                            //agregamos alumno a lista de estudiantes activos
                            listaAlumnos.Add(myAlumno);

                            

                            //actualizo el DG o visualizo informacion
                            dgTablaDAtos.DataSource = null;
                            dgTablaDAtos.DataSource = listaAlumnos;

                            //actualizo el DG de alumnos eliminados o visualizo informacion
                            dgTablaDAtosEliminados.DataSource = null;
                            dgTablaDAtosEliminados.DataSource = listaAlumnosEliminados;

                        }




                        //activar botones
                        tsEditUser.Enabled = true;
                        tsDeleteUser.Enabled = true;
                        txtCodigoIn.Enabled = false;
                    }
                    else if (ExsiteCodigo(Convert.ToInt32(txtCodigoIn.Text)))
                    {

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

        /* ***************MIS METODOS ******************* */

        //Agregamos un alumno y a sus propiedades les asignamos los valores de las cajas de texto
        //agregamos este objeto a la lista 
        //visualizamos la lista en la GRID
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


        private void InsertarDatosEliminados(Alumno alumnoEliminado)
        {
                   

            //agrego el objeto alumno al areglo
            listaAlumnosEliminados.Add(alumnoEliminado);

            //llenamos grid estudiantes eliminados
            dgTablaDAtosEliminados.DataSource = null;
            dgTablaDAtosEliminados.DataSource = listaAlumnosEliminados;
        }
        private void GuardarCambios()
        {
            //EDITAR LOS DATOS

            Alumno miAlumno = obtenerDatos(Convert.ToInt32(txtCodigoIn.Text));
            miAlumno.Nombre = txtNombreIn.Text;
            miAlumno.Correo = txtCorreoIn.Text;
            miAlumno.Nota1 = Convert.ToDouble(txtNota1In.Text);
            miAlumno.Nota2 = Convert.ToDouble(txtNota2In.Text);
            miAlumno.Nota3 = Convert.ToDouble(txtNota3In.Text);
            miAlumno.Nota4 = Convert.ToDouble(txtNota4In.Text);

            miAlumno.NotaFinal = (miAlumno.Nota1 + miAlumno.Nota2 + miAlumno.Nota3 + miAlumno.Nota4) / 4;

            if (miAlumno.NotaFinal >= 3.5)
            {
                miAlumno.NotaConcepto = "Aprobado";

            }
            else
            {
                miAlumno.NotaConcepto = "Reprobado";
            }

            dgTablaDAtos.DataSource = null;
            dgTablaDAtos.DataSource = listaAlumnos;

            //activar los botones
            tsEditUser.Enabled = false;
            tsDeleteUser.Enabled = true;
            txtCodigoIn.Enabled = true;
            tsRecoverUser.Enabled = true;
            Limpiar();
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

        //capturar datos de busqueda
        //Retorna un objeto alumno de la lista con el codigo de la caja de texto
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

        //capturar datos de busqueda eliminados
        //Retorna un objeto alumno de la lista de eliminados con el codigo de la caja de texto
        private Alumno obtenerDatosEliminado(int cod)
        {
            foreach (Alumno miAlumno in listaAlumnosEliminados)
            {
                if (miAlumno.Codigo == cod)
                {
                    return miAlumno;
                }
            }
            return null;
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

        //validamos que el codigo exista en la lista
        //Retorna un false o true
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

        //validamos que el codigo exista en la lista
        //Retorna un false o true
        private Boolean ExsiteCodigoEliminado(int codigo)
        {
            foreach (Alumno miAlumno in listaAlumnosEliminados)
            {
                if (miAlumno.Codigo == codigo)
                {
                    return true;
                }
            }
            return false;
        }


        //validamos que el codigo exista en la lista
        //Retorna un false o true
        private int BuscarCodigoMayor(int codigo)
        {
            int mayor = codigo;
            foreach (Alumno miAlumno in listaAlumnos)
            {
                if (miAlumno.Codigo > mayor)
                {
                    mayor = miAlumno.Codigo;
                }
            }
            return mayor;
        }


    }
}
