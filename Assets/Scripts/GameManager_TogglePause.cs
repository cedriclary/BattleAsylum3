﻿using UnityEngine;
using System.Collections;

namespace s3
{
    public class GameManager_TogglePause : MonoBehaviour
    {

        private GameManager_Master gameManagerMaster;
        private bool isPaused;

        void OnEnable()
        {
            setInitialReferences();
            gameManagerMaster.MenuToggleEvent += TogglePause;
            gameManagerMaster.GoToMenuSceneEvent += TogglePause;
        }

        void OnDisable()
        {
            gameManagerMaster.MenuToggleEvent -= TogglePause;
            gameManagerMaster.GoToMenuSceneEvent -= TogglePause;
        }

        void setInitialReferences()
        {
            gameManagerMaster = GetComponent<GameManager_Master>();
        }

        void TogglePause()
        {
            if (isPaused)
            {
                Time.timeScale = 1;
                isPaused = false;
            }
            else
            {
                Time.timeScale = 0;
                isPaused = true;
            }
        }


    }
}

