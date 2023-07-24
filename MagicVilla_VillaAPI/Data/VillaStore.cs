﻿using System;
using MagicVilla_VillaAPI.Models.Dto;

namespace MagicVilla_VillaAPI.Data
{
	public class VillaStore
	{
		public static List<VillaDTO> villaList = new List<VillaDTO> { 
            new VillaDTO { Id = 1, Name = "Pool View", Occupancy=4, Sqft=2000 },
            new VillaDTO { Id = 2, Name = "Beach View", Occupancy=3, Sqft=1000 }
        };
    }
}

