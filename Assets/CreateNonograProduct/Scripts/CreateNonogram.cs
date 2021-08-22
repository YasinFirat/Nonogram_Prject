using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CreateNonogram
{
    [System.Serializable]
    public struct CreateNonogram
    {
        public Vector2 sizeOfPicture;
        /// <summary>
        /// 2 Boyutlu dizilim yapar.
        ///
        /// </summary>
        /// <param name="pixel"></param>
        /// <returns></returns>
        private CreateNonogram Create(Pixel pixel)
        {
            /// eğer x değeri 3 , y değeri 4 girildiyse sıralama aşağıdaki gibi olacak
            /// (soldan sağa'a doğru ilerleyecek
            /// ◘ ◘ ◘                           (0,0) (1,0) (2,0)    
            /// ◘ ◘ ◘      Sayısal gösterimi    (0,1) (1,1) (2,1)
            /// ◘ ◘ ◘      =================>   (0,2) (1,2) (2,2)
            /// ◘ ◘ ◘                           (0,3) (1,3) (2,3)
            //kod buraya yazılacak.
            Debug.Log("BURAK  : Dizilim kodu yazılacak.");
            return this;
        }
    }
}

