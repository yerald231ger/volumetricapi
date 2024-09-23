namespace VolumetricApi;

public class VolumetricoDiarioModel
{
    public int VolumetricoId { get; set; }
    public string FechaRegistro { get; set; }
    public string HoraRegistro { get; set; }
    public DateTime FechaProceso { get; set; }
    public string Periodo { get; set; }
    public int VolumetricoEstatusId { get; set; }

    public string BitacoraId { get; set; }
    public int BitacoraNumber { get; set; }
    public string RegulatoryIdentifier { get; set; }
    public string JsonName { get; set; }
    public string JsonData { get; set; }
    public string Status { get; set; }
    public string ReportType { get; set; }

    public static VolumetricoDiarioModel Create()
    {
        var volumetricoDiario = new VolumetricoDiarioModel
        {
            VolumetricoId = 123,
            FechaRegistro = "2024-09-23",
            HoraRegistro = "08:45",
            FechaProceso = DateTime.Now,
            Periodo = "Q3",
            VolumetricoEstatusId = 1,
            BitacoraId = "B98765",
            BitacoraNumber = 456,
            RegulatoryIdentifier = "RI-002",
            JsonName = "daily_report.json",
            JsonData = "{ \"report\": \"dummy data\" }",
            Status = "Pending",
            ReportType = "Daily"
        };

        return volumetricoDiario;
    }
}