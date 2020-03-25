using drmovil.forms.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace drmovil.forms.Helpers
{
    public static partial class Settings
    {
        // Lista global de las stores
        public static List<Store> Stores { get; set; }

        // objeto store que se configuró como default en opciones
        public static Store StoreSeleted { get; set; }
    }
}
