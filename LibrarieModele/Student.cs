﻿
namespace LibrarieModele
{
    public class Student
    {
        // data membra privata
        int[] note;

        //proprietati auto-implemented
        //public int IdStudent { get; set; } //identificator unic student

        // TEMA LAB 2 - adaugare proprietati auto-implemented
        private int idStudent;
        public int IdStudent
        {
            get { return idStudent; }
            set { idStudent = value; }
        }

        //public string Nume { get; set; }
        //public string Prenume { get; set; }

        // TEMA LAB 2 - adaugare proprietati auto-implemented
        private string nume;
        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }

        private string prenume;
        public string Prenume
        {
            get { return prenume; }
            set { prenume = value; }
        }

        public void SetNote(int[] _note)
        {
            note = new int[_note.Length];
            _note.CopyTo(note, 0);
        }

        public int[] GetNote()
        {
            // returneaza o copie a vectorului, astfel încât utilizatorii acestei 
            // clase să nu poata modifica în mod direct conținutul vectorului 
            return (int[])note.Clone();
        }

        //contructor implicit
        public Student()
        {
            Nume = Prenume = string.Empty;
        }

        //constructor cu parametri
        public Student(int idStudent, string nume, string prenume)
        {
            this.IdStudent = idStudent;
            this.Nume = nume;
            this.Prenume = prenume;
        }

        public string Info()
        {
            string info = $"Id:{IdStudent} Nume:{Nume ?? " NECUNOSCUT "} Prenume: {Prenume ?? " NECUNOSCUT "}";

            return info;
        }
    }
}
