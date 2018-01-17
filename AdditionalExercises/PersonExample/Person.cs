namespace AdditionalExercises.PersonExample
{
    using System;
    using System.Collections.Generic;

    public class Person
    {
        private String familyName;
        private String givenName;
        private String nationality;
        private bool capitalizeSurname;
        private bool olympicMode;

        private static List<String> surnameFirst = new List<String> { "CHN", "KOR" };


        public Person(String familyName, String givenName, String nationality)
            : this(familyName, givenName, nationality, false, false)
        {
        }

        public Person(String familyName, String givenName, String nationality,
            bool olympicMode, bool capitalizeSurname)
        {
            this.familyName = familyName;
            this.givenName = givenName;
            this.nationality = nationality;
            this.capitalizeSurname = capitalizeSurname;
            this.olympicMode = olympicMode;
        }

        public override string ToString()
        {
            return NameString();
        }

        private String NameString()
        {
            String surname = familyName;
            if (capitalizeSurname)
            {
                surname = familyName.ToUpperInvariant();
            }
            if (IsSurnameFirst())
                return surname + " " + givenName;

            return givenName + " " + surname;
        }

        private bool IsSurnameFirst()
        {
            if (!olympicMode)
                return false;
            return surnameFirst.Contains(nationality);
        }
    }
}