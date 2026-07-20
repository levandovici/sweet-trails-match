// Copyright (C) 2017 gamevanilla. All rights reserved.
// This code can only be used under the standard Unity Asset Store End User License Agreement,
// a copy of which is available at http://unity3d.com/company/legal/as_terms.

using UnityEngine;

using FullSerializer;

using GameVanilla.Core;

namespace GameVanilla.Game.Common
{
    /// <summary>
    /// This class is a utility class that allows other classes to easily access the game configuration and
    /// the lives and coins systems.
    /// </summary>
    public class PuzzleMatchManager : MonoBehaviour
    {
        public static PuzzleMatchManager instance;

        public GameConfiguration gameConfig;

        public int lastSelectedLevel;
        public bool unlockedNextLevel;

        #if UNITY_IAP
        public IapManager iapManager;
        #endif

        /// <summary>
        /// Unity's Awake method.
        /// </summary>
        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
            else if (instance != this)
            {
                Destroy(gameObject);
            }
            DontDestroyOnLoad(gameObject);

            var serializer = new fsSerializer();
            gameConfig = FileUtils.LoadJsonFile<GameConfiguration>(serializer, "game_configuration");
            if (!PlayerPrefs.HasKey("sound_enabled"))
            {
                PlayerPrefs.SetInt("sound_enabled", 1);
            }
            if (!PlayerPrefs.HasKey("music_enabled"))
            {
                PlayerPrefs.SetInt("music_enabled", 1);
            }

            #if UNITY_IAP
            iapManager = new IapManager();
            #endif
        }
    }
}
