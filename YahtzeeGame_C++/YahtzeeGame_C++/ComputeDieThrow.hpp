#include "Dice.hpp"
#include <vector>
using namespace std;
class ComputeDiceThrow
{

public:

	ComputeDiceThrow()
	{
		

	}
	ComputeDiceThrow()
	{
		delete D1;
		delete D2;
		delete D3;
		delete D4;
		delete D5;
		delete D6;
		delete InitialDiceVector;

	}


	void ThrowTheDice(int Die1Val, int Die2Val, int Die3Val, int Die4Val, int Die5Val, int Die6Val)
	{
		Die1Val = rand() % 6 + 1;
		Die2Val = rand() % 6 + 1;
		Die3Val = rand() % 6 + 1;
		Die4Val = rand() % 6 + 1;
		Die5Val = rand() % 6 + 1;
		Die6Val = rand() % 6 + 1;
		D1 = new Dice;
		D1->setDiceValue(Die1Val);
		D2 = new Dice;
		D2->setDiceValue(Die2Val);
		D3 = new Dice;
		D3->setDiceValue(Die3Val);
		D4 = new Dice;
		D4->setDiceValue(Die4Val);
		D5 = new Dice;
		D5->setDiceValue(Die5Val);
		D6 = new Dice;
		D6->setDiceValue(Die6Val);

		InitialDiceVector.push_back(D1);
		InitialDiceVector.push_back(D2);
		InitialDiceVector.push_back(D3);
		InitialDiceVector.push_back(D4);
		InitialDiceVector.push_back(D5);
		InitialDiceVector.push_back(D6);
		
	}



private:
	Dice* D1;
	Dice* D2;
	Dice* D3;
	Dice* D4;
	Dice* D5;
	Dice* D6;

	
	vector<Dice*> InitialDiceVector;




};