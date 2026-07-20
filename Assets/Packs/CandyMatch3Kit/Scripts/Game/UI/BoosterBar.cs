// Copyright (C) 2017 gamevanilla. All rights reserved.
// This code can only be used under the standard Unity Asset Store End User License Agreement,
// a copy of which is available at http://unity3d.com/company/legal/as_terms.

using UnityEngine;

using GameVanilla.Game.Common;

namespace GameVanilla.Game.UI
{
	/// <summary>
	/// This class loads the booster data into the in-game booster buttons when the game starts.
	/// </summary>
	public class BoosterBar : MonoBehaviour
	{
#pragma warning disable 649
		[SerializeField]
		private BuyBoosterButton button1;

		[SerializeField]
		private BuyBoosterButton button2;

		[SerializeField]
		private BuyBoosterButton button3;

		[SerializeField]
		private BuyBoosterButton button4;
#pragma warning restore 649

		/// <summary>
		/// Sets the data of the in-game booster buttons.
		/// </summary>
		/// <param name="level">The current level.</param>
		public void SetData(Level level)
		{
			PlayerPrefs.SetInt("num_boosters_0", 1);

			PlayerPrefs.SetInt("num_boosters_1", 1);

			PlayerPrefs.SetInt("num_boosters_2", 1);

			PlayerPrefs.SetInt("num_boosters_3", 1);

			button1.UpdateAmount(1);

			button2.UpdateAmount(1);

			button3.UpdateAmount(1);

			button4.UpdateAmount(1);
		}
	}
}