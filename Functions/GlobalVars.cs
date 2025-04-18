﻿#region "Copyright"
/***********************************************************************************
* Copyright (C) 2025  Tiago.NET
*
* This program is free software: you can redistribute it and/or modify
* it under the terms of the GNU General Public License as published by
* the Free Software Foundation, either version 3 of the License, or
* (at your option) any later version.
*
* This program is distributed in the hope that it will be useful,
* but WITHOUT ANY WARRANTY; without even the implied warranty of
* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
* GNU General Public License for more details.
*
* You should have received a copy of the GNU General Public License
* along with this program.  If not, see <https://www.gnu.org/licenses/>.
**********************************************************************************/
#endregion

using Sunny.UI;
using Aniflix.Data;
using FontAwesome.Sharp.Material;

namespace Aniflix.Functions
{
    public static class GlobalVars
    {
        public static MaterialButton? currentBtn;
        public static Panel? leftBorderBtn;
        public static UIForm? currentChildForm;
        public static Random? random;
        public static int currentId = 0;
        public static bool editando = false;
        public static string TMDB_KEY = "f04ae616e26fc665d8b08357ce77a1b0";
        public static string DEEPL_KEY = "7feb3eb8-de95-4312-843c-1064aecdab8b:fx";
        public static GeneralContext context = new();
        public static bool isClosing = false;
        public static string SESSION_ID = "f7d766441aabec75ecf4cf4d24905433ac93a58d";
    }
}
