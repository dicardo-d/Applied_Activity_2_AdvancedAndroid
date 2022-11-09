using System;
using static Android.Graphics.ImageDecoder;

namespace Applied_Activity_2.Model
{
	public class Holiday
	{
        public string Id { get; set; }

        public string NameEn { get; set; }

        public string NameFr { get; set; }

        public string Date { get; set; }

        public List<Provice> Provinces { get; set; }

        public Holiday(string id, string nameEn, string nameFr, string date, List<Provice> provinces)
        {
            Id = id;
            NameEn = nameEn;
            NameFr = nameFr;
            Date = date;
            Provinces = provinces;
        }
    }

    public class Provice
    {
        public string Id { get; set; }

        public string NameEn { get; set; }

        public string NameFr { get; set; }

        public string SourceEn { get; set; }

        public Provice(string id, string nameEn, string nameFr, string sourceEn)
        {
            Id = id;
            NameEn = nameEn;
            NameFr = nameFr;
            SourceEn = sourceEn;
        }

    }

    public class APIResponse
    {
        public List<Holiday> Holidays { get; set; }
        public APIResponse(List<Holiday> holidays)
        {
            Holidays = holidays;
        }
    }
}



//holidays ": [
//    {
//    "id": 1,
//      "date": "2020-01-01",
//      "nameEn": "New Year’s Day",
//      "nameFr": "Jour de l’An",
//      "federal": 1,
//      "observedDate": "2020-01-01",
//      "provinces": [
//        {
//        "id": "AB",
//          "nameEn": "Alberta",
//          "nameFr": "Alberta",
//          "sourceLink": "https://www.alberta.ca/alberta-general-holidays.aspx#jumplinks-1",
//          "sourceEn": "General holidays in Alberta"
//        },