using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace CreateNonogram
{
    public class Pixel : MonoBehaviour
    {
        [Tooltip("Her pixelin 2 boyutlu düzlemde id numaralarý olmalý")]
        public Vector2 id;
        private Color32 myColor;
        public UnityEvent<Color32> paint;
        private SpriteRenderer spriteRenderer;

        private void Awake()
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
        }
        private void Start()
        {
            spriteRenderer.color = Settings.Instance.fullColor;

        }

        public void ChangeColor(Color32 color)
        {
            if (color.Equals(myColor))
            {//eðer deðiþtirilmek istenen renk, tanýmlý renk ile ayný ise pixeli boþaltma iþlemi yapýlýr
                myColor = Settings.Instance.emptyColor;
                return;
            }

            myColor = color;
        }
       
    }

    
}
