﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using PRG282_Project.DataAccesLayer;
using PRG282_Project.PresentationLayer;


namespace PRG282_Project.BusinessLogicLayer
{
    class DataHandler
    {
        public DataHandler() { }
        public void LoginVerification(Employee person)
        {
            
            
                using (StreamReader sr = File.OpenText(@"C:\Users\Marlouf\Source\Repos\PRG282_Project2\DATA\TextFile1.txt"))
                {
                    string input;
                    while ((input = sr.ReadLine()) != null)
                    {
                        string[] line = input.Split(',');
                        string username = line[0];
                        string password = line[1];
                        string US = person.Username;
                        string PS = person.Password;
                        if (US == username)
                        {
                            if (PS == password)
                            {
                                MessageBox.Show("Welcome ");
                                Student_Form st = new Student_Form();
                                st.Show();
                                Login_Form lg = new Login_Form();
                                lg.Hide();
                            }
                            else
                            {
                               MessageBox.Show("Incorrect Password ");
                            }
                        }
                        else
                        {
                           MessageBox.Show("Incorrect P ");
                       }
                    }
                }
            
           





        }
    }
}
