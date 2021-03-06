﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace QuickDatabase
{
    class DaoNotes
    {
        //ToDo Normalize methods
        public IEnumerable<Notes> GetAllNotes()
        {
            List<Notes> data = new List<Notes>();
            using (DataBaseContext db = new DataBaseContext(DataBaseContext.ConnectionString))
            {
                data = (from notes in db.Notes
                        orderby notes.date descending
                        select notes).ToList();
            }
            return data;
        }

        public List<Notes> GetAllNotesAsList()
        {
            List<Notes> data = new List<Notes>();
            using (DataBaseContext db = new DataBaseContext(DataBaseContext.ConnectionString))
            {
                data = (from notes in db.Notes
                        orderby notes.date descending
                        select notes).ToList();
            }
            return data.ToList<Notes>();
        }

        public bool Save(Notes note)
        {
            try
            {
                using (DataBaseContext db = new DataBaseContext(DataBaseContext.ConnectionString))
                {
                    db.Notes.InsertOnSubmit(note);
                    db.SubmitChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        internal IEnumerable<Notes> GetSimilarNotes(string keyword)
        {
            using (DataBaseContext db = new DataBaseContext(DataBaseContext.ConnectionString))
            {
                var data = from note in db.Notes
                           where note.note.Contains(keyword)
                           select note;

                return new ObservableCollection<Notes>(data);
            }
        }

        public bool DestroyOldNotes(int days)
        {
            try
            {
                using (DataBaseContext db = new DataBaseContext(DataBaseContext.ConnectionString))
                {
                    var destroy = db.Notes.Where(t => t.date < DateTime.Now.AddDays(-days)).ToList();
                    db.Notes.DeleteAllOnSubmit(destroy);
                    db.SubmitChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Destroy(Notes note)
        {
            try
            {
                using (DataBaseContext db = new DataBaseContext(DataBaseContext.ConnectionString))
                {
                    var excluir = db.Notes.Where(t => t.id == note.id).First();
                    db.Notes.DeleteOnSubmit(excluir);
                    db.SubmitChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        internal Notes GetNote(int id)
        {
            List<Notes> data = new List<Notes>();
            using(DataBaseContext db = new DataBaseContext(DataBaseContext.ConnectionString))
            {
                data = (from e in db.Notes
                        where e.id == id
                        select e).ToList();
            }
            return data[0];
        }

        //ToDo Update note using Linq

        internal bool UpdateNote(int id, string note)
        {
            try
            {
                using (DataBaseContext db = new DataBaseContext(DataBaseContext.ConnectionString))
                {
                    Notes update = (from tar in db.Notes
                                     where tar.id == id
                                     select tar).First();

                    update.note = note;
                    db.SubmitChanges();
                    
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}