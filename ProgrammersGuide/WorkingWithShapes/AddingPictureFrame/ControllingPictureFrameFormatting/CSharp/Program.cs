//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Slides. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Slides;
using System.Drawing;
using Aspose.Slides.Export;

namespace ControllingPictureFrameFormatting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            // Create directory if it is not already present.
            bool IsExists = System.IO.Directory.Exists(dataDir);
            if (!IsExists)
                System.IO.Directory.CreateDirectory(dataDir);

            //Instantiate Presentation class that represents the PPTX
            using (Presentation pres = new Presentation())
            {

                //Get the first slide
                ISlide sld = pres.Slides[0];

                //Instantiate the ImageEx class
                System.Drawing.Image img = (System.Drawing.Image)new Bitmap(dataDir+ "aspose-logo.jpg");
                IPPImage imgx = pres.Images.AddImage(img);

                //Add Picture Frame with height and width equivalent of Picture
                IPictureFrame pf = sld.Shapes.AddPictureFrame(ShapeType.Rectangle, 50, 150, imgx.Width, imgx.Height, imgx);

                //Apply some formatting to PictureFrameEx
                pf.LineFormat.FillFormat.FillType = FillType.Solid;
                pf.LineFormat.FillFormat.SolidFillColor.Color = Color.Blue;
                pf.LineFormat.Width = 20;
                pf.Rotation = 45;

                //Write the PPTX file to disk
                pres.Save(dataDir+ "RectPicFrameFormat.pptx", SaveFormat.Pptx);
            }
            
        }
    }
}