using NoelByEsnParis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoelByEsnParis.Services
{
    public class NoelService
    {
        public List<string> CadeauNoel(List<string> listPrenom)
        {
            int nombreDePersone = listPrenom.Count;
            List<string> result = new List<string>();
            List<string> listPourCouplePrenom = listPrenom;
            for (int x = 0; x < nombreDePersone / 2; x++)
            {
                Random randomNumber = new Random();
                int tirageAuSort = randomNumber.Next(1, listPourCouplePrenom.Count);
                string couplePourCadeau = listPourCouplePrenom[0] + " / " + listPourCouplePrenom[tirageAuSort];
                listPourCouplePrenom.RemoveAt(tirageAuSort);
                listPourCouplePrenom.RemoveAt(0);
                result.Add(couplePourCadeau);
            }
            return result;
        }
        public void AddPerson(Person Person)
        {

        }
 
    }
}