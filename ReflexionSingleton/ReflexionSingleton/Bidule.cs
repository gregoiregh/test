using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflexionSingleton
{
    //Singleton
    public class Bidule
    {

        private static Bidule _Instance = new Bidule();

        public static Bidule GetInstance()
        {
            return _Instance; 
        }

        private Bidule() 
        {
        }

    }
}
