namespace tui.net
{
    public interface ITextGraphics
    {
        /// <summary>
        /// Return the image object that is linked with this TextGraphics.
        /// </summary>
        /// <returns></returns>
        TextImage GetBufferImage();

        /// <summary>
        /// Update the display with the content of the merged Text image
        /// </summary>
        void Draw();
    }
}
