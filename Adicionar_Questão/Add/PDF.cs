using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Add
{
    class PDF
    {
        public static Document document = new Document();
        public static Font.FontFamily familia = new Font.FontFamily();
        public static void set_pdf()
        {
            document.SetPageSize(PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream("lista.pdf", FileMode.Create));
            familia = iTextSharp.text.Font.FontFamily.COURIER;
            Font fonte = new Font(familia, 24, (int)System.Drawing.FontStyle.Regular);
            document.Open();
        }
        public static void set_paragrafo(string p)
        {
            familia = iTextSharp.text.Font.FontFamily.COURIER;
            Font fonte = new Font(familia, 24, (int)System.Drawing.FontStyle.Regular);
            Paragraph x = new Paragraph(p, fonte);
            x.Alignment = Element.ALIGN_JUSTIFIED;
            document.Add(x);
            // document.Close();
            // Process.Start("lista.pdf");
        }
        public static void set_img(string caminho)
        {
            //string caminho = ao caminho da imagem/retirar do banco
            Image Img = Image.GetInstance(caminho);
            Img.ScalePercent(30, 30);//Ajusta o tamanho da imagem
            Img.Alignment = 1;
            document.Add(Img);
        }
        public static void set_table(int c, int r)
        {
            //c = datagridview1.columns.count;
            //r = datagridview.rows.count;
            PdfPTable table = new PdfPTable(c);
            table.HeaderRows = 1;
            for (int i = 0; i < c; i++)
            {
                for (int k = 0; k < r; k++)
                {
                    if (i > k)
                    {
                    }
                }
            }
        }
        public static void encerrar()
        {
            document.Close();
            Process.Start("lista.pdf");
        }
    }
}