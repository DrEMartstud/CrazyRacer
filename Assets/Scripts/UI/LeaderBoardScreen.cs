﻿using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UI {

    public class LeaderBoardScreen : MonoBehaviour {

        [SerializeField] 
        private Button _startGameButton;

        private void Awake() {
            _startGameButton.onClick.AddListener(OnPlayButtonClick);
        }

        private void OnPlayButtonClick() {
            UIManager.Instance.LoadMenu();
        }
    }
}