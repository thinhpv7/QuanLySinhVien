using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace DO_AN_HE_QUAN_TRI
{
    public class HelperImage
    {
        public static byte[] convertImageLocationToByteArray(string imageLocation)
        {
            byte[] array = null;
            FileInfo fileInfo = new FileInfo(imageLocation);
            long imageFileLength = fileInfo.Length;
            FileStream fs = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            array = br.ReadBytes((int)imageFileLength);
            return array;
        }

        public static byte[] convertImageToByteArray(Image image)
        {
            MemoryStream stream = new MemoryStream();
            System.Drawing.Bitmap bitmap = (Bitmap)image;
            bitmap.Save(stream, ImageFormat.Jpeg);

            byte[] byteArray = stream.GetBuffer();
            return byteArray;
        }

        public static Image convertByteArrayToImage(byte[] byteImage)
        {
            Image img = null;
            MemoryStream ms = new MemoryStream(byteImage);
            img = Image.FromStream(ms);
            return img;
        }
    }
}
