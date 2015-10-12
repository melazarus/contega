using System.Collections.Generic;
using System.Linq;

namespace tui.net
{
    public class TextImage
    {
        private List<TextLayer> _layers;

        public TextLayer this[int index]
        {
            get { return _layers[index]; }
            private set { }
        }

        public TextLayer this[string name]
        {
            get { return _layers.Where(x => x.LayerName == name).First(); }
            private set { }
        }

        public int Height { get; private set; }

        public int Width { get; private set; }

        public TextImage(int width, int height)
        {
            _layers = new List<TextLayer>();
            Height = height;
            Width = width;

            AddLayer("Background");
        }

        public TextLayer AddLayer(string Name)
        {
            if (_layers == null) _layers = new List<TextLayer>();

            var newLayer = new TextLayer(Width, Height, Name);
            _layers.Add(newLayer);

            return newLayer;
        }
    }
}