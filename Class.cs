using System;

namespace Cours3
{
    class Joueur
    {
        String name;
        int score;
        int choix;
        bool ia;

        public Joueur(String name, bool ia){
            this.name = name;
            this.score = 0;
            this.choix = 0;
            this.ia = ia;
        }

        public String Name{
            get { return name; }
            set { name = value; }
        }

        public int Score{
            get { return score; }
            set { score = value; }
        }

        public int Choix{
            get { return choix; }
            set { choix = value; }
        }

        public bool IA{
            get { return ia; }
            set { ia = value; }
        }

    }
}
