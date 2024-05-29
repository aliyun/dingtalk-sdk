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
            [NameInMap("bizCategoryId")]
            [Validation(Required=false)]
            public string BizCategoryId { get; set; }

            [NameInMap("businessId")]
            [Validation(Required=false)]
            public string BusinessId { get; set; }

            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("costCenter")]
            [Validation(Required=false)]
            public string CostCenter { get; set; }

            [NameInMap("costCenterId")]
            [Validation(Required=false)]
            public string CostCenterId { get; set; }

            [NameInMap("costCenterThirdPartyId")]
            [Validation(Required=false)]
            public string CostCenterThirdPartyId { get; set; }

            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("extFormComponent")]
            [Validation(Required=false)]
            public List<GetTravelProcessDetailResponseBodyResultExtFormComponent> ExtFormComponent { get; set; }
            public class GetTravelProcessDetailResponseBodyResultExtFormComponent : TeaModel {
                [NameInMap("bizAlias")]
                [Validation(Required=false)]
                public string BizAlias { get; set; }

                [NameInMap("componentType")]
                [Validation(Required=false)]
                public string ComponentType { get; set; }

                [NameInMap("extValue")]
                [Validation(Required=false)]
                public string ExtValue { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("feeType")]
            [Validation(Required=false)]
            public string FeeType { get; set; }

            [NameInMap("invoiceTitle")]
            [Validation(Required=false)]
            public string InvoiceTitle { get; set; }

            [NameInMap("invoiceTitleId")]
            [Validation(Required=false)]
            public string InvoiceTitleId { get; set; }

            [NameInMap("invoiceTitleThirdPartyId")]
            [Validation(Required=false)]
            public string InvoiceTitleThirdPartyId { get; set; }

            [NameInMap("itineraryProject")]
            [Validation(Required=false)]
            public string ItineraryProject { get; set; }

            [NameInMap("itineraryProjectThirdPartyId")]
            [Validation(Required=false)]
            public string ItineraryProjectThirdPartyId { get; set; }

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

                    [NameInMap("countryCode")]
                    [Validation(Required=false)]
                    public string CountryCode { get; set; }

                    [NameInMap("countryName")]
                    [Validation(Required=false)]
                    public string CountryName { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("nationalCityCode")]
                    [Validation(Required=false)]
                    public string NationalCityCode { get; set; }

                }

                [NameInMap("costCenter")]
                [Validation(Required=false)]
                public string CostCenter { get; set; }

                [NameInMap("costCenterId")]
                [Validation(Required=false)]
                public string CostCenterId { get; set; }

                [NameInMap("costCenterThirdPartyId")]
                [Validation(Required=false)]
                public string CostCenterThirdPartyId { get; set; }

                [NameInMap("departure")]
                [Validation(Required=false)]
                public GetTravelProcessDetailResponseBodyResultJourneysDeparture Departure { get; set; }
                public class GetTravelProcessDetailResponseBodyResultJourneysDeparture : TeaModel {
                    [NameInMap("code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    [NameInMap("countryCode")]
                    [Validation(Required=false)]
                    public string CountryCode { get; set; }

                    [NameInMap("countryName")]
                    [Validation(Required=false)]
                    public string CountryName { get; set; }

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

                [NameInMap("endTimeAcc")]
                [Validation(Required=false)]
                public string EndTimeAcc { get; set; }

                [NameInMap("invoiceTitle")]
                [Validation(Required=false)]
                public string InvoiceTitle { get; set; }

                [NameInMap("invoiceTitleId")]
                [Validation(Required=false)]
                public string InvoiceTitleId { get; set; }

                [NameInMap("invoiceTitleThirdPartyId")]
                [Validation(Required=false)]
                public string InvoiceTitleThirdPartyId { get; set; }

                [NameInMap("itineraryProject")]
                [Validation(Required=false)]
                public string ItineraryProject { get; set; }

                [NameInMap("itineraryProjectId")]
                [Validation(Required=false)]
                public string ItineraryProjectId { get; set; }

                [NameInMap("itineraryProjectThirdPartyId")]
                [Validation(Required=false)]
                public string ItineraryProjectThirdPartyId { get; set; }

                [NameInMap("journeyBizNo")]
                [Validation(Required=false)]
                public string JourneyBizNo { get; set; }

                [NameInMap("startTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("startTimeAcc")]
                [Validation(Required=false)]
                public string StartTimeAcc { get; set; }

                [NameInMap("timeUnit")]
                [Validation(Required=false)]
                public string TimeUnit { get; set; }

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

            [NameInMap("originatorIdOnBehalf")]
            [Validation(Required=false)]
            public string OriginatorIdOnBehalf { get; set; }

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

            [NameInMap("travelers")]
            [Validation(Required=false)]
            public List<string> Travelers { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
