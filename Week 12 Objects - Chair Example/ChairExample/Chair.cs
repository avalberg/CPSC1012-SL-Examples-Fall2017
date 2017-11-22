using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChairExample
{
    public class Chair
    {
        #region Enums
        /// <summary>
        /// enums are sort of like "mini-classes"
        /// they let you define your own datatype, but it's made up of constants that you can't change!
        /// like an array, the possible values in an enum are numbered
        /// if you don't provide them a number, the default is to start at 0 and count up.
        ///</summary>
        public enum chairType
        {
            rolling, // this would have an index of 0
            stationary, // index of 1
            stool // index of 2
        }
        public enum primaryMaterial { wood, cloth, plastic } // this is another enum, i just wrote it with less space
        #endregion

        #region Field Declaration
        // here we're declaring our fields (notice they're inside the class but not any deeper - that means they're a field!)
        private chairType _type; // above, we created our enum (which was basically creating a datatype). BUT, we still have to 
                                // initialize a variable for our class using that datatype!
        private primaryMaterial _material;
        private string _colour, _name;
        private int _legs, _wheels;
        private bool _backSupport, _arms;
        // it's good practice to name private fields with an underscore in front of them; it's a (kind of) universal sign that something is private
        #endregion

        #region Properties
        /// <summary>
        /// these are our properties! our fields are private to protect our data.
        /// that means our fields can't be directly accessed outside the class, so 
        /// we need properties to "get at" the fields we created.
        /// the "get" is used for retrieving; so when we use the name of our property somewhere,
        /// what field is it actually returning?
        /// the "set" is used to store a value in our private field. you don't always need this (ex. 
        /// if your constructor takes in all fields as parameters) but it's still good practice.
        /// </summary>
        // the first 2 properties have been set up for you.
        // TODO: set up the remaining 6 properties so that they "get" their related private field.
        public chairType Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }
        public primaryMaterial Material { get { return _material; } set { _material = value; } }
        public string Colour { get; set; }
        public string Name { get; set; }
        public int Legs { get; set; }
        public int Wheels { get; set; }
        public bool BackSupport { get; set; }
        public bool Arms { get; set; }
        #endregion

        #region Constructor
        /// <summary> constructors are where we tell the class how to instantiate a new object using its blueprints.
        /// so when you create an object from this class (a new Chair), it will look for a constructor to know
        /// exactly how to make this object. this is where you fill the fields with meaningful data (if necessary).
        /// you can have more than one constructor as long as they take different parameters.
        /// </summary>
        public Chair(chairType type, primaryMaterial material, string colour, string name)
        {
            // making sure the values passed in are meaningful; if not, throw an exception
            if (string.IsNullOrWhiteSpace(type.ToString()) || string.IsNullOrWhiteSpace(material.ToString()) || string.IsNullOrWhiteSpace(colour) || string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException("To make a new chair you need a type, primary material, and colour.");
            else
            {
                Type = type;
                // TODO: finish the code so that all the parameters are set to their respective properties
            }
        }
        #endregion

        #region Method(s)
        /// <summary>
        /// this method shows all the attributes for the chair objects.
        /// </summary>
        public void DisplayChairAttributes()
        {
            Console.WriteLine("Type: " + Type);
            Console.WriteLine("Primary Material: " + Material);
            Console.WriteLine("Colour: " + Colour);
            Console.WriteLine("Name: " + Name);
            // TODO: finish this method so that it displays all the attributes of the chair, BUT base it on type!
            // if the chair type is rolling, display wheels, backsupport, and arms
            // if the chair type is stationary, display legs, backsupport, and arms
            // if the chair type is stool, display legs and backsupport
        }
        #endregion
    }
}
