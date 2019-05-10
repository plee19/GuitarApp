using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp
{
    public class ChordDatabase
    {
        readonly SQLiteAsyncConnection database;
        private ObservableCollection<Chord> Chords { get; set; }

        public ChordDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);

            try { database.DropTableAsync<Chord>().Wait(); } catch { Debug.Write("No such table"); }

            database.CreateTableAsync<Chord>().Wait();
            Chords = new ObservableCollection<Chord>
            {
                new Chord{ChordName = "A"},
                new Chord{ChordName = "Am"},
                new Chord{ChordName = "B"},
                new Chord{ChordName = "Bm7"},
                new Chord{ChordName = "C"},
                new Chord{ChordName = "D"},
                new Chord{ChordName = "E"},
                new Chord{ChordName = "Em"},
                new Chord{ChordName = "F"},
                new Chord{ChordName = "F#m7"},
                new Chord{ChordName = "G"}
            };

            foreach (Chord c in Chords)
            {
                SaveChordAsync(c);
            }

        }

        public Task<List<Chord>> GetChordsAsync()
        {
            return database.Table<Chord>()
                .OrderBy(t => t.ChordName)
                .ToListAsync();
        }

        Task<int> SaveChordAsync(Chord c)
        {
            return database.InsertAsync(c);
        }
    }
}
