﻿using Sirenix.OdinInspector;
using UnityEngine;

namespace Audio {

    public class AudioSourcePlayer : MonoBehaviour {

        [SerializeField]
        private AudioSource _audioSource;

        [Button]
		public void Play() {
			_audioSource.Play();
		}
		
        [Button]
		public void Stop() {
			_audioSource.Stop();
		}

	
    }
}