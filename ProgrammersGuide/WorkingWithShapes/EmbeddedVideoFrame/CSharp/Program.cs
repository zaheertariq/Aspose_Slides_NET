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

namespace EmbeddedVideoFrame
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

                //Embedd vide inside presentation
                IVideo vid = pres.Videos.AddVideo(new FileStream(dataDir+ "Wildlife.wmv", FileMode.Open));

                //Add Video Frame
                IVideoFrame vf = sld.Shapes.AddVideoFrame(50, 150, 300, 350, vid);

                //Set video to Video Frame
                vf.EmbeddedVideo = vid;

                //Set Play Mode and Volume of the Video
                vf.PlayMode = VideoPlayModePreset.Auto;
                vf.Volume = AudioVolumeMode.Loud;

                //Write the PPTX file to disk
                pres.Save(dataDir+ "VideoFrame.pptx", SaveFormat.Pptx);
            }

            
            
        }
    }
}