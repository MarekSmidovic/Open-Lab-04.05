namespace Open_Lab_04._05
{
    public class StringTools
    {
        public string Repeat(string orig, int n)
        {
            int count = orig.Length-1;
            string vysledok = string.Empty;

            for (int i = 0; i <= count; i++)
            {
                vysledok = vysledok + orig[i];

                for (int j = 0; j < n-1; j++)
                {
                    vysledok = vysledok + orig[i];
                }
            }
            return vysledok;
        }
    }
}
    




