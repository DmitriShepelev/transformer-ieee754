using System;

namespace TransformerTask
{
    /// <summary>
    /// Implement transformer class.
    /// </summary>
    public class Transformer
    {
        /// <summary>
        /// Transform each element of source array into its binary representation according to IEEE 754 format.
        /// </summary>
        /// <param name="source">Source array.</param>
        /// <returns>Array of IEEE754-binary representation of elements of source array.</returns>
        /// <exception cref="ArgumentNullException">Throw if array is null.</exception>
        /// <exception cref="ArgumentException">Throw if array is empty.</exception>
        public string[] Transform(double[] source)
        {
            if (source == null)
            {
                throw new ArgumentNullException($"Array cannot be null.");
            }

            if (source.Length == 0)
            {
                throw new ArgumentException($"Array cannot be empty.");
            }

            var result = new string[source.Length];
            for (int i = 0; i < source.Length; i++)
            {
                result[i] = source[i].GetIEEE754Format();
            }

            return result;
        }
    }
}
