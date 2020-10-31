using System;
using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    [Serializable]
    public class LifeBarController
    {
        public Image Image;

        public void UpdateFill(int amount)
        {
            // Update Fill
            // Regra - 100%
        }

        public void UpdateLocation(Transform toTrack)
        {
            // Update de posição
        }
    }
}