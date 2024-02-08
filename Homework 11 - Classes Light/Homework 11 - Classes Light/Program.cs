namespace Homework_11___Classes_Light
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //crearea obiectelor candelabru
            Candelabru cand1 = new Candelabru(60, 75, 100);
            Candelabru cand2 = new Candelabru(40, 60, 75, 75, 100);
            cand1.Id = 1;
            cand2.Id = 2;

            //crearea array-ului de obiecte candelabru
            Candelabru[] candelabre = { cand1, cand2 };

            //afisare stare a obiectelor Candelabru
            Afisare.StareCandelabre(candelabre);

            //afisare putere maxima a obiectelor Candelabru
            Afisare.PutereMaxima(candelabre);

            //aprindere obiecte Candelabru
            foreach (Candelabru c in candelabre)
            {
                c.Aprinde();
            }

            //afisare stare a obiectelor Candelabru
            Afisare.StareCandelabre(candelabre);

            //afisare putere curenta a obiectelor Candelabru
            Afisare.PutereCurenta(candelabre);

            //stingere obiecte Candelabru
            foreach (Candelabru c in candelabre)
            {
                c.Stinge();
            }

            //afisare stare a obiectelor Candelabru
            Afisare.StareCandelabre(candelabre);

            //marire lumina obiecte Candelabru cu 80
            foreach (Candelabru c in candelabre)
            {
                c.MaresteLumina(80);
            }

            //afisare stare a obiectelor Candelabru
            Afisare.StareCandelabre(candelabre);

            //afisare putere curenta a obiectelor Candelabru
            Afisare.PutereCurenta(candelabre);

            //reducere lumina obiecte Candelabru cu 50
            foreach (Candelabru c in candelabre)
            {
                c.ReduceLumina(50);
            }

            //afisare stare a obiectelor Candelabru
            Afisare.StareCandelabre(candelabre);

            //afisare putere curenta a obiectelor Candelabru
            Afisare.PutereCurenta(candelabre);
        }
    }
}
