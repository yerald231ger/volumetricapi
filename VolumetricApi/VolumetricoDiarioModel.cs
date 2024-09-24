namespace VolumetricApi;

public class VolumetricoDiarioModel
{
    public int VolumetricoId { get; set; }
    public string FechaRegistro { get; set; }
    public string horaRegistro { get; set; }
    public DateTime FechaProceso { get; set; }
    public string Periodo { get; set; }
    public int VolumetricoEstatusId { get; set; }

    public string BitacoraId { get; set; }
    public int bitacoraNumber { get; set; }
    public string RegulatoryIdentifier { get; set; }
    public string JsonName { get; set; }
    public string JsonData { get; set; }
    public string Status { get; set; }
    public string ReportType { get; set; }
    public string startGenerationDate { get; set; }
    public string volumetricoEstatusId { get; set; }
    public string exportFileJson { get; set; }

    public static VolumetricoDiarioModel Create()
    {
        var volumetricoDiario = new VolumetricoDiarioModel
        {
            VolumetricoId = 123,
            FechaRegistro = "2024-09-23",
            horaRegistro = "08:45",
            FechaProceso = DateTime.Now,
            startGenerationDate = "2024-09-23",
            Periodo = "Q3",
            VolumetricoEstatusId = 1,
            BitacoraId = "B98765",
            bitacoraNumber = 456,
            RegulatoryIdentifier = "RI-002",
            JsonName = "D_819077b7-8747-45f4-9129-d67d83324890_SGM950714DC2_XAX010101000_2024-05-31_EDS-0415_EXO_JSON",
            JsonData = "{ \"report\": \"dummy data\" }",
            Status = "Pending",
            ReportType = "Diario",
            volumetricoEstatusId = "Terminado",
            exportFileJson = "D_819077b7-8747-45f4-9129-d67d83324890_SGM950714DC2_XAX010101000_2024-05-31_EDS-0415_EXO_JSON"
        };

        return volumetricoDiario;
    }
}