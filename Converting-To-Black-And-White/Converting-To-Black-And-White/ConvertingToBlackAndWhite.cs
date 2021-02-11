using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converting_To_Black_And_White
{
    public partial class ConvertingToBlackAndWhite : Form
    {
        public ConvertingToBlackAndWhite()
        {
            InitializeComponent();
        }

        //Кнопка btnOpen
        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //фильтр форматов файлов
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    PictureOriginal.Image = new Bitmap(ofd.FileName);
                }
                catch
                {
                    MessageBox.Show("File cannot be opened", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Кнопка btnSave
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (PictureGray.Image != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();

                sfd.Title = "Save as...";
                sfd.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";

                //если в диалоге была нажата кнопка ОК
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        PictureGray.Image.Save(sfd.FileName);
                    }
                    catch
                    {
                        MessageBox.Show("Unable to save image", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                MessageBox.Show("File not found", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Кнопка btnConvert
        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (PictureOriginal.Image != null)
            {
                //создаём Bitmap из изображения, находящегося в PictureOriginal
                Bitmap input = new Bitmap(PictureOriginal.Image);

                //создаём Bitmap для черно-белого изображения
                Bitmap output = new Bitmap(input.Width, input.Height);

                for (int j = 0; j < input.Height; j++)
                    for (int i = 0; i < input.Width; i++)
                    {
                        UInt32 pixel = (UInt32)(input.GetPixel(i, j).ToArgb());
                        //получаем компоненты цветов пикселя
                        float R = (float)((pixel & 0x00FF0000) >> 16); //красный
                        float G = (float)((pixel & 0x0000FF00) >> 8); //зеленый
                        float B = (float)(pixel & 0x000000FF); //синий
                                                               //делаем цвет черно-белым (оттенки серого) - находим среднее арифметическое
                        R = G = B = (R + G + B) / 3.0f;
                        //собираем новый пиксель по частям (по каналам)
                        UInt32 newPixel = 0xFF000000 | ((UInt32)R << 16) | ((UInt32)G << 8) | ((UInt32)B);
                        //добавляем его в Bitmap нового изображения
                        output.SetPixel(i, j, Color.FromArgb((int)newPixel));
                    }
                // выводим черно-белый Bitmap в PictureGray
                PictureGray.Image = output;
            }
            else 
            {
                MessageBox.Show("File not found", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
