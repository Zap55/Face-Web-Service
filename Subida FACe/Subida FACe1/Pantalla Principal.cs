using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.Services3;
using Microsoft.Web.Services3.Security;
using Microsoft.Web.Services3.Security.Tokens;
using Microsoft.Web.Services3.Security.X509;
using Microsoft.Web.Services3.Design;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.IO;

namespace Subida_FACe1
{
    public partial class Form1 : Form
    {
        // El programa apunta al servidor de produccion https://webservice.face.gob.es/facturasspp?wsdl

        String valorRespuesta;
        String resultado;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.tbCarpetaFacturas.Text = "";//aquí va la ruta predefinida donde están las facturas en formato xml firmado
            this.tbEmail.Text = "";//email al que queremos que envíen las notificaciones de FACe
            this.tbRutaCertificado.Text = "";//ruta del certificado 
            this.tbContrasenaCertificado.Text = "";//contraseña del certificado
        }

        private void btSubir_Click(object sender, EventArgs e)
        {
            try
            {
                X509Certificate2 certificado = new System.Security.Cryptography.X509Certificates.X509Certificate2(this.tbRutaCertificado.Text, this.tbContrasenaCertificado.Text);

                Progreso progreso = new Progreso();
                progreso.Show();

                
                //Recorremos la carpeta y buscamos los archivos .Xsig, Necesita Using.System.IO

                string[] files = Directory.GetFiles(this.tbCarpetaFacturas.Text, "*.xsig");

                foreach (string file in files)
                {                    
                   valorRespuesta=mandarFra(certificado, file, this.tbEmail.Text).resultadoError;

                    if (valorRespuesta == "")
                    {
                        resultado = "Subida Correctamente";
                    }
                    else
                    {
                        resultado = valorRespuesta;
                    }

                   dgvResultado.Rows.Add(file.Substring(12, 6),resultado);
                }

                progreso.Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
        }

        //Los parámetros son: 
        //	El certificado a utilizar 
        //	el nombre del fichero .xsig a enviar al face 
        //	y la dirección de email a la que el face remitirá las notificaciones de como va procesando la factura utilizar 
        //	El resultado es del tipo resultadoEnvio 
        public static resultadoEnvio mandarFra(System.Security.Cryptography.X509Certificates.X509Certificate2 cert, string nombrefichero, string email)
        {
            resultadoEnvio resultado = new resultadoEnvio();
            resultado.ok = false;

            Subida_FACe.face.Service proxy = new Subida_FACe.face.Service();
            proxy.ClientCertificates.Add(cert);
            Subida_FACe.face.EnviarFacturaRequest factura = new Subida_FACe.face.EnviarFacturaRequest();

            X509SecurityToken signatureToken = new X509SecurityToken(cert);

            SoapContext requestContext = proxy.RequestSoapContext;
            requestContext.Security.Tokens.Add(signatureToken);
            MessageSignature sig = new MessageSignature(signatureToken);
            requestContext.Security.Timestamp.TtlInSeconds = 60;
            requestContext.Security.Elements.Add(sig);
            Subida_FACe.face.FacturaFile fraProduccion = new Subida_FACe.face.FacturaFile();
            factura.correo = email;
                        
            string line = System.IO.File.ReadAllText(nombrefichero, Encoding.UTF8);
            string fichero64;
            byte[] byt = System.Text.Encoding.UTF8.GetBytes(line);
            fichero64 = Convert.ToBase64String(byt);
            fraProduccion.factura = fichero64;
            fraProduccion.nombre = nombrefichero;
            fraProduccion.mime = "application/xml";
            factura.factura = fraProduccion;

                   
            try
            {
                Subida_FACe.face.EnviarFacturaResponse resultadoEnvioFactura = new Subida_FACe.face.EnviarFacturaResponse();
                string codRegistro = "";
                string codigoSeguimiento = "";
                string codigoResultado = "";
                string descripcionResultado = "";
                resultadoEnvioFactura = proxy.enviarFactura(factura);
                codigoResultado = resultadoEnvioFactura.resultado.codigo;
                descripcionResultado = resultadoEnvioFactura.resultado.descripcion;
                codigoSeguimiento = resultadoEnvioFactura.resultado.codigoSeguimiento;
                codRegistro = (resultadoEnvioFactura.factura == null) ? "" : resultadoEnvioFactura.factura.numeroRegistro;
                resultado.ok = true;
                resultado.referenciaOk = codRegistro;
                resultado.resultadoError = "";
                if (codigoResultado.Trim() != "0")
                {
                    //el codigo de resultado es distinto de cero indica error 
                    resultado.ok = false;
                    resultado.referenciaOk = "";
                    resultado.resultadoError = descripcionResultado;
                                                                               
                }
                
            }
            catch (Exception ex)
            {
                string aviso = ex.Message;
                Exception exProceso = ex;
                resultado.ok = false;
                resultado.referenciaOk = "";
                resultado.resultadoError = aviso;
                MessageBox.Show("Error: " + aviso);

            }
            return resultado;

        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            
           
        }

        private void btExportar_Click(object sender, EventArgs e)
        {
            exportarExcel(dgvResultado);
        }

        // Método que exporta a un fichero Excel el contenido de un DataGridView
        // <param name="grd">DataGridView que contiene los datos a exportar</param>
        private void exportarExcel(DataGridView grd)
        {
            SaveFileDialog fichero = new SaveFileDialog();
            fichero.Filter = "Excel (*.xls)|*.xls";

            if (fichero.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application aplicacion;
                Microsoft.Office.Interop.Excel.Workbook librostrabajo;
                Microsoft.Office.Interop.Excel.Worksheet hojatrabajo;
                aplicacion = new Microsoft.Office.Interop.Excel.Application();
                librostrabajo = aplicacion.Workbooks.Add();
                hojatrabajo = (Microsoft.Office.Interop.Excel.Worksheet)librostrabajo.Worksheets.get_Item(1);

                //guarda los datos del encabezado
                for (int i = 0; i < grd.ColumnCount; i++)
                {
                    hojatrabajo.Cells[1, i + 1] = grd.Columns[i].HeaderText;
                }

                //Recorremos el DataGridView rellenando la hoja de trabajo
                //for (int i = 0; i < grd.Rows.Count - 1; i++) //sirve para cuando dejamos el dgv en modo añadir.
                for (int i = 0; i < grd.Rows.Count; i++)
                {
                    for (int j = 0; j < grd.Columns.Count; j++)
                    {
                        hojatrabajo.Cells[i + 2, j + 1] = grd.Rows[i].Cells[j].Value.ToString();
                    }
                }

                librostrabajo.SaveAs(fichero.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                librostrabajo.Close(true);

                aplicacion.Quit();
            }
        }
        
        public class resultadoEnvio
        {
            public bool ok = false;
            public string referenciaOk = "";
            public string resultadoError = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resDr = MessageBox.Show("¿Quiere guardar el resultado de la subida?", "Salir de Subida FACe", MessageBoxButtons.OKCancel);
            if (resDr == DialogResult.OK)
            {
                exportarExcel(dgvResultado);
            }
            if (resDr == DialogResult.Cancel)
            {
                Application.Exit();
            }
            
        }

        private void btBuscarFacturas_Click_1(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.tbCarpetaFacturas.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btBuscarCertificado_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.tbRutaCertificado.Text = openFileDialog1.FileName;
            }
        }

        
    }
}
