using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asteria_Restaurant_Otamasyonu
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı '_Asteria_s_Asian_RestaurantDataSet.ÜrünBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ürünBilgiTableAdapter.Fill(this._Asteria_s_Asian_RestaurantDataSet.ÜrünBilgi);
            // TODO: Bu kod satırı '_Asteria_s_Asian_RestaurantDataSet.JapaneseFood' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.japaneseFoodTableAdapter.Fill(this._Asteria_s_Asian_RestaurantDataSet.JapaneseFood);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
