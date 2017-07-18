using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class vmVehicle : BaseViewModel
    {
        public Guid VehicleID { get; set; }             //  ID                
        public string NumberPlate { get; set; }         //  ΑΡΙΘΜΟΣ ΚΥΚΛΟΦΟΡΙΑΣ              
        public string Description { get; set; }         //  ΠΕΡΙΓΡΑΦΗ        
        public Guid VehicleTypeID { get; set; }         //  ID ΤΥΠΟΥ ΟΧΗΜΑΤΟΣ
        public Guid ColorID { get; set; }               //  ID ΧΡΩΜΑΤΟΣ
        public Guid ModelID { get; set; }               //  ID ΚΑΤΗΓΟΡΙΑΣ ΜΑΡΚΑΣ/ΜΟΝΤΕΛΟΥ
        public double EngineCubic { get; set; }         //  ΚΥΒΙΣΜΟΣ ΜΗΧΑΝΗΣ
        public DateTime FirstDate { get; set; }         //  ΠΡΩΤΗ ΗΜΕΡΟΜΗΝΙΑ ΚΥΚΛΟΦΟΡΊΑΣ
        public int NumberDoors { get; set; }            //  ΑΡΙΘΜΟΣ ΘΥΡΩΝ
        public string NumberChassis { get; set; }       //  ΑΡΙΘΜΟΣ ΣΑΣΙ
        public string NumberEngine { get; set; }        //  ΑΡΙΘΜΟΣ ΜΗΧΑΝΗΣ        
        public string Comments { get; set; }            //  ΣΧΟΛΙΑ
        public Guid UserID { get; set; }                // ID ΧΕΙΡΙΣΤΗ 
    }
}
