using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Medifarma
{
    public partial class LeitorArquivoXML : Form
    {
        public LeitorArquivoXML()
        {
            InitializeComponent();
        }

        private void LeitorArquivoXML_Load(object sender, EventArgs e)
        {
            MouseDown += new MouseEventHandler(LeitorArquivoXML_MouseDown);
            MouseMove += new MouseEventHandler(LeitorArquivoXML_MouseMove);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnProcurarXML_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtXML.Text = openFileDialog1.FileName;
            }
        }

        private void btnXML_Click(object sender, EventArgs e)
        {
            XmlTextReader reader = new XmlTextReader(txtXML.Text);
            ArrayList elementos = new ArrayList();

            while ((reader.Read()))
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        if (reader.HasAttributes)
                        {
                            while (reader.MoveToNextAttribute())
                            {
                                elementos.Add(reader.Value);
                            }
                        }
                        break;
                    case XmlNodeType.Text:
                        elementos.Add(reader.Value);
                        break;
                }
            }
            foreach (var num in elementos)
            {
                listXML.Items.Add(num);
            }
        }
        int x, y;
        private void LeitorArquivoXML_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            {
                x = Left - MousePosition.X;
                y = Top - MousePosition.Y;
            }
        }

        private void LeitorArquivoXML_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            {
                Left = x + MousePosition.X;
                Top = y + MousePosition.Y;
            }
        }
    }
}
