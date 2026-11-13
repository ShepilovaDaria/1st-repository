using System;
using System.Collections.Generic;
using System.Text;

namespace LAB4
{
    public interface Iterator<T> //обобщённый
    {
        bool Hasnext();
        T Next();   // Следующий элемент
    }
    public interface Playlist<T> //Интерфейс агрегата 
    {
        Iterator<T> CreateIterator();
    }
    public class Reverseplaylist<T> : Iterator<T> //конкретный итератор
    {
        private readonly List<T> tracks;
        private int ind;

        public Reverseplaylist(List<T> t)
        {
            tracks = t;
            ind = t.Count - 1; 
        }
        public bool Hasnext()=> ind >=0;
        public T Next()
        {
            if (Hasnext())
                return tracks[ind--]; 
            throw new IndexOutOfRangeException("Треки закончились");
        }
    }
    public class Playlist_<T>:  Playlist<T> //конкретный агрегат
    {
        private readonly List<T> _tracks;
        public Playlist_(List<T> t) {_tracks = t;}
        public Iterator<T> CreateIterator() => new Reverseplaylist<T>(_tracks);
    }
}
