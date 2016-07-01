﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csMTG
{
    public class Gramene : mtg
    {
        #region Attributes

        public Dictionary<int, string> labelsOfScales;

        int nbPlants = 0;
        int canopyId;

        // We may also have attributes that would stand for memory attributes (Plant, stem, last internode)

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor of Gramene:
        /// * Sets the labels of the 6 scales of an mtg.
        /// * Creates an mtg composed of one element (canopy).
        /// </summary>
        public Gramene()
        {
            // define the 6 scales

            labelsOfScales = new Dictionary<int, string>();
            labelsOfScales.Add(1, "canopy");
            labelsOfScales.Add(2, "plant");
            labelsOfScales.Add(3, "system");
            labelsOfScales.Add(4, "axis");
            labelsOfScales.Add(5, "botanical_unit");
            labelsOfScales.Add(6, "organ");

            // add a canopy

            canopyId = AddComponent(0, componentId: 1);

        }

        #endregion

        // Accessors (g.Plants , g.Stems, ... They will all return a vid or a list of vids)

        #region Accessors

        /// <summary>
        /// Returns a list containing the identifiers of all plants.
        /// It is to note that plants are in scale number 2.
        /// </summary>
        /// <returns></returns>
        public List<int> Plants()
        {
            return Vertices(2);
        }

        #endregion


        #region Functions fo editing (AddPlant)

        /// <summary>
        /// Add a plant to the canopy.
        /// It is to note that the plant is labelled plant+number of the plant (e.g: plant0, plant1, ..).
        /// </summary>
        /// <returns> Identifier of the plant. </returns>
        public int AddPlant()
        {
            Dictionary<string,dynamic> plantLabel = new Dictionary<string,dynamic>();
            plantLabel.Add("label","plant"+nbPlants);

            nbPlants++;

            int plantId = AddComponent(canopyId, namesValues: plantLabel);

            return plantId;
        }

        #endregion

        // Properties (We'll have in the parameters "vid to which the properties will be added + the properties to add")

        // Query functions

        // Main

        static void Main(String[] args)
        {

        }

    }
}
