using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OzIMDB
{
    public partial class Form1 : Form
    {
        private string dbName = "OzImdb";
        SqlConnection con = new SqlConnection("server=.;uid=sa; pwd=123;");
        private BindingList<Film> filmler;
        private bool guncellemeAktif = false;

        public Form1()
        {
            con.Open();
            VeriTabaniYoksaOlustur();
            InitializeComponent();
            FilmleriListele();
        }

        private void FilmleriListele()
        {
            guncellemeAktif = false;
            var cmd = new SqlCommand("Select * from Filmler", con);
            var dr = cmd.ExecuteReader();

            filmler = new BindingList<Film>();

            while (dr.Read())
            {
                filmler.Add(new Film()
                {
                    Id = (int)dr["Id"],
                    FilmAd = (string)dr["FilmAD"],
                    Puan = dr["Puan"] as int?,
                    Foto = ConvertToImage(dr["Foto"] as byte[])
                });
            }
            dr.Close();
            lstFilmler.DataSource = filmler;
            //pboFoto.Image = filmler[0].Foto;

            guncellemeAktif = true;
        }

        private void VeriTabaniYoksaOlustur()
        {
            var cmd = new SqlCommand($"Select DB_ID('{dbName}')", con);
            short? sonuc = cmd.ExecuteScalar() as short?;
            if (!sonuc.HasValue) //sonuc==null
            {
                cmd = new SqlCommand($"CREATE DATABASE {dbName};", con);
                cmd.ExecuteNonQuery();

                cmd = new SqlCommand($"USE {dbName};"
                                     + @"CREATE TABLE Filmler
(
                                      Id INT PRIMARY KEY IDENTITY, 
                                      FilmAd NVARCHAR(200) NOT NULL,
                                      Puan INT NULL,
                                      Foto VARBINARY(MAX) NULL
);"
                    , con);
                cmd.ExecuteNonQuery();
            }
            else
            {
                cmd = new SqlCommand($"USE {dbName}", con);
                cmd.ExecuteNonQuery();
            }
        }

        private Image ConvertToImage(byte[] data)
        {
            if (data == null)
            {
                return null;
            }

            return (Image)new ImageConverter().ConvertFrom(data);
        }

        private void btnYeniFilm_Click(object sender, EventArgs e)
        {
            int id = YeniFilmEkle();
            FilmleriListele();

            //foreach (var item in lstFilmler.Items)
            //{
            //    Film film = (Film)item;
            //    if (film.Id == id)
            //    {
            //        lstFilmler.SelectedItem = item;
            //        break;
            //        ;
            //    }
            //}

            lstFilmler.SelectedValue = id;

        }

        private int YeniFilmEkle()
        {
            var cmd = new SqlCommand("Insert into Filmler(FilmAd) Values(N'Yeni Film'); Select Scope_Identity();", con);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        private void lstFilmler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFilmler.SelectedIndex == -1)
            {
                return;
            }

            guncellemeAktif = false;
            Film film = (Film)lstFilmler.SelectedItem;
            txtFilmId.Text = film.Id.ToString();
            txtFilmAd.Text = film.FilmAd;
            pboFoto.Image = film.Foto;

            #region Puanı Goster
            if (film.Puan == null)
            {
                rbPuanYok.Checked = true;
            }
            else
            {
                #region Yontem 1
                //RadioButton rb;
                //foreach (Control control in gboPuan.Controls)
                //{
                //    if (control is RadioButton
                //        && control.Tag != null
                //        && control.Tag.ToString() == film.Puan.ToString())
                //    {
                //        ((RadioButton)control).Checked = true;
                //        break;
                //    }
                //} 
                #endregion

                #region Yontem 2
                RadioButton[] rbDizi = { rbPuanYok, rbPuan1, rbPuan2, rbPuan3, rbPuan4, rbPuan5 };
                rbDizi[film.Puan.Value].Checked = true;
                #endregion
            }
            #endregion

            pboFoto.Image = film.Foto;
            guncellemeAktif = true;

        }

        private void txtFilmAd_TextChanged(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void Guncelle()
        {
            if (guncellemeAktif && lstFilmler.SelectedIndex > -1)
            {
                Film film = (Film)lstFilmler.SelectedItem;
                film.FilmAd = txtFilmAd.Text;
                film.Puan = SeciliPuan();
                film.Foto = pboFoto.Image;

                var cmd = new SqlCommand("Update filmler set FilmAd = @p1, Puan = @p2 , Foto = @p3 where Id = @p4", con);
                cmd.Parameters.AddWithValue("@p1", film.FilmAd);
                cmd.Parameters.AddWithValue("@p2", (object)film.Puan ?? SqlBinary.Null);
                cmd.Parameters.AddWithValue("@p3", (object)ConvertToByteArray(film.Foto) ?? SqlBinary.Null);
                cmd.Parameters.AddWithValue("@p4", film.Id);
                cmd.ExecuteNonQuery();
                filmler.ResetBindings();
            }
        }


        private int? SeciliPuan()
        {
            RadioButton rb = null;
            foreach (Control control in gboPuan.Controls)
            {
                if (control is RadioButton)
                {
                    rb = (RadioButton)control;

                    if (rb.Checked)
                    {
                        break;
                    }
                }
            }

            return rb.Tag == null ? null as int? : Convert.ToInt32(rb.Tag);

        }

        // RadioButton seçimi kalkan ve secilen dahil ikisi etkileniyor.
        // bu kod ile seçimi kalkan etkilenmez çünkü (checked false)
        private void rbPuanYok_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                Guncelle();
            }
        }

        private void pboFoto_Click(object sender, EventArgs e)
        {

            if (lstFilmler.SelectedIndex == -1)
            {
                return;
            }
            DialogResult dr = openFileDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                pboFoto.Image = Image.FromFile(openFileDialog1.FileName);
                Guncelle();
            }
        }
        public byte[] ConvertToByteArray(Image image)
        {
            ImageConverter _imageConverter = new ImageConverter();
            byte[] xByte = (byte[])_imageConverter.ConvertTo(image, typeof(byte[]));
            return xByte;
        }

        private void lstFilmler_KeyDown(object sender, KeyEventArgs e)
        {
            int sid = lstFilmler.SelectedIndex;
            if (e.KeyCode == Keys.Delete == lstFilmler.SelectedIndex > -1)
            {
                Film film = (Film) lstFilmler.SelectedItem;
                filmler.Remove(film);
                FilmSil(film.Id);

                if (sid == lstFilmler.SelectedIndex)
                {
                    lstFilmler.SelectedIndex = -1;
                    lstFilmler.SelectedIndex = sid;
                }
                else if (lstFilmler.SelectedIndex == -1)
                {
                    FormuTemizle();
                }
            }
        }

        private void FormuTemizle()
        {
            txtFilmAd.Clear();
            txtFilmId.Clear();
            rbPuanYok.Checked = true;
            pboFoto.Image = null;
        }

        private void FilmSil(int Id)
        {
            var cmd = new  SqlCommand("Delete from filmler where Id = " +Id,con);
            cmd.ExecuteNonQuery();
        }

        private void txtFilmAd_Leave(object sender, EventArgs e)
        {
            if (txtFilmAd.Text.Trim() == "")
            {
                
                txtFilmAd.Focus();
            }
        }
    }
}
