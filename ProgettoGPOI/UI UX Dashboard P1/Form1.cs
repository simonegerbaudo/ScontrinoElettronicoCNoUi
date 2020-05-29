using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace UI_UX_Dashboard_P1
{
    public partial class Form1 : Form
    {
        private void Crea(string progressivo, string formato,
              string tipo,
              string dA,
              string idDispositivo,
              string latGeo,
              string longGeo,
              string dal,
              string al,
              string dataOraRilevazione,
              string aliquotaIVA,
              string imposta,
              string natura,
              string ventilazioneIVA,
              string ammontare,
              string rifNormativo,
              string importoParziale,
              string totaleAmmontareResi,
              string totaleAmmontareAnnulli,
              string beniInSospeso,
              string nonRiscossoServizi,
              string nonRiscossoFatture,
              string totaleDaFattureRT,
              string nonRiscossoDCRaSSN,
              string nonRiscossoOmaggio,
              string codiceAttivita,
              string numeroDocCommerciali,
              string pagatoContanti,
              string pagatoElettronico,
              string scontoApagare,
              string pagatoTicket,
              string numeroTicket,
              string venduto,
              string vendutoContante,
              string vendutoNoContante,
              string incassato,
              string incassatoRicarica,
              string incassatoVendita,
              string totaleResoTubiResto,
              string totaleCaricatoTubiResto,
              string totaleResoManualeTubiResto,
              string totaleCaricatoManualeTubiResto,
              string dataOraPrelievoPrec,
              string progressivoPrelievo,
              string vendutoC,
              string vendutoContanteC,
              string vendutoNoContanteC,
              string incassatoC,
              string incassatoRicaricaC,
              string incassatoVenditaC,
              string totaleResoTubiRestoC,
              string totaleCaricatoTubiRestoC,
              string totaleResoManualeTubiRestoC,
              string totaleCaricatoManualeTubiRestoC,
              string cFTecnico,
              string idPaese,
              string idCodice,
              string dataOra,
              string codice,
              string note,
              string numeroSw,
              string dataRelease,
              string matricola,
              string dataOraS,
              string codiceS,
              string noteS)
        {
            XDocument xDoc = new XDocument(
                 new XDeclaration("1.0", "utf-8", "yes"),
                 new XElement("DatiCorrispettivi", //Create the Root Element with specified Attributes such as Name
                     new XAttribute("versione", "COR10"),

                 new XElement("Trasmissione", //Create first Child that has mutliple Attributes
                      new XElement("Progressivo", progressivo),
                      new XElement("Formato", formato),
                      new XElement("Dispositivo",
                            new XElement("Tipo",tipo),
                            new XElement("IdDispositivo",idDispositivo),
                            new XElement("GeoLocalizzazione",
                                new XElement("Lat",latGeo),
                                new XElement("Long", longGeo)) 
                      )
                 ),

                new XElement("PeriodoInattivo", //Create first Child that has mutliple Attributes
                      new XElement("Dal", dal),
                      new XElement("Al", al)
                 ),

                new XElement("DataOraRilevazione", dataOraRilevazione),

                new XElement("DatiRT", //Create first Child that has mutliple Attributes
                      new XElement("Riepilogo",
                      new XElement("IVA",
                            new XElement("AliquotaIVA", aliquotaIVA),
                            new XElement("Imposta", imposta)
                      ),
                      new XElement("Natura", natura),
                      new XElement("VentilazioneIVA", ventilazioneIVA),
                      new XElement("Ammontare", ammontare),
                      new XElement("RifNormativo", rifNormativo),
                      new XElement("ImportoParziale", importoParziale),
                      new XElement("RifNormativo", rifNormativo),
                      new XElement("TotaleAmmontareResi", totaleAmmontareResi),
                      new XElement("TotaleAmmontareAnnulli", totaleAmmontareAnnulli),
                      new XElement("BeniInSospeso", beniInSospeso),
                      new XElement("NonRiscossoServizi", nonRiscossoServizi),
                      new XElement("NonRiscossoFatture", nonRiscossoFatture),
                      new XElement("TotaleDaFattureRT", totaleDaFattureRT),
                      new XElement("NonRiscossoDCRaSSN", nonRiscossoDCRaSSN),
                      new XElement("NonRiscossoOmaggi", nonRiscossoOmaggio),
                      new XElement("CodiceAttivita", codiceAttivita),
                      new XElement("Totali",
                            new XElement("NumeroDocCommerciali", numeroDocCommerciali),
                            new XElement("PagatoContanti", pagatoContanti),
                            new XElement("PagatoElettronico", pagatoElettronico),
                            new XElement("ScontoApagare", scontoApagare),
                            new XElement("Ticket",
                                new XElement("PagatoTicket", pagatoTicket),
                                new XElement("NumeroTicket", numeroTicket))
                      ))
                 ),



                new XElement("DatiDA", //Create first Child that has mutliple Attributes
                      new XElement("Periodo",
                        new XElement("Venduto", venduto),
                        new XElement("VendutoContante", vendutoContante),
                        new XElement("VendutoNoContante", vendutoNoContante),
                        new XElement("Incassato", incassato),
                        new XElement("IncassatoRicarica", incassatoRicarica),
                        new XElement("IncassatoVendita", incassatoVendita),
                        new XElement("TotaleResoTubiResto", totaleResoManualeTubiResto),
                        new XElement("TotaleCaricatoTubiResto", totaleCaricatoManualeTubiResto),
                        new XElement("TotaleResoManualeTubiResto", totaleResoManualeTubiResto),
                        new XElement("DataOraPrelievoPrec", dataOraPrelievoPrec),
                        new XElement("ProgressivoPrelievo", progressivoPrelievo)
                      ),
                      new XElement("Cumulato",
                        new XElement("Venduto", vendutoC),
                        new XElement("VendutoContante", vendutoContanteC),
                        new XElement("VendutoNoContante", vendutoNoContanteC),
                        new XElement("Incassato", incassatoC),
                        new XElement("IncassatoRicarica", incassatoRicaricaC),
                        new XElement("IncassatoVendita", incassatoVenditaC),
                        new XElement("TotaleResoTubiResto", totaleResoManualeTubiRestoC),
                        new XElement("TotaleCaricatoTubiResto", totaleCaricatoManualeTubiRestoC),
                        new XElement("TotaleResoManualeTubiResto", totaleResoManualeTubiRestoC)
                      )
                 ),

                new XElement("InterventoTecnico", //Create first Child that has mutliple Attributes
                      new XElement("CFTecnico", cFTecnico),
                      new XElement("IdIVALaboratorio",
                        new XElement("IdPaese", idPaese),
                        new XElement("IdCodice", idCodice)
                      ),
                     new XElement("DataOra", dataOra),
                     new XElement("Codice", codice),
                     new XElement("Note", note),
                     new XElement("NumeroSw", numeroSw),
                     new XElement("DataRelease", dataRelease)
                 ),
                 new XElement("Segnalazione",
                     new XAttribute("Matricola", matricola),
                     new XAttribute("DataOra", dataOraS),
                     new XAttribute("Codice", codiceS),
                     new XAttribute("Note", noteS)
                 ) //the second string is the value between brackets

                     ) //end of Root Element
                 );
            //save the data into a file name/path.
            //xDoc.Save(path);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
