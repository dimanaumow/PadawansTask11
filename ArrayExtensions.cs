using System;

namespace PadawansTask11
{
    public static class ArrayExtensions
    {
        public static int? FindIndex(double[] array, double accuracy)
        {
            if (accuracy < 0 || accuracy > 1)
            {
                throw new ArgumentException();
            }

            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            double sumRight = 0;

            double sumLeft = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sumRight += array[i];
            }

            for (int i = 0; i < array.Length; i++)
            {
                sumRight -= array[i];

                if (Math.Abs(sumRight - sumLeft) < accuracy)
                {
                    return i;
                }

                sumLeft += array[i];
            }

            return null;
        }
    }
}
