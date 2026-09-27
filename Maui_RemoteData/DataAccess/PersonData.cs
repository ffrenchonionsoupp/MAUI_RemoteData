using SQLite;
using Maui_RemoteData.Models;

namespace Maui_RemoteData.DataAccess
{
    public class PersonData
    {
        SQLiteConnection database;

         public void Init()
        {
            if (database is not null)
            {
                return;
            }
            database = new SQLiteConnection(DatabaseConstants.DatabasePath, DatabaseConstants.Flags);
            database.CreateTable<Person>(); // Specify the type explicitly
        }
        public List<Person> GetPeople()
        {
            Init();
            return  database.Table<Person>().ToList(); // Explicitly specify the type argument
        }
        public int SavePerson(Person person)
        {
            Init();
            if (person.ID != 0)
            {
                //update an existing person
                return database.Update(person);
            }
            else
            {
                // save a new person
                return database.Insert(person);
            }
        }
    }
}
