﻿namespace tui.net
{
    public class TextLayer: TextBitmap
    {
        public int OffsetX { get; set; }

        public int OffsetY { get; set; }

        public string LayerName { get; private set; }

        public bool IsActive { get; set; }

        public TextLayer(int width, int height, string name) : base(width, height)
        {
            LayerName = name;
        }

    }
}
