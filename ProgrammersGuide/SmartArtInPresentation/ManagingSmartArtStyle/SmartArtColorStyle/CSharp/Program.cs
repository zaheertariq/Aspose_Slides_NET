//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Slides. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Slides;
using Aspose.Slides.SmartArt;

namespace SmartArtColorStyle
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

            //Load the desired presentation
            using (Presentation pres = new Presentation(dataDir + "SimpleSmartArt.pptx"))
            {

                //Traverse through every shape inside first slide
                foreach (IShape shape in pres.Slides[0].Shapes)
                {
                    //Check if shape is of SmartArt type
                    if (shape is ISmartArt)
                    {

                        //Typecast shape to SmartArtEx
                        ISmartArt smart = (ISmartArt)shape;

                        //Checking SmartArt color type
                        if (smart.ColorStyle == SmartArtColorType.ColoredFillAccent1)
                        {
                            //Changing SmartArt color type
                            smart.ColorStyle = SmartArtColorType.ColorfulAccentColors;
                        }

                    }

                }

                //Saving Presentation
                pres.Save(dataDir + "ChangeSmartArtColorStyle.pptx", Aspose.Slides.Export.SaveFormat.Pptx);


            }
        }
    }
}