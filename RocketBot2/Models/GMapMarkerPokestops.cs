﻿using System.Drawing;
using GMap.NET;
using GMap.NET.WindowsForms;
using System;
using System.Runtime.Serialization;

namespace RocketBot2.Models
{
    [SerializableAttribute]

    public class GMapMarkerPokestops : GMapMarker  
    {
        //protected extern GMapMarkerPokestops(SerializationInfo info, StreamingContext context);

        /// <summary>
        ///     Constructor
        /// </summary>
        /// <param name="p">The position of the marker</param>
        public GMapMarkerPokestops(PointLatLng p, Image image)
            : base(p)
        {
            MarkerImage = image;
            Size = MarkerImage.Size;
            Offset = new Point(-Size.Width/2, -Size.Height);
        }

        /// <summary>
        ///     The image to display as a marker.
        /// </summary>
        public Image MarkerImage { get; set; }

        public override void OnRender(Graphics g)
        {
            g.DrawImage(MarkerImage, LocalPosition.X, LocalPosition.Y, Size.Width, Size.Height);
        }
    }
}