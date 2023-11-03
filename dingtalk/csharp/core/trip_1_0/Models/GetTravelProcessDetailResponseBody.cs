// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktrip_1_0.Models
{
    public class GetTravelProcessDetailResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetTravelProcessDetailResponseBodyResult Result { get; set; }
        public class GetTravelProcessDetailResponseBodyResult : TeaModel {
            [NameInMap("businessId")]
            [Validation(Required=false)]
            public string BusinessId { get; set; }

            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("costCenter")]
            [Validation(Required=false)]
            public string CostCenter { get; set; }

            [NameInMap("itineraryProject")]
            [Validation(Required=false)]
            public string ItineraryProject { get; set; }

            [NameInMap("journeys")]
            [Validation(Required=false)]
            public List<GetTravelProcessDetailResponseBodyResultJourneys> Journeys { get; set; }
            public class GetTravelProcessDetailResponseBodyResultJourneys : TeaModel {
                [NameInMap("arrival")]
                [Validation(Required=false)]
                public GetTravelProcessDetailResponseBodyResultJourneysArrival Arrival { get; set; }
                public class GetTravelProcessDetailResponseBodyResultJourneysArrival : TeaModel {
                    [NameInMap("code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("nationalCityCode")]
                    [Validation(Required=false)]
                    public string NationalCityCode { get; set; }

                }

                [NameInMap("departure")]
                [Validation(Required=false)]
                public GetTravelProcessDetailResponseBodyResultJourneysDeparture Departure { get; set; }
                public class GetTravelProcessDetailResponseBodyResultJourneysDeparture : TeaModel {
                    [NameInMap("code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("nationalCityCode")]
                    [Validation(Required=false)]
                    public string NationalCityCode { get; set; }

                }

                [NameInMap("endTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                [NameInMap("journeyBizNo")]
                [Validation(Required=false)]
                public string JourneyBizNo { get; set; }

                [NameInMap("startTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("travelType")]
                [Validation(Required=false)]
                public string TravelType { get; set; }

                [NameInMap("tripWay")]
                [Validation(Required=false)]
                public string TripWay { get; set; }

            }

            [NameInMap("mainProcessInstanceId")]
            [Validation(Required=false)]
            public string MainProcessInstanceId { get; set; }

            [NameInMap("memo")]
            [Validation(Required=false)]
            public string Memo { get; set; }

            [NameInMap("originatorId")]
            [Validation(Required=false)]
            public string OriginatorId { get; set; }

            [NameInMap("processInstanceId")]
            [Validation(Required=false)]
            public string ProcessInstanceId { get; set; }

            [NameInMap("processResult")]
            [Validation(Required=false)]
            public string ProcessResult { get; set; }

            [NameInMap("processStatus")]
            [Validation(Required=false)]
            public string ProcessStatus { get; set; }

            [NameInMap("remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            [NameInMap("travelCategory")]
            [Validation(Required=false)]
            public string TravelCategory { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
