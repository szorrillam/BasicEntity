using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityEscalante
{
    public partial class Form1 : Form
    {
        Context db = new Context();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var escritor = db.Escritores
                .Include(x => x.Libros)//Eager Loading
                .FirstOrDefault(x => x.Id == 1);

            var librosEscritos = escritor.Libros;

            var libro = db.Libros.Find(1);
            var _escritor = libro.Escritor;//Lazy Loading
            var _escritorTodosLibros = libro.Escritor.Libros;
        }
    }
}
