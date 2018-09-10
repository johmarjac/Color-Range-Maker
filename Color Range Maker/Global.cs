using Emgu.CV;
using Emgu.CV.Structure;

namespace Color_Range_Maker
{
    public static class Global
    {

        public static Image<Hsv, byte> Image;
        public static float MinHue = 0;
        public static float MinSat = 0;
        public static float MinVal = 80;
        public static float MaxHue = 180;
        public static float MaxSat = 255;
        public static float MaxVal = 255;

        public static bool Invert = false;

        public static void ToNormHSV(ref float minHue, ref float minSat, ref float minVal, ref float maxHue, ref float maxSat, ref float maxVal)
        {
            minHue = (minHue / 180) * 360;
            minSat = (minSat / 255) * 100;
            minVal = (minVal / 255) * 100;

            maxHue = (maxHue / 180) * 360;
            maxSat = (maxSat / 255) * 100;
            maxVal = (maxVal / 255) * 100;
        }

        public static void ToOpenCVHSV(ref float minHue, ref float minSat, ref float minVal, ref float maxHue, ref float maxSat, ref float maxVal)
        {
            minHue = (minHue / 360) * 180;
            minSat = (minSat / 100) * 255;
            minVal = (minVal / 100) * 255;

            maxHue = (maxHue / 360) * 180;
            maxSat = (maxSat / 100) * 255;
            maxVal = (maxVal / 100) * 255;
        }

    }
}