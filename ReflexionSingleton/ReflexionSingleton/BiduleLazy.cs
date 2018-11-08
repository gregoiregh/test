using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflexionSingleton
{
    
    //Singleton Lazy (l'instance est crée à la première demande)
       
    public class BiduleLazy
    {
        //Garde une référence sur l'instance unique de cette classe
        private  static BiduleLazy _Instance;
        
        //Méthode qui contrôle la création de l'instance
        public static BiduleLazy GetInstance()
        {
            //Dans un contexte multithread, il faut poser un verrou (lock)
            //pour empecher 2 taches simultanées de créer chacune une instance de la classe 
            if (_Instance == null)
            {
                _Instance = new BiduleLazy();
            }
            return _Instance; 
        }

        //Le constructeur est privé pour empécher la creation d'instances
        //Depuis l'extérieur de la classe
        private BiduleLazy() 
        {
        }


    }
}
