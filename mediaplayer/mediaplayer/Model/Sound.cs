﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediaplayer.Model
{
    public enum SoundCategory
    {
       Adele,
       Justin,
       Sia,Taylor
    }
    public class Sound
    {
        public string Name { get; set; }
        public SoundCategory Category { get; set; }
        public string AudioFile { get; set; }

        public string ImageFile { get; set; }

        public Sound ( string name, SoundCategory category)
        {
            Name = name;
            Category = category;
            AudioFile = $"Assets/Audio/{category}/{name}.wav";
            ImageFile = $"Assets/Images/{category}/{name}.png";

        }

    }
}
