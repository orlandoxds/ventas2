﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace ventas.filtros
{
    class Porticket : ifiltro
    {
        public void filtrar(BunifuCustomDataGrid dgv, TextBox txt)
        {
            sql s = new sql();
            s.dgrid(dgv, "select * from Ticket");
        }
    }
}
