//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Slides. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Slides;
using Aspose.Slides.Export;

namespace ChangingPositionOfASlide
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            //Instantiate Presentation class to load the source presentation file
            using (Presentation pres = new Presentation(dataDir + "Aspose.pptx"))
            {
                //Get the slide whose position is to be changed
                ISlide sld = pres.Slides[0];

                //Set the new position for the slide
                sld.SlideNumber = 2;

                //Write the presentation to disk
                pres.Save(dataDir + "Aspose_out.pptx", SaveFormat.Pptx);

            }
        }
    }
}