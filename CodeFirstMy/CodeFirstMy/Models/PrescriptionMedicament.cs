﻿using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstMy.Models;

[Table("Prescription_Medicament")]
[PrimaryKey(nameof(IdMedicament), nameof(IdPrescription))]
public class PrescriptionMedicament
{
    public int IdMedicament { get; set; }
    public int IdPrescription { get; set; }
    public int? Dose { get; set; }
    public string Details { get; set; }
    
    [ForeignKey(nameof(IdMedicament))] 
    public Medicament Medicament { get; set; } = null!;

    [ForeignKey(nameof(IdPrescription))]
    public Prescription Prescription { get; set; } = null!;
}