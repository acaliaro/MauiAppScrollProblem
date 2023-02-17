using System.Text.Json.Serialization;

namespace VimarCrm.Models.Cliente
{
    public class ClienteItem
    {
      

        [JsonPropertyName("id")]
        public Guid Id { get; set; }

        [JsonPropertyName("nome")]
        public string Nome { get; set; }

        [JsonPropertyName("codiceCliente")]
        public string CodiceCliente { get; set; }

        [JsonPropertyName("salesArea")]
        public long? SalesArea { get; set; }

        [JsonPropertyName("citta")]
        public string Citta { get; set; }

        [JsonPropertyName("indirizzo")]
        public string Indirizzo { get; set; }

        [JsonPropertyName("regione")]
        public string Regione { get; set; }

        [JsonPropertyName("cap")]
        public string Cap { get; set; }

        [JsonPropertyName("provincia")]
        public string Provincia { get; set; }

        [JsonPropertyName("emailAddress1")]
        public string EmailAddress1 { get; set; }

        [JsonPropertyName("emailAddress2")]
        public string EmailAddress2 { get; set; }

        [JsonPropertyName("emailAddress3")]
        public string EmailAddress3 { get; set; }

        [JsonPropertyName("doNotEmail")]
        public bool DoNotEmail { get; set; }

        [JsonPropertyName("telephone1")]
        public string Telephone1 { get; set; }

        [JsonPropertyName("telephone2")]
        public string Telephone2 { get; set; }

        [JsonPropertyName("telephone3")]
        public string Telephone3 { get; set; }

        [JsonPropertyName("doNotPhone")]
        public bool DoNotPhone { get; set; }

        [JsonPropertyName("fax")]
        public string Fax { get; set; }

        [JsonPropertyName("doNotFax")]
        public bool DoNotFax { get; set; }

        [JsonPropertyName("codiceCategoriaPrincipale")]
        public string CodiceCategoriaPrincipale { get; set; }

        [JsonPropertyName("descrizioneCategoriaPrincipale")]
        public string DescrizioneCategoriaPrincipale { get; set; }

        [JsonPropertyName("codiceCategoriaSecondaria")]
        public string CodiceCategoriaSecondaria { get; set; }

        [JsonPropertyName("descrizioneCategoriaSecondaria")]
        public string DescrizioneCategoriaSecondaria { get; set; }

        [JsonPropertyName("codiceNazione")]
        public string CodiceNazione { get; set; }

        [JsonPropertyName("descrizioneNazione")]
        public string DescrizioneNazione { get; set; }

        [JsonPropertyName("codiceRegione")]
        public string CodiceRegione { get; set; }

        [JsonPropertyName("descrizioneRegione")]
        public string DescrizioneRegione { get; set; }

        [JsonPropertyName("codiceProvincia")]
        public string CodiceProvincia { get; set; }

        [JsonPropertyName("descrizioneProvincia")]
        public string DescrizioneProvincia { get; set; }

        [JsonPropertyName("descrizioneLocalita")]
        public string DescrizioneLocalita { get; set; }

        [JsonPropertyName("nomeCompletoSistemUser")]
        public string NomeCompletoSistemUser { get; set; }

        [JsonPropertyName("cognomeSistemUser")]
        public string CognomeSistemUser { get; set; }

        [JsonPropertyName("nomeSistemUser")]
        public string NomeSistemUser { get; set; }

        [JsonPropertyName("emailInternaSistemUser")]
        public string EmailInternaSistemUser { get; set; }

        [JsonPropertyName("nomeCompletoResponsabile")]
        public string NomeCompletoResponsabile { get; set; }

        [JsonPropertyName("cognomeResponsabile")]
        public string CognomeResponsabile { get; set; }

        [JsonPropertyName("nomeResponsabile")]
        public string NomeResponsabile { get; set; }

        [JsonPropertyName("emailInternaResponsabile")]
        public string EmailInternaResponsabile { get; set; }


    }
}
