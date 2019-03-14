using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVReader
{
    public class Dispanser
    {
        public string FullName;
        public string ShortName;
        public int PostalCode;
        public string Address;
        public string ChiefName;
        public string ChiefPosition;
        public bool ChiefGender; //true - male, false - female
        public string ChiefPhone;
        public string PublicPhone;
        public string Fax;
        public string Email;
        public bool CloseFlag;
        public string CloseReason;
        public string CloseDate;
        public string ReopenDate;
        public string WorkingHours;
        public string ClarificationOfWorkingHours;
        public string Specialization;
        public string BeneficialDrugPrescriptions;
        public string ExtraInfo;
        public int GLOBALID;
        public Location location;

        public Dispanser(string[] elems)
        {
            FullName = elems[1];
            ShortName = elems[2];
            if (elems[5].Length != 0)
                PostalCode = int.Parse(elems[5]);
            Address = elems[6];
            ChiefName = elems[7];
            ChiefPosition = elems[8];
            if (elems[9] == "мужской")
                ChiefGender = true;
            else if (elems[9] == "женский")
                ChiefGender = false;
            ChiefPhone = elems[10];
            PublicPhone = elems[11];
            Fax = elems[12];
            Email = elems[13];
            if (elems[14] == "действует")
                CloseFlag = false;
            else if (elems[14] == "не действует")
                CloseFlag = true;
            CloseReason = elems[15];
            CloseDate = elems[16];
            ReopenDate = elems[17];
            WorkingHours = elems[18];
            ClarificationOfWorkingHours = elems[19];
            Specialization = elems[20];
            BeneficialDrugPrescriptions = elems[21];
            ExtraInfo = elems[22];
            if (elems[25].Length != 0)
                GLOBALID = int.Parse(elems[25]);
            location = new Location
            {
                AdmArea = elems[3],
                District = elems[4],
                Coordinates = new Point(elems[23], elems[24])
            };
        }

    }
}
