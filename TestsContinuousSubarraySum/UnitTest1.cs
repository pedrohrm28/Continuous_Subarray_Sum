public class SolutionTests
{
    private readonly Solution _solution;

    public SolutionTests()
    {
        _solution = new Solution();
    }

    [Fact]
    public void Test1_ShouldReturnTrue()
    {
        // Arrange
        int[] nums = { 23, 2, 4, 6, 7 };
        int k = 6;

        // Act
        bool result = _solution.CheckSubarraySum(nums, k);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void Test2_ShouldReturnTrue()
    {
        // Arrange
        int[] nums = { 23, 2, 6, 4, 7 };
        int k = 6;

        // Act
        bool result = _solution.CheckSubarraySum(nums, k);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void Test3_ShouldReturnFalse()
    {
        // Arrange
        int[] nums = { 23, 2, 6, 4, 7 };
        int k = 13;

        // Act
        bool result = _solution.CheckSubarraySum(nums, k);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void Test4_ShouldReturnTrue()
    {
        // Arrange
        int[] nums = { 5, 0, 0 };
        int k = 3;

        // Act
        bool result = _solution.CheckSubarraySum(nums, k);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void Test5_ShouldReturnTrue()
    {
        // Arrange
        int[] nums = { 0, 0 };
        int k = 1;

        // Act
        bool result = _solution.CheckSubarraySum(nums, k);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void Test6_ShouldReturnFalse()
    {
        // Arrange
        int[] nums = { 1, 2 };
        int k = 4;

        // Act
        bool result = _solution.CheckSubarraySum(nums, k);

        // Assert
        Assert.False(result);
    }
}
