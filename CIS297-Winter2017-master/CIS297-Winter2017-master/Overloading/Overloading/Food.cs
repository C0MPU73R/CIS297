using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
	public class Food
	{
		public string Name { get; }
		public int Calories
		{
			get
			{
				int totalCalories = _baseCalories;
				foreach ( Food topping in _toppings )
				{
					totalCalories += topping.Calories;
				}
				return totalCalories;
			}

		}

		private int _baseCalories;
		private List<CalorieFreeToppings> freeToppings;
		private List<Food> _toppings;

		public Food( string name, int calories )
		{
			Name = name;
			_baseCalories = calories;
			freeToppings = new List<CalorieFreeToppings>();
			_toppings = new List<Food>();
		}

		public void AddTopping(Food top)
		{
			_toppings.Add( top );
		}

		public static Food operator +( Food bottom, Food top )
		{
			bottom.AddTopping( top );
			return bottom;
		}

		public override string ToString()
		{
			return Name + " " +  Calories.ToString();
		}

		public static bool operator == ( Food left, Food right )
		{
			if ( Object.Equals( left, null ) )
			{
				if ( Object.Equals( right, null ) )
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			else
			{
				return left.Equals( right );
			}
		}

		public static bool operator != ( Food left, Food right )
		{
			return !( left == right );
		}

		public override bool Equals( object obj )
		{
			Food right = obj as Food;
			if ( right == null )
			{
				return false;
			}

			return this.Name == right.Name && this.Calories == right.Calories;
		}

		public override int GetHashCode()
		{
			return Name.GetHashCode() + Calories.GetHashCode();
		}
	}
}
