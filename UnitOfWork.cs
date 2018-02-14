using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramConstruction
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EhlContactsEntities _context;

        public IInstitutionRepository Institutions { get; private set; }

        public RoomRepository Rooms { get; private set; }
        public Repository<Person> People { get; private set; }
        public Repository<PersonsInInstView> PeopleInInst { get; private set; }
        

        public UnitOfWork(EhlContactsEntities context)
        {
            _context = context;
            Rooms = new RoomRepository(_context);
            Institutions = new InstitutionRepository(_context);
            People = new Repository<Person>(_context);
            PeopleInInst = new Repository<PersonsInInstView>(_context);
            
           
        }
        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        
    }
}
