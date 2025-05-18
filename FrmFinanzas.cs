using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MigraDocCore.DocumentObjectModel.Tables;
using MigraDocCore.DocumentObjectModel;
using MigraDocCore.Rendering;
using Controlador;

namespace CADER
{
    public partial class FrmFinanzas : Form
    {
        public FrmFinanzas()
        {
            InitializeComponent();
        }
        private void CargarFormularioEnPanel(Form formulario)
        {
            // Limpiar el panel antes de cargar un nuevo formulario
            PanelFinanzas.Controls.Clear();

            // Establecer la propiedad TopLevel a false
            formulario.TopLevel = false;

            // Establecer la propiedad FormBorderStyle a None si no quieres bordes
            formulario.FormBorderStyle = FormBorderStyle.None;

            // Agregar el formulario al panel
            PanelFinanzas.Controls.Add(formulario);

            // Establecer el tamaño del formulario al tamaño del panel
            formulario.Dock = DockStyle.Fill;

            // Mostrar el formulario
            formulario.Show();
        }
        private void BtnOfrendas_Click(object sender, EventArgs e)
        {

        }

        private void BtnOfrendas_Click_1(object sender, EventArgs e)
        {
            FrmOfrendas frmOfrendas = new FrmOfrendas();
            CargarFormularioEnPanel(frmOfrendas);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnCuotas_Click(object sender, EventArgs e)
        {
            FrmCuotas frm = new FrmCuotas();
            CargarFormularioEnPanel(frm);
        }
        public void GenerarPdf() {
            DataTable dataTable = CuotaController.CargarCuotas();
            // Si no hay datos, puedes informarlo y salir
            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron datos para generar el reporte.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // --- Paso 2: Configurar el lugar para guardar el archivo PDF ---
            string filePath = ""; // Variable para guardar la ruta final del archivo

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf"; // Filtro para solo archivos PDF
            saveFileDialog.Title = "Guardar Reporte PDF"; // Título del diálogo
            saveFileDialog.FileName = "Reporte_finanzas.pdf"; // Nombre de archivo sugerido

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDialog.FileName; // Obtener la ruta seleccionada por el usuario
            }
            else
            {
                return; // El usuario canceló el diálogo
            }

            // --- Paso 3: Generar el documento PDF usando MigraDoc ---
            try
            {
                // 3.1: Crear un nuevo documento MigraDoc
                Document document = new Document();
                document.Info.Title = "Reporte de Datos"; // Título en las propiedades del PDF

                // Agregar una sección al documento
                Section section = document.AddSection();
                section.PageSetup.PageFormat = PageFormat.A4; // Tamaño de página (ej. A4)
                section.PageSetup.LeftMargin = Unit.FromCentimeter(2); // Márgenes
                section.PageSetup.RightMargin = Unit.FromCentimeter(2);
                section.PageSetup.TopMargin = Unit.FromCentimeter(2.5);
                section.PageSetup.BottomMargin = Unit.FromCentimeter(2.5);


                // 3.2: Agregar contenido al documento (Título, Tabla, etc.)

                // Agregar un Título al reporte
                Paragraph title = section.AddParagraph("Reporte de Cuotas");
                title.Format.Font.Size = 16;
                title.Format.Font.Bold = true;
                title.Format.Alignment = ParagraphAlignment.Center; // Centrar título
                section.AddParagraph(); // Agregar un espacio en blanco después del título


                // 3.3: Agregar una Tabla con los datos del DataTable
                Table table = section.AddTable();
                table.Borders.Width = 0.75; // Grosor de los bordes de la tabla
                table.Borders.Color = new Color(0, 0, 0); // Color de los bordes (negro)
                table.Format.SpaceAfter = "1cm"; // Espacio después de la tabla

                // Definir las columnas de la tabla PDF basadas en las columnas del DataTable
                foreach (DataColumn column in dataTable.Columns)
                {
                    Column pdfColumn = table.AddColumn();
                    // Puedes ajustar el ancho de las columnas aquí si lo deseas
                     pdfColumn.Width = Unit.FromCentimeter(4); // Ejemplo: Ancho fijo de 3 cm
                    // O ajustar anchos relativos después de agregar todas las columnas si prefieres
                }

                // Opcional: Ajustar anchos relativos de las columnas después de agregarlas
                // Si tienes 4 columnas, puedes darles pesos relativos:
                // table.SetColumnWidth(0, Unit.FromCentimeter(1.5)); // Id
                // table.SetColumnWidth(1, Unit.FromCentimeter(6));   // Nombre
                // table.SetColumnWidth(2, Unit.FromCentimeter(2));   // Precio
                // table.SetColumnWidth(3, Unit.FromCentimeter(3));   // FechaAlta

                string[] titulosPersonalizados = {
                "ID",         // Título para la 1ª columna (índice 0)
                "Usuario",// Título para la 2ª columna (índice 1)
                "Cantidad de Cuota", // Título para la 3ª columna (índice 2)
                "Fecha de Cuota" // Título para la 4ª columna (índice 3)
                // ... Agrega un título por cada columna en tu consulta SQL ...
            };


                // Agregar la fila de Encabezado de la tabla
                Row headerRow = table.AddRow();
                headerRow.Format.Font.Bold = true; // Negrita para el encabezado
                headerRow.Shading.Color = new Color(220, 220, 220); // Fondo gris claro
                headerRow.VerticalAlignment = VerticalAlignment.Center; // Alinear verticalmente al centro

                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    string headerText = "";
                    // Usa el título personalizado si existe para este índice, de lo contrario usa el nombre de la columna original
                    if (i < titulosPersonalizados.Length)
                    {
                        headerText = titulosPersonalizados[i];
                    }
                    else
                    {
                        // Respaldo por si no hay título personalizado para esta columna
                        headerText = dataTable.Columns[i].ColumnName;
                    }

                    headerRow.Cells[i].AddParagraph(headerText); // <-- Usa el texto personalizado aquí
                    headerRow.Cells[i].Format.Alignment = ParagraphAlignment.Center;
                    headerRow.Cells[i].Format.Font.Bold = true;
                }

                // Agregar las filas de Datos a la tabla
                foreach (DataRow row in dataTable.Rows)
                {
                    Row dataRow = table.AddRow();
                    dataRow.VerticalAlignment = VerticalAlignment.Center;

                    for (int i = 0; i < dataTable.Columns.Count; i++)
                    {
                        // Agregar el contenido de la celda. row[i]?.ToString() maneja valores nulos.
                        dataRow.Cells[i].AddParagraph(row[i]?.ToString() ?? "");

                        // Opcional: Ajustar alineación por celda según el tipo de dato (ej. derecha para números)
                        // if (dataTable.Columns[i].DataType == typeof(decimal) || dataTable.Columns[i].DataType == typeof(int))
                        // {
                        //     dataRow.Cells[i].Format.Alignment = ParagraphAlignment.Right;
                        // }
                        // else
                        // {
                        //      dataRow.Cells[i].Format.Alignment = ParagraphAlignment.Left;
                        // }
                    }
                }

                // 3.4: Renderizar el documento MigraDoc a un documento PDFsharp
                // Esto convierte el modelo de documento de MigraDoc a la estructura de PDFsharp
                PdfDocumentRenderer pdfRenderer = new PdfDocumentRenderer(true);
                pdfRenderer.Document = document; // Asignar el documento MigraDoc
                pdfRenderer.RenderDocument(); // Realizar el renderizado

                // --- Paso 4: Guardar el documento PDFsharp ---
                // El documento ya está listo en pdfRenderer.PdfDocument
                pdfRenderer.PdfDocument.Save(filePath); // Guardar en el archivo especificado

                MessageBox.Show("Reporte generado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el PDF : " + ex.Message, "Error al Generar PDF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnReporte_Click(object sender, EventArgs e)
        {
            GenerarPdf();
        }
    }
}
