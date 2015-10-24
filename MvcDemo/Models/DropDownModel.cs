using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace MvcDemo.Models
{
    public class DropDownModel
    {
        [Display(Name = "Län")]
        public Länskoder County { get; set; }

        [Display(Name = "Kommun")]
        public Kommunkoder Municipality { get; set; }

        public IEnumerable<SelectListItem> AllCounties
        {
            get
            {
                return EnumHelper.GetSelectList(typeof(Länskoder)).OrderBy(x => x.Text);
            }
        }

        public IEnumerable<SelectListItem> MunicipalitiesInCounty
        {
            get
            {
                return AllMunicipalities.Where(k => int.Parse(k.Value) / 100 == (int)County);
            }
        }

        public IEnumerable<SelectListItem> AllMunicipalities
        {
            get
            {
                return EnumHelper.GetSelectList(typeof(Kommunkoder)).OrderBy(x => x.Text);
            }
        }
    }

    public enum Länskoder
    {
        [Display(Name = "Stockholms län")]
        Stockholms_län = 01,
        [Display(Name = "Uppsala län")]
        Uppsala_län = 03,
        [Display(Name = "Södermanlands län")]
        Södermanlands_län = 04,
        [Display(Name = "Östergötlands län")]
        Östergötlands_län = 05,
        [Display(Name = "Jönköpings län")]
        Jönköpings_län = 06,
        [Display(Name = "Kronobergs län")]
        Kronobergs_län = 07,
        [Display(Name = "Kalmar län")]
        Kalmar_län = 08,
        [Display(Name = "Gotlands län")]
        Gotlands_län = 09,
        [Display(Name = "Blekinge län")]
        Blekinge_län = 10,
        [Display(Name = "Skåne län")]
        Skåne_län = 12,
        [Display(Name = "Hallands län")]
        Hallands_län = 13,
        [Display(Name = "Västra Götalands län")]
        Västra_Götalands_län = 14,
        [Display(Name = "Värmlands län")]
        Värmlands_län = 17,
        [Display(Name = "Örebro län")]
        Örebro_län = 18,
        [Display(Name = "Västmanlands län")]
        Västmanlands_län = 19,
        [Display(Name = "Dalarnas län")]
        Dalarnas_län = 20,
        [Display(Name = "Gävleborgs län")]
        Gävleborgs_län = 21,
        [Display(Name = "Västernorrlands län")]
        Västernorrlands_län = 22,
        [Display(Name = "Jämtlands län")]
        Jämtlands_län = 23,
        [Display(Name = "Västerbottens län")]
        Västerbottens_län = 24,
        [Display(Name = "Norrbottens län")]
        Norrbottens_län = 25,
    }

    public enum Kommunkoder
    {
        // 01 Stockholms län
        [Display(Name = "Upplands Väsby")]
        Upplands_Väsby = 0114,
        [Display(Name = "Vallentuna")]
        Vallentuna = 0115,
        [Display(Name = "Österåker")]
        Österåker = 0117,
        [Display(Name = "Värmdö")]
        Värmdö = 0120,
        [Display(Name = "Järfälla")]
        Järfälla = 0123,
        [Display(Name = "Ekerö")]
        Ekerö = 0125,
        [Display(Name = "Huddinge")]
        Huddinge = 0126,
        [Display(Name = "Botkyrka")]
        Botkyrka = 0127,
        [Display(Name = "Salem")]
        Salem = 0128,
        [Display(Name = "Haninge")]
        Haninge = 0136,
        [Display(Name = "Tyresö")]
        Tyresö = 0138,
        [Display(Name = "Upplands-Bro")]
        Upplands_Bro = 0139,
        [Display(Name = "Nykvarn")]
        Nykvarn = 0140,
        [Display(Name = "Täby")]
        Täby = 0160,
        [Display(Name = "Danderyd")]
        Danderyd = 0162,
        [Display(Name = "Sollentuna")]
        Sollentuna = 0163,
        [Display(Name = "Stockholm")]
        Stockholm = 0180,
        [Display(Name = "Södertälje")]
        Södertälje = 0181,
        [Display(Name = "Nacka")]
        Nacka = 0182,
        [Display(Name = "Sundbyberg")]
        Sundbyberg = 0183,
        [Display(Name = "Solna")]
        Solna = 0184,
        [Display(Name = "Lidingö")]
        Lidingö = 0186,
        [Display(Name = "Vaxholm")]
        Vaxholm = 0187,
        [Display(Name = "Norrtälje")]
        Norrtälje = 0188,
        [Display(Name = "Sigtuna")]
        Sigtuna = 0191,
        [Display(Name = "Nynäshamn")]
        Nynäshamn = 0192,
        // 03 Uppsala län
        [Display(Name = "Håbo")]
        Håbo = 0305,
        [Display(Name = "Älvkarleby")]
        Älvkarleby = 0319,
        [Display(Name = "Knivsta")]
        Knivsta = 0330,
        [Display(Name = "Heby")]
        Heby = 0331,
        [Display(Name = "Tierp")]
        Tierp = 0360,
        [Display(Name = "Uppsala")]
        Uppsala = 0380,
        [Display(Name = "Enköping")]
        Enköping = 0381,
        [Display(Name = "Östhammar")]
        Östhammar = 0382,
        // 04 Södermanlands län
        [Display(Name = "Vingåker")]
        Vingåker = 0428,
        [Display(Name = "Gnesta")]
        Gnesta = 0461,
        [Display(Name = "Nyköping")]
        Nyköping = 0480,
        [Display(Name = "Oxelösund")]
        Oxelösund = 0481,
        [Display(Name = "Flen")]
        Flen = 0482,
        [Display(Name = "Katrineholm")]
        Katrineholm = 0483,
        [Display(Name = "Eskilstuna")]
        Eskilstuna = 0484,
        [Display(Name = "Strängnäs")]
        Strängnäs = 0486,
        [Display(Name = "Trosa")]
        Trosa = 0488,
        // 05 Östergötlands län
        [Display(Name = "Ödeshög")]
        Ödeshög = 0509,
        [Display(Name = "Ydre")]
        Ydre = 0512,
        [Display(Name = "Kinda")]
        Kinda = 0513,
        [Display(Name = "Boxholm")]
        Boxholm = 0560,
        [Display(Name = "Åtvidaberg")]
        Åtvidaberg = 0561,
        [Display(Name = "Finspång")]
        Finspång = 0562,
        [Display(Name = "Valdemarsvik")]
        Valdemarsvik = 0563,
        [Display(Name = "Linköping")]
        Linköping = 0580,
        [Display(Name = "Norrköping")]
        Norrköping = 0581,
        [Display(Name = "Söderköping")]
        Söderköping = 0582,
        [Display(Name = "Motala")]
        Motala = 0583,
        [Display(Name = "Vadstena")]
        Vadstena = 0584,
        [Display(Name = "Mjölby")]
        Mjölby = 0586,
        // 06 Jönköpings län
        [Display(Name = "Aneby")]
        Aneby = 0604,
        [Display(Name = "Gnosjö")]
        Gnosjö = 0617,
        [Display(Name = "Mullsjö")]
        Mullsjö = 0642,
        [Display(Name = "Habo")]
        Habo = 0643,
        [Display(Name = "Gislaved")]
        Gislaved = 0662,
        [Display(Name = "Vaggeryd")]
        Vaggeryd = 0665,
        [Display(Name = "Jönköping")]
        Jönköping = 0680,
        [Display(Name = "Nässjö")]
        Nässjö = 0682,
        [Display(Name = "Värnamo")]
        Värnamo = 0683,
        [Display(Name = "Sävsjö")]
        Sävsjö = 0684,
        [Display(Name = "Vetlanda")]
        Vetlanda = 0685,
        [Display(Name = "Eksjö")]
        Eksjö = 0686,
        [Display(Name = "Tranås")]
        Tranås = 0687,
        // 07 Kronobergs län
        [Display(Name = "Uppvidinge")]
        Uppvidinge = 0760,
        [Display(Name = "Lessebo")]
        Lessebo = 0761,
        [Display(Name = "Tingsryd")]
        Tingsryd = 0763,
        [Display(Name = "Alvesta")]
        Alvesta = 0764,
        [Display(Name = "Älmhult")]
        Älmhult = 0765,
        [Display(Name = "Markaryd")]
        Markaryd = 0767,
        [Display(Name = "Växjö")]
        Växjö = 0780,
        [Display(Name = "Ljungby")]
        Ljungby = 0781,
        // 08 Kalmar län
        [Display(Name = "Högsby")]
        Högsby = 0821,
        [Display(Name = "Torsås")]
        Torsås = 0834,
        [Display(Name = "Mörbylånga")]
        Mörbylånga = 0840,
        [Display(Name = "Hultsfred")]
        Hultsfred = 0860,
        [Display(Name = "Mönsterås")]
        Mönsterås = 0861,
        [Display(Name = "Emmaboda")]
        Emmaboda = 0862,
        [Display(Name = "Kalmar")]
        Kalmar = 0880,
        [Display(Name = "Nybro")]
        Nybro = 0881,
        [Display(Name = "Oskarshamn")]
        Oskarshamn = 0882,
        [Display(Name = "Västervik")]
        Västervik = 0883,
        [Display(Name = "Vimmerby")]
        Vimmerby = 0884,
        [Display(Name = "Borgholm")]
        Borgholm = 0885,
        // 09 Gotlands län
        [Display(Name = "Gotland")]
        Gotland = 0980,
        // 10 Blekinge län
        [Display(Name = "Olofström")]
        Olofström = 1060,
        [Display(Name = "Karlskrona")]
        Karlskrona = 1080,
        [Display(Name = "Ronneby")]
        Ronneby = 1081,
        [Display(Name = "Karlshamn")]
        Karlshamn = 1082,
        [Display(Name = "Sölvesborg")]
        Sölvesborg = 1083,
        // 12 Skåne län
        [Display(Name = "Svalöv")]
        Svalöv = 1214,
        [Display(Name = "Staffanstorp")]
        Staffanstorp = 1230,
        [Display(Name = "Burlöv")]
        Burlöv = 1231,
        [Display(Name = "Vellinge")]
        Vellinge = 1233,
        [Display(Name = "Östra Göinge")]
        Östra_Göinge = 1256,
        [Display(Name = "Örkelljunga")]
        Örkelljunga = 1257,
        [Display(Name = "Bjuv")]
        Bjuv = 1260,
        [Display(Name = "Kävlinge")]
        Kävlinge = 1261,
        [Display(Name = "Lomma")]
        Lomma = 1262,
        [Display(Name = "Svedala")]
        Svedala = 1263,
        [Display(Name = "Skurup")]
        Skurup = 1264,
        [Display(Name = "Sjöbo")]
        Sjöbo = 1265,
        [Display(Name = "Hörby")]
        Hörby = 1266,
        [Display(Name = "Höör")]
        Höör = 1267,
        [Display(Name = "Tomelilla")]
        Tomelilla = 1270,
        [Display(Name = "Bromölla")]
        Bromölla = 1272,
        [Display(Name = "Osby")]
        Osby = 1273,
        [Display(Name = "Perstorp")]
        Perstorp = 1275,
        [Display(Name = "Klippan")]
        Klippan = 1276,
        [Display(Name = "Åstorp")]
        Åstorp = 1277,
        [Display(Name = "Båstad")]
        Båstad = 1278,
        [Display(Name = "Malmö")]
        Malmö = 1280,
        [Display(Name = "Lund")]
        Lund = 1281,
        [Display(Name = "Landskrona")]
        Landskrona = 1282,
        [Display(Name = "Helsingborg")]
        Helsingborg = 1283,
        [Display(Name = "Höganäs")]
        Höganäs = 1284,
        [Display(Name = "Eslöv")]
        Eslöv = 1285,
        [Display(Name = "Ystad")]
        Ystad = 1286,
        [Display(Name = "Trelleborg")]
        Trelleborg = 1287,
        [Display(Name = "Kristianstad")]
        Kristianstad = 1290,
        [Display(Name = "Simrishamn")]
        Simrishamn = 1291,
        [Display(Name = "Ängelholm")]
        Ängelholm = 1292,
        [Display(Name = "Hässleholm")]
        Hässleholm = 1293,
        // 13 Hallands län
        [Display(Name = "Hylte")]
        Hylte = 1315,
        [Display(Name = "Halmstad")]
        Halmstad = 1380,
        [Display(Name = "Laholm")]
        Laholm = 1381,
        [Display(Name = "Falkenberg")]
        Falkenberg = 1382,
        [Display(Name = "Varberg")]
        Varberg = 1383,
        [Display(Name = "Kungsbacka")]
        Kungsbacka = 1384,
        // 14 Västra Götalands län
        [Display(Name = "Härryda")]
        Härryda = 1401,
        [Display(Name = "Partille")]
        Partille = 1402,
        [Display(Name = "Öckerö")]
        Öckerö = 1407,
        [Display(Name = "Stenungsund")]
        Stenungsund = 1415,
        [Display(Name = "Tjörn")]
        Tjörn = 1419,
        [Display(Name = "Orust")]
        Orust = 1421,
        [Display(Name = "Sotenäs")]
        Sotenäs = 1427,
        [Display(Name = "Munkedal")]
        Munkedal = 1430,
        [Display(Name = "Tanum")]
        Tanum = 1435,
        [Display(Name = "Dals-Ed")]
        Dals_Ed = 1438,
        [Display(Name = "Färgelanda")]
        Färgelanda = 1439,
        [Display(Name = "Ale")]
        Ale = 1440,
        [Display(Name = "Lerum")]
        Lerum = 1441,
        [Display(Name = "Vårgårda")]
        Vårgårda = 1442,
        [Display(Name = "Bollebygd")]
        Bollebygd = 1443,
        [Display(Name = "Grästorp")]
        Grästorp = 1444,
        [Display(Name = "Essunga")]
        Essunga = 1445,
        [Display(Name = "Karlsborg")]
        Karlsborg = 1446,
        [Display(Name = "Gullspång")]
        Gullspång = 1447,
        [Display(Name = "Tranemo")]
        Tranemo = 1452,
        [Display(Name = "Bengtsfors")]
        Bengtsfors = 1460,
        [Display(Name = "Mellerud")]
        Mellerud = 1461,
        [Display(Name = "Lilla Edet")]
        Lilla_Edet = 1462,
        [Display(Name = "Mark")]
        Mark = 1463,
        [Display(Name = "Svenljunga")]
        Svenljunga = 1465,
        [Display(Name = "Herrljunga")]
        Herrljunga = 1466,
        [Display(Name = "Vara")]
        Vara = 1470,
        [Display(Name = "Götene")]
        Götene = 1471,
        [Display(Name = "Tibro")]
        Tibro = 1472,
        [Display(Name = "Töreboda")]
        Töreboda = 1473,
        [Display(Name = "Göteborg")]
        Göteborg = 1480,
        [Display(Name = "Mölndal")]
        Mölndal = 1481,
        [Display(Name = "Kungälv")]
        Kungälv = 1482,
        [Display(Name = "Lysekil")]
        Lysekil = 1484,
        [Display(Name = "Uddevalla")]
        Uddevalla = 1485,
        [Display(Name = "Strömstad")]
        Strömstad = 1486,
        [Display(Name = "Vänersborg")]
        Vänersborg = 1487,
        [Display(Name = "Trollhättan")]
        Trollhättan = 1488,
        [Display(Name = "Alingsås")]
        Alingsås = 1489,
        [Display(Name = "Borås")]
        Borås = 1490,
        [Display(Name = "Ulricehamn")]
        Ulricehamn = 1491,
        [Display(Name = "Åmål")]
        Åmål = 1492,
        [Display(Name = "Mariestad")]
        Mariestad = 1493,
        [Display(Name = "Lidköping")]
        Lidköping = 1494,
        [Display(Name = "Skara")]
        Skara = 1495,
        [Display(Name = "Skövde")]
        Skövde = 1496,
        [Display(Name = "Hjo")]
        Hjo = 1497,
        [Display(Name = "Tidaholm")]
        Tidaholm = 1498,
        [Display(Name = "Falköping")]
        Falköping = 1499,
        // 17 Värmlands län
        [Display(Name = "Kil")]
        Kil = 1715,
        [Display(Name = "Eda")]
        Eda = 1730,
        [Display(Name = "Torsby")]
        Torsby = 1737,
        [Display(Name = "Storfors")]
        Storfors = 1760,
        [Display(Name = "Hammarö")]
        Hammarö = 1761,
        [Display(Name = "Munkfors")]
        Munkfors = 1762,
        [Display(Name = "Forshaga")]
        Forshaga = 1763,
        [Display(Name = "Grums")]
        Grums = 1764,
        [Display(Name = "Årjäng")]
        Årjäng = 1765,
        [Display(Name = "Sunne")]
        Sunne = 1766,
        [Display(Name = "Karlstad")]
        Karlstad = 1780,
        [Display(Name = "Kristinehamn")]
        Kristinehamn = 1781,
        [Display(Name = "Filipstad")]
        Filipstad = 1782,
        [Display(Name = "Hagfors")]
        Hagfors = 1783,
        [Display(Name = "Arvika")]
        Arvika = 1784,
        [Display(Name = "Säffle")]
        Säffle = 1785,
        // 18 Örebro län
        [Display(Name = "Lekeberg")]
        Lekeberg = 1814,
        [Display(Name = "Laxå")]
        Laxå = 1860,
        [Display(Name = "Hallsberg")]
        Hallsberg = 1861,
        [Display(Name = "Degerfors")]
        Degerfors = 1862,
        [Display(Name = "Hällefors")]
        Hällefors = 1863,
        [Display(Name = "Ljusnarsberg")]
        Ljusnarsberg = 1864,
        [Display(Name = "Örebro")]
        Örebro = 1880,
        [Display(Name = "Kumla")]
        Kumla = 1881,
        [Display(Name = "Askersund")]
        Askersund = 1882,
        [Display(Name = "Karlskoga")]
        Karlskoga = 1883,
        [Display(Name = "Nora")]
        Nora = 1884,
        [Display(Name = "Lindesberg")]
        Lindesberg = 1885,
        // 19 Västmanlands län
        [Display(Name = "Skinnskatteberg")]
        Skinnskatteberg = 1904,
        [Display(Name = "Surahammar")]
        Surahammar = 1907,
        [Display(Name = "Kungsör")]
        Kungsör = 1960,
        [Display(Name = "Hallstahammar")]
        Hallstahammar = 1961,
        [Display(Name = "Norberg")]
        Norberg = 1962,
        [Display(Name = "Västerås")]
        Västerås = 1980,
        [Display(Name = "Sala")]
        Sala = 1981,
        [Display(Name = "Fagersta")]
        Fagersta = 1982,
        [Display(Name = "Köping")]
        Köping = 1983,
        [Display(Name = "Arboga")]
        Arboga = 1984,
        // 20 Dalarnas län
        [Display(Name = "Vansbro")]
        Vansbro = 2021,
        [Display(Name = "Malung-Sälen")]
        Malung_Sälen = 2023,
        [Display(Name = "Gagnef")]
        Gagnef = 2026,
        [Display(Name = "Leksand")]
        Leksand = 2029,
        [Display(Name = "Rättvik")]
        Rättvik = 2031,
        [Display(Name = "Orsa")]
        Orsa = 2034,
        [Display(Name = "Älvdalen")]
        Älvdalen = 2039,
        [Display(Name = "Smedjebacken")]
        Smedjebacken = 2061,
        [Display(Name = "Mora")]
        Mora = 2062,
        [Display(Name = "Falun")]
        Falun = 2080,
        [Display(Name = "Borlänge")]
        Borlänge = 2081,
        [Display(Name = "Säter")]
        Säter = 2082,
        [Display(Name = "Hedemora")]
        Hedemora = 2083,
        [Display(Name = "Avesta")]
        Avesta = 2084,
        [Display(Name = "Ludvika")]
        Ludvika = 2085,
        // 21 Gävleborgs län
        [Display(Name = "Ockelbo")]
        Ockelbo = 2101,
        [Display(Name = "Hofors")]
        Hofors = 2104,
        [Display(Name = "Ovanåker")]
        Ovanåker = 2121,
        [Display(Name = "Nordanstig")]
        Nordanstig = 2132,
        [Display(Name = "Ljusdal")]
        Ljusdal = 2161,
        [Display(Name = "Gävle")]
        Gävle = 2180,
        [Display(Name = "Sandviken")]
        Sandviken = 2181,
        [Display(Name = "Söderhamn")]
        Söderhamn = 2182,
        [Display(Name = "Bollnäs")]
        Bollnäs = 2183,
        [Display(Name = "Hudiksvall")]
        Hudiksvall = 2184,
        // 22 Västernorrlands län
        [Display(Name = "Ånge")]
        Ånge = 2260,
        [Display(Name = "Timrå")]
        Timrå = 2262,
        [Display(Name = "Härnösand")]
        Härnösand = 2280,
        [Display(Name = "Sundsvall")]
        Sundsvall = 2281,
        [Display(Name = "Kramfors")]
        Kramfors = 2282,
        [Display(Name = "Sollefteå")]
        Sollefteå = 2283,
        [Display(Name = "Örnsköldsvik")]
        Örnsköldsvik = 2284,
        // 23 Jämtlands län
        [Display(Name = "Ragunda")]
        Ragunda = 2303,
        [Display(Name = "Bräcke")]
        Bräcke = 2305,
        [Display(Name = "Krokom")]
        Krokom = 2309,
        [Display(Name = "Strömsund")]
        Strömsund = 2313,
        [Display(Name = "Åre")]
        Åre = 2321,
        [Display(Name = "Berg")]
        Berg = 2326,
        [Display(Name = "Härjedalen")]
        Härjedalen = 2361,
        [Display(Name = "Östersund")]
        Östersund = 2380,
        // 24 Västerbottens län
        [Display(Name = "Nordmaling")]
        Nordmaling = 2401,
        [Display(Name = "Bjurholm")]
        Bjurholm = 2403,
        [Display(Name = "Vindeln")]
        Vindeln = 2404,
        [Display(Name = "Robertsfors")]
        Robertsfors = 2409,
        [Display(Name = "Norsjö")]
        Norsjö = 2417,
        [Display(Name = "Malå")]
        Malå = 2418,
        [Display(Name = "Storuman")]
        Storuman = 2421,
        [Display(Name = "Sorsele")]
        Sorsele = 2422,
        [Display(Name = "Dorotea")]
        Dorotea = 2425,
        [Display(Name = "Vännäs")]
        Vännäs = 2460,
        [Display(Name = "Vilhelmina")]
        Vilhelmina = 2462,
        [Display(Name = "Åsele")]
        Åsele = 2463,
        [Display(Name = "Umeå")]
        Umeå = 2480,
        [Display(Name = "Lycksele")]
        Lycksele = 2481,
        [Display(Name = "Skellefteå")]
        Skellefteå = 2482,
        // 25 Norrbottens län
        [Display(Name = "Arvidsjaur")]
        Arvidsjaur = 2505,
        [Display(Name = "Arjeplog")]
        Arjeplog = 2506,
        [Display(Name = "Jokkmokk")]
        Jokkmokk = 2510,
        [Display(Name = "Överkalix")]
        Överkalix = 2513,
        [Display(Name = "Kalix")]
        Kalix = 2514,
        [Display(Name = "Övertorneå")]
        Övertorneå = 2518,
        [Display(Name = "Pajala")]
        Pajala = 2521,
        [Display(Name = "Gällivare")]
        Gällivare = 2523,
        [Display(Name = "Älvsbyn")]
        Älvsbyn = 2560,
        [Display(Name = "Luleå")]
        Luleå = 2580,
        [Display(Name = "Piteå")]
        Piteå = 2581,
        [Display(Name = "Boden")]
        Boden = 2582,
        [Display(Name = "Haparanda")]
        Haparanda = 2583,
        [Display(Name = "Kiruna")]
        Kiruna = 2584,
    }
}

