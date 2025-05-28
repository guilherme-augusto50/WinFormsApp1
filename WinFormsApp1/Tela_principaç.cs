using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Tela_principaç : Form
    {
        private int usuarioId;
        public Tela_principaç(int idusuario)
        {
            InitializeComponent();
            this.usuarioId = idusuario;
        }

        private void Tela_principaç_Load(object sender, EventArgs e)
        {
        }
    }
}
