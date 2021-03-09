

namespace DataGen
{
    /*    public enum ColumnType
        {
            Id,
            Name,
            Pesel,
            Phone,
            Age

        }
    */

    public class Generator
    {
        public Generator()
        {
            id = 0;
            separator = " ";
            columns = new System.Collections.Generic.List<string>();
            names = new System.Collections.Generic.List<string>() { "Barbara", "Lukasz", "Boleslaw", "$tEfan", "B0lo", "Mateusz", "Hulk", "Emilia", "Gerwazy", "hugo", "Patrycja", "Joe", "Jean-Philippe" };
            domains = new System.Collections.Generic.List<string>() { "wp.pl", "gmail.com", "tymczasowy.pl", "info.acoustic.com" };
        }
        public string GetRandomLine()
        {

            return GenerateId() + separator + GenerateName() + separator + GenerateAge() + separator + GenerateEmail() + separator + GeneratePESEL();

        }

        string GenerateEmail()
        {
            var rand = new System.Random();
            return names[rand.Next(names.Count)].ToString() + "_" + rand.Next() + "@" + domains[rand.Next(domains.Count)].ToString();


        }

        string GeneratePESEL()
        {
            var rand = new System.Random();
            string PESEL = "";
         
            for (int offset = 0; offset < 11; offset++)
            {
                PESEL += rand.Next(9).ToString();
            }

            return PESEL;

        }
        string GenerateName()
        {
            var rand = new System.Random();
            return names[rand.Next(names.Count)].ToString();
        }
        string GenerateAge()
        {
            var rand = new System.Random();
            return rand.Next(100).ToString();
        }

        string GenerateId()
        {
            this.id++;
            return this.id.ToString();
        }

        System.Collections.Generic.List<string> columns, names, domains;

        int id;
        string separator;


    }
}