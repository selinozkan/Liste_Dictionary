using System;
using System.Collections.Generic;
using System.Text;

namespace ListDictionary
{
    class MyDictionary<K,V>
    {
        K[] isim;
        V[] yas;
      

        public MyDictionary()
        {
            isim = new K[0];
            yas  = new V[0];

        }

  

        public void Add(K isima , V yasa)
        {
            K[] _isim = isim;
            V[] _yas = yas;
            isim = new K[isim.Length + 1];
            yas = new V[yas.Length + 1];
            for (int i = 0; i <_isim.Length; i++)
            {
                isim[i] = _isim[i];
                yas[i] = _yas[i];

            }
            isim[isim.Length -1] = isima;
            yas[yas.Length - 1] = yasa;

        }

        public K[] İsim
        {
            get
            {
                return isim;
            }
        }

        public V[] Yas
        {
            get
            {
                return yas;
            }
        }

       
    }
}
