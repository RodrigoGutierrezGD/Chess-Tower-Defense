using System;
using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    [Serializable]
    public class LifeBarController
    {
        /*public Image barImg;

        public void UpdateFill(int amount)
        {
            barImg.fillAmount += amount / 10;
        }

        public void UpdateLocation(Transform toTrack)
        {
            // Update de posição
        }*/

        public SpriteRenderer mySprite;
        public Sprite[] spriteState;

        public void UpdateSprite(int damageTaken, int totalLife)
        {
            //int actualLifeState = totalLife / spriteState.Length;
            //mySprite.sprite = spriteState[actualLifeState];
        }
    }
}