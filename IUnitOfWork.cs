using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramConstruction
{
    public interface IUnitOfWork : IDisposable
    {
        IInstitutionRepository Institutions { get; }
        RoomRepository Rooms { get; }
        Repository<Person> People { get; }
        Repository<PersonsInInstView> PeopleInInst {get;}
        

       int Complete();

    }
}
