public class GameStates 
	{
		public enum States //containing three different states
		{
			Starting,
			Loading,
			Playing,
			Cutscene,
			Dying,
			Ending
		}

		public States State; //any one of the three states enumerated above
	}
