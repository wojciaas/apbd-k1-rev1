namespace apbd_k1_rev1.Models;

public class Prescription_Medicament
{
    public int IdPrescription { get; set; }
    public int IdMedicament { get; set; }
    public int Dose { get; set; }
    public string Details { get; set; }
}