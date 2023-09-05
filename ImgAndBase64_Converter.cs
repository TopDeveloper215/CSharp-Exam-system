using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Drawing;


public static class ImgAndBase64_Converter
{
    public static string ImgToBase64(string path)
    {
        if (path == null || path.Trim() == string.Empty) return string.Empty;
        Image image = Image.FromFile(path);
            
        using (MemoryStream m = new MemoryStream())
        {
            image.Save(m, image.RawFormat);
            byte[] imageBytes = m.ToArray();

            // Convert byte[] to Base64 String
            string base64Img = Convert.ToBase64String(imageBytes);
            return base64Img;
        }
    }

    public static string ImgToBase64(Image image)
    {
        if(image == null) { return string.Empty; }
        using (MemoryStream m = new MemoryStream())
        {
            image.Save(m, image.RawFormat);
            byte[] imageBytes = m.ToArray();

            // Convert byte[] to Base64 String
            string base64Img = Convert.ToBase64String(imageBytes);
            return base64Img;
        }
    }

    public static Image Base64ToImg(string Base64Img)
    {
        if(Base64Img.Trim() == string.Empty) { return null; }

        byte[] bytes = Convert.FromBase64String(Base64Img);
        MemoryStream mem = new MemoryStream(bytes);
        Image image = Image.FromStream(mem);
        return image;
    }
        
}

