using System;
using System.Linq;
using GeometryGym.Ifc;

namespace GettingStarted
{
    internal class IFC_Application
    {
        static void Main(string[] args)
        {
            //create new IFC Model
            var db = new DatabaseIfc(ModelView.Ifc2x3Coordination);
            var project = new IfcProject(db, "my first IFC project");

            // access all entity instances stored in the IFC Model
            var allEntities = db.ToList();

            // access an show an instance
            foreach (var entity in allEntities)
            {
                Console.WriteLine(entity);
            }

            // await user input
            Console.ReadKey();

        }
    }
}