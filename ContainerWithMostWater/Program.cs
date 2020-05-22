namespace ContainerWithMostWater
{
    /// <summary>
    ///
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// LeetCode: 11. Container With Most Water
        /// </summary>
        /// <param name="height">The height.</param>
        /// <returns>
        /// MaxArea
        /// </returns>
        public int MaxArea(int[] height)
        {
            var maxArea = 0;

            // 若是input為[0], 則回0
            if (height.Length != 0)
            {
                // 從x軸(i0開始)
                for (int x1 = 0; x1 < height.Length - 1; x1++)
                {
                    // 從x軸(i1)開始逐一計算
                    for (int x2 = 1; x2 < height.Length; x2++)
                    {
                        // y軸取兩者間較低的值為主
                        var lowerHeight = height[x1] < height[x2] ? height[x1] : height[x2];
                        var currencyContains = lowerHeight * (x2 - x1);

                        maxArea = maxArea > currencyContains ? maxArea : currencyContains;
                    }
                }
            }

            return maxArea;
        }
    }
}