using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_system.Models
{
    internal class ModelsSetting : connection_db
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public byte[] CompanyLogo { get; set; }

        public Image GetLogoAsImage()
        {
            if (CompanyLogo == null || CompanyLogo.Length == 0)
            {
                return null;
            }

            try
            {
                using (MemoryStream ms = new MemoryStream(CompanyLogo))
                using (Image temp = Image.FromStream(ms))
                {
                    return new Bitmap(temp);
                }
            }
            catch
            {
                return null;
            }
        }

        public void SetLogoFromImage(Image image)
        {
            if (image == null)
            {
                CompanyLogo = null;
                return;
            }

            try
            {
                using (MemoryStream ms = new MemoryStream())
                using (Bitmap bmp = new Bitmap(image))
                {
                    bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    CompanyLogo = ms.ToArray();
                }
            }
            catch
            {
                CompanyLogo = null;
            }
        }
    }
}

