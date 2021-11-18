using System;
using System.Collections.Generic;

namespace Kino
{
    public class Movie
    {
        private string _title;
        private DateTime _publishedAt;
        private List<Watcher> _watchers;

        public Movie(string title, DateTime publishedAt)
        {
            _title = title;
            _publishedAt = publishedAt;
        }

        public void AddWatcher(Watcher who)
        {
            _watchers.Add(who);
        }

        public int PublishedYear
        {
            get { throw new NotImplementedException(); }
        }

        public List<Watcher> Watchers
        {
            get => _watchers;
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
