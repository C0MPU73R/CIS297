#include <iostream>
#include <string>
#include <array>
using namespace std;

bool Reverse(int numberToCheckForPrime, int startingNumber)
{
	// base case
	if (numberToCheckForPrime < 1)
	{
		return false;
	}
	// base case
	if (startingNumber == 1)
	{
		return true;
	}
	// complex case
	else
	{
		if (numberToCheckForPrime % startingNumber == 0)
		{
			return false;
		}
		return Reverse(numberToCheckForPrime, startingNumber - 1);
	}
}

int main()
{
	int number = 5;

	cout << number << " is prime: " << Reverse(number, number - 1) << endl;

	string input;
	cin >> input;

	return 0;

}