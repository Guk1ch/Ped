﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using WpfApp4.Data;

namespace WpfApp4.Functions
{
    public class Registration
    {
        public static ObservableCollection<Sotrudnik> sotrudniks { get; set; }
        public static void RegistrationSotr(string fio, string phone, string password) 
        {
            Sotrudnik newSotr = new Sotrudnik();

            newSotr.FIO = fio.Trim();
            newSotr.Phone = phone.Trim();
            newSotr.Password = password.Trim();
            newSotr.Id_role = 1;
            newSotr.Salary = 25000;

            DB_Class.connection.Sotrudnik.Add(newSotr);
            DB_Class.connection.SaveChanges();
        }
    }
}
