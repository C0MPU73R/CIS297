namespace Yahtzee
{
	public interface INumberGenerator
	{
		int Next( int minValue, int maxValue );
	}
}