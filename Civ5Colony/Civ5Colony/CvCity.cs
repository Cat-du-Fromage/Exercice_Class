using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Civ5Colony
{
    class CvCity
    {
        #region Private Attributes
        private string _name;
        private int _population;
        private int _happiness;
        private int _unhappiness;
        private int _numCorporation;
        private Corporation _corporation;
        #endregion Private Attributes

        #region Constructor
        /// <summary>
        /// Construct the object CvCity
        /// </summary>
        /// <param name="name">Nom</param>
        /// <param name="population">Nombre de citoyen</param>
        /// <param name="happiness">Nombre de citoyen heureux</param>
        /// <param name="unhappiness">nombre de citoyen malheureux</param>
        public CvCity(string name, int population)
        {
            this._name = name;
            this._population = population;
            this._happiness = this._population;
            this._unhappiness = 0;
        }
        #endregion Constructor

        #region private methods
        #endregion private methods

        #region Accessors
        /// <summary>
        /// Retourne le nom de la ville ou permet de le changer
        /// </summary>
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        /// <summary>
        /// Permet de retourner ou changer le nombre de citoyen
        /// </summary>
        public int Population
        {
            get
            {
                return this._population;
            }
            set
            {
                this._population = value;
            }
        }
        /// <summary>
        /// Permet de retourner le nombre d'habitant heureux
        /// </summary>
        public int Happiness
        {
            get
            {
                return this._happiness;
            }
        }
        /// <summary>
        /// Permet de retourner le nombre d'habitant malheureux
        /// </summary>
        public int Unhappiness
        {
            get
            {
                return this._unhappiness;
            }
        }
        #endregion Accessors
    }
}
