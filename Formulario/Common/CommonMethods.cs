using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario.Common
{
    class CommonMethods : Form
    {
        #region PictureBox e utilitários de imagem
        public void DisablePictureBox(PictureBox pictureBox)
        {
            pictureBox.BackColor = Color.Gray;
            pictureBox.Image = MakeImageTransparent(pictureBox.Image, 0.5f);
        }
        private Image MakeImageTransparent(Image image, float opacity)
        {
            if (image == null) return null;

            Bitmap bmp = new Bitmap(image.Width, image.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                ColorMatrix colorMatrix = new ColorMatrix
                {
                    Matrix33 = opacity // Define a opacidade (0.0f a 1.0f)
                };
                ImageAttributes imgAttributes = new ImageAttributes();
                imgAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                g.DrawImage(image,
                    new Rectangle(0, 0, bmp.Width, bmp.Height),
                    0, 0, image.Width, image.Height,
                    GraphicsUnit.Pixel,
                    imgAttributes);
            }

            return bmp;
        }
        #endregion



    }
}
