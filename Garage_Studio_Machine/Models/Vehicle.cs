using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ViewModels;

namespace Models
{
    public class Vehicle : BaseEntity
    {
        public Vehicle()
        {}

        // Entity VEHICLE Fields

        public Guid VehicleID { get; set; }             //  ID        
        [MaxLength(50)]
        [Index("IDX_UNQ_Vehicle_NumberPlate", 1, IsUnique = true), Required]
        public string NumberPlate { get; set; }         //  ΑΡΙΘΜΟΣ ΚΥΚΛΟΦΟΡΙΑΣ      
        [Required, MaxLength(200)]
        public string Description { get; set; }         //  ΠΕΡΙΓΡΑΦΗ
        [Required]
        public Guid VehicleTypeID { get; set; }         //  ID ΤΥΠΟΥ ΟΧΗΜΑΤΟΣ
        [Required]
        public Guid ColorID { get; set; }               //  ID ΧΡΩΜΑΤΟΣ
        public Guid ModelID { get; set; }               //  ID ΚΑΤΗΓΟΡΙΑΣ ΜΑΡΚΑΣ/ΜΟΝΤΕΛΟΥ
        public double EngineCubic { get; set; }         //  ΚΥΒΙΣΜΟΣ ΜΗΧΑΝΗΣ
        public DateTime FirstDate { get; set; }         //  ΠΡΩΤΗ ΗΜΕΡΟΜΗΝΙΑ ΚΥΚΛΟΦΟΡΊΑΣ
        public int NumberDoors { get; set; }            //  ΑΡΙΘΜΟΣ ΘΥΡΩΝ
        [MaxLength(100)]
        public string NumberChassis { get; set; }       //  ΑΡΙΘΜΟΣ ΣΑΣΙ
        [MaxLength(100)]
        public string NumberEngine { get; set; }        //  ΑΡΙΘΜΟΣ ΜΗΧΑΝΗΣ        
        [MaxLength(2048)]
        public string Comments { get; set; }            //  ΣΧΟΛΙΑ
        [Required]
        public Guid UserID { get; set; }                // ID ΧΕΙΡΙΣΤΗ

        // 1:1 Relation [Navigation]
        public VehicleType VehicleType { get; set; }
        public Color Color { get; set; }
    }

    public static class VehicleExtensions
    {
        public static vmVehicle ToViewModel(this Vehicle rec)
        {
            return new vmVehicle
            {
                VehicleID = rec.VehicleID,
                NumberPlate = rec.NumberPlate,
                Description = rec.Description,
                VehicleTypeID = rec.VehicleTypeID,
                ColorID = rec.ColorID,
                ModelID = rec.ModelID,
                EngineCubic = rec.EngineCubic,
                FirstDate = rec.FirstDate,
                NumberDoors = rec.NumberDoors,
                NumberChassis = rec.NumberChassis,
                NumberEngine = rec.NumberEngine,
                Comments = rec.Comments,
                UserID = rec.UserID
            };
        }

        public static Vehicle FromViewModel(this Vehicle rec, vmVehicle vm)
        {
            rec.VehicleID = vm.VehicleID;
            rec.NumberPlate = vm.NumberPlate.ToUpper();
            rec.Description = vm.Description;
            rec.VehicleTypeID = vm.VehicleTypeID;
            rec.ColorID = vm.ColorID;
            rec.ModelID = vm.ModelID;
            rec.EngineCubic = vm.EngineCubic;
            rec.FirstDate = vm.FirstDate;
            rec.NumberDoors = vm.NumberDoors;
            rec.NumberChassis = vm.NumberChassis;
            rec.NumberEngine = vm.NumberEngine;
            rec.Comments = vm.Comments;
            rec.UserID = vm.UserID;
            return rec;
        }
    }
}
