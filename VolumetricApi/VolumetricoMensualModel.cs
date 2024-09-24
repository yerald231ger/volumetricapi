namespace VolumetricApi;

public class VolumetricoMensualModel
{
    public int VolumetricoMensualId { get; set; }
    public string FechaRegistro { get; set; }
    public string HoraRegistro { get; set; }
    public int AnioCorte { get; set; }
    public int MesCorte { get; set; }
    public string Periodo { get; set; }
    public int VolumetricoMensualEstatusId { get; set; }

    public string BitacoraId { get; set; }
    public int BitacoraNumber { get; set; }
    public string RegulatoryIdentifier { get; set; }
    public string JsonName { get; set; }
    public string JsonData { get; set; }
    public string Status { get; set; }
    public DateTime EndGenerationDate { get; set; }
    public string ReportType { get; set; }

    public static VolumetricoMensualModel Create()
    {
        var volumetricoMensual = new VolumetricoMensualModel
        {
            VolumetricoMensualId = 1,
            FechaRegistro = "2024-09-23",
            HoraRegistro = "14:30",
            AnioCorte = 2024,
            MesCorte = 9,
            Periodo = "Q3",
            VolumetricoMensualEstatusId = 2,
            BitacoraId = "B12345",
            BitacoraNumber = 101,
            RegulatoryIdentifier = "RI-001",
            JsonName = "M_819077b7-8747-45f4-9129-d67d83324890_SGM950714DC2_XAX010101000_2024-05-30_EDS-0415_EXO_JSON",
            JsonData = "{ \"key\": \"value\" }",
            Status = "Active",
            EndGenerationDate = DateTime.Now,
            ReportType = "Monthly"
        };

        return volumetricoMensual;
    }
}