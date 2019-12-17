using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;

    class RegValidate
    {
        // This function validates the email address either email address is official or not.
        // This function is implemeted by Kiran Perveen (SP19-RCS-028)
        public bool validatInput(string valid)
        {
            
            Regex rx = new Regex("^(a|b){0,100}#(a|b){0,100}#(a|b){0,100}$");
            if (!rx.IsMatch(valid) == true)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    public bool validatInputM(string valid)
    {

        Regex rx = new Regex("^a{0,100}b{0,100}a{0,100}$");
        if (!rx.IsMatch(valid) == true)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public bool validatInputP(string valid)
    {

        Regex rx = new Regex("^(a|b){1,100}$");
        if (!rx.IsMatch(valid) == true)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public bool validatInputK(string valid)
    {

        Regex rx = new Regex("^0{1,100}1{1,100}0{1,100}$");
        if (!rx.IsMatch(valid) == true)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

}
