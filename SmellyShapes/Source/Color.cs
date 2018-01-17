namespace SmellyShapes.Source
{
    public class Color
    {

        private string colorAsHex;
        private string colorAsText;
        private string colorAsRGB_Red;
        private string colorAsRGB_Green;
        private string colorAsRGB_Blue;
        private string errorMessage;

        public Color(string colorAsText)
        {
            this.colorAsText = colorAsText;
            this.ConvertTextValueToRGBAndHex();
        }

        private void ConvertTextValueToRGBAndHex()
        {
            this.errorMessage = "";
            // set to Red
            if ("Red".Equals(this.colorAsText))
            {
                this.colorAsRGB_Red = "255";
                this.colorAsRGB_Blue = "0";
                this.colorAsRGB_Green = "0";
                this.colorAsHex = "#FF0000";
            }
            else if ("Blue".Equals(this.colorAsText))
            {
                // set to Blue
                this.colorAsRGB_Red = "0";
                this.colorAsRGB_Blue = "255";
                this.colorAsRGB_Green = "0";
                this.colorAsHex = "#00FF00";
            }
            else if ("Green".Equals(this.colorAsText))
            {
                // set to Green
                this.colorAsRGB_Red = "0";
                this.colorAsRGB_Blue = "0";
                this.colorAsRGB_Green = "255";
                this.colorAsHex = "#0000FF";
            }
            else
            {
                this.errorMessage = "Color not recognized";
            }
        }

        public string GetColorAsRGBBlue()
        {
            return this.colorAsRGB_Blue;
        }

        public string GetColorAsRGBGreen()
        {
            return this.colorAsRGB_Green;
        }

        public string GetColorAsRGBRed()
        {
            return this.colorAsRGB_Red;
        }

        public string GetErrorMessage()
        {
            return this.errorMessage;
        }

        public string GetColorFormatted(bool includeHexAndRGB)
        {
            if (includeHexAndRGB)
            {
                return this.colorAsText + " " + this.colorAsHex + " " + this.colorAsRGB_Red + ":" + this.colorAsRGB_Green + ":" + this.colorAsRGB_Blue;
            }
            else
            {
                return this.colorAsText;
            }
        }

        public string GetColorAsHex()
        {
            return this.colorAsHex;
        }
    }
}
