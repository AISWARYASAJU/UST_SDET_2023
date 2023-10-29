using Asssignment1.MyException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asssignment1
{
    internal class MedicalRecord: Patient
    {
        public int  RecordId { get; set; }
        public string? PatientName { get; set; }
        public string? Diagnosis { get; set; }
        public double TreatmentCost { get; set; }
        List<MedicalRecord> record = new List<MedicalRecord>();

        public void DisplayMedicalRecords(int id, string name, string diagnosis, double treatmentcost)
        
        {
            if (string.IsNullOrEmpty(PatientName))
            {
                throw new MyExceptions(CustomException.exceptionmessage[3]);
            }
            /*else if (age < 0 || age >= 120)
            {
                throw new MyExceptions(CustomException.exceptionmessage[2]);
            }*/
            else if (string.IsNullOrEmpty(Diagnosis))
            {
                throw new MyExceptions(CustomException.exceptionmessage[9]);
            }
            else
            {
                record.Add(new MedicalRecord { RecordId = id, PatientName = PatientName, TreatmentCost= treatmentcost, Diagnosis = diagnosis });
                //  patients.Add(new Patient { PatientID = id, PatientName = name, Age = age, Diagnosis = diagnosis });


            }
        }


    }


    }

