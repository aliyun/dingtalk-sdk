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
            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-07-18 00:00:00</para>
            /// </summary>
            [NameInMap("archiveTime")]
            [Validation(Required=false)]
            public string ArchiveTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>alitrip.business</para>
            /// </summary>
            [NameInMap("bizCategoryId")]
            [Validation(Required=false)]
            public string BizCategoryId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>202310231720000276784</para>
            /// </summary>
            [NameInMap("businessId")]
            [Validation(Required=false)]
            public string BusinessId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ding123456xxxx</para>
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>it成本中心</para>
            /// </summary>
            [NameInMap("costCenter")]
            [Validation(Required=false)]
            public string CostCenter { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>成本中心id</para>
            /// </summary>
            [NameInMap("costCenterId")]
            [Validation(Required=false)]
            public string CostCenterId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>c00001</para>
            /// </summary>
            [NameInMap("costCenterThirdPartyId")]
            [Validation(Required=false)]
            public string CostCenterThirdPartyId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-03-18 17:07:00</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("extFormComponent")]
            [Validation(Required=false)]
            public List<GetTravelProcessDetailResponseBodyResultExtFormComponent> ExtFormComponent { get; set; }
            public class GetTravelProcessDetailResponseBodyResultExtFormComponent : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>&quot;&quot;</para>
                /// </summary>
                [NameInMap("bizAlias")]
                [Validation(Required=false)]
                public string BizAlias { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>MoneyField</para>
                /// </summary>
                [NameInMap("componentType")]
                [Validation(Required=false)]
                public string ComponentType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>&quot;{&quot;upper&quot;:&quot;玖元玖角玖分&quot;,&quot;componentName&quot;:&quot;MoneyField&quot;}&quot;</para>
                /// </summary>
                [NameInMap("extValue")]
                [Validation(Required=false)]
                public string ExtValue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>MoneyField_18PDM5K773FK0</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>预估金额</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>9.99</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>部门费用</para>
            /// </summary>
            [NameInMap("feeType")]
            [Validation(Required=false)]
            public string FeeType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>发票抬头</para>
            /// </summary>
            [NameInMap("invoiceTitle")]
            [Validation(Required=false)]
            public string InvoiceTitle { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>发票抬头id</para>
            /// </summary>
            [NameInMap("invoiceTitleId")]
            [Validation(Required=false)]
            public string InvoiceTitleId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>i0001</para>
            /// </summary>
            [NameInMap("invoiceTitleThirdPartyId")]
            [Validation(Required=false)]
            public string InvoiceTitleThirdPartyId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>电商对接项目</para>
            /// </summary>
            [NameInMap("itineraryProject")]
            [Validation(Required=false)]
            public string ItineraryProject { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>y00001</para>
            /// </summary>
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
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>TSN</para>
                    /// </summary>
                    [NameInMap("code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>CN</para>
                    /// </summary>
                    [NameInMap("countryCode")]
                    [Validation(Required=false)]
                    public string CountryCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>中国</para>
                    /// </summary>
                    [NameInMap("countryName")]
                    [Validation(Required=false)]
                    public string CountryName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>天津市</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>120000</para>
                    /// </summary>
                    [NameInMap("nationalCityCode")]
                    [Validation(Required=false)]
                    public string NationalCityCode { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>成本中心一</para>
                /// </summary>
                [NameInMap("costCenter")]
                [Validation(Required=false)]
                public string CostCenter { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("costCenterId")]
                [Validation(Required=false)]
                public string CostCenterId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>c00001</para>
                /// </summary>
                [NameInMap("costCenterThirdPartyId")]
                [Validation(Required=false)]
                public string CostCenterThirdPartyId { get; set; }

                [NameInMap("departure")]
                [Validation(Required=false)]
                public GetTravelProcessDetailResponseBodyResultJourneysDeparture Departure { get; set; }
                public class GetTravelProcessDetailResponseBodyResultJourneysDeparture : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>BJK</para>
                    /// </summary>
                    [NameInMap("code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>CN</para>
                    /// </summary>
                    [NameInMap("countryCode")]
                    [Validation(Required=false)]
                    public string CountryCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>中国</para>
                    /// </summary>
                    [NameInMap("countryName")]
                    [Validation(Required=false)]
                    public string CountryName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>北京市</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>110000</para>
                    /// </summary>
                    [NameInMap("nationalCityCode")]
                    [Validation(Required=false)]
                    public string NationalCityCode { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-10-25</para>
                /// </summary>
                [NameInMap("endTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-03-12 10:54:00</para>
                /// </summary>
                [NameInMap("endTimeAcc")]
                [Validation(Required=false)]
                public string EndTimeAcc { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>发票抬头一</para>
                /// </summary>
                [NameInMap("invoiceTitle")]
                [Validation(Required=false)]
                public string InvoiceTitle { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("invoiceTitleId")]
                [Validation(Required=false)]
                public string InvoiceTitleId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>i0001</para>
                /// </summary>
                [NameInMap("invoiceTitleThirdPartyId")]
                [Validation(Required=false)]
                public string InvoiceTitleThirdPartyId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>费用归属项目一</para>
                /// </summary>
                [NameInMap("itineraryProject")]
                [Validation(Required=false)]
                public string ItineraryProject { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("itineraryProjectId")]
                [Validation(Required=false)]
                public string ItineraryProjectId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>y00001</para>
                /// </summary>
                [NameInMap("itineraryProjectThirdPartyId")]
                [Validation(Required=false)]
                public string ItineraryProjectThirdPartyId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123455xxxxxxxx</para>
                /// </summary>
                [NameInMap("journeyBizNo")]
                [Validation(Required=false)]
                public string JourneyBizNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-10-20</para>
                /// </summary>
                [NameInMap("startTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-03-12 10:54:00</para>
                /// </summary>
                [NameInMap("startTimeAcc")]
                [Validation(Required=false)]
                public string StartTimeAcc { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>天</para>
                /// </summary>
                [NameInMap("timeUnit")]
                [Validation(Required=false)]
                public string TimeUnit { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>飞机</para>
                /// </summary>
                [NameInMap("travelType")]
                [Validation(Required=false)]
                public string TravelType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>单程</para>
                /// </summary>
                [NameInMap("tripWay")]
                [Validation(Required=false)]
                public string TripWay { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>AG3WERxWRFex63xxxxx</para>
            /// </summary>
            [NameInMap("mainProcessInstanceId")]
            [Validation(Required=false)]
            public string MainProcessInstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>坐飞机出差</para>
            /// </summary>
            [NameInMap("memo")]
            [Validation(Required=false)]
            public string Memo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>staffidxxxxx</para>
            /// </summary>
            [NameInMap("originatorId")]
            [Validation(Required=false)]
            public string OriginatorId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>staffIdxyy</para>
            /// </summary>
            [NameInMap("originatorIdOnBehalf")]
            [Validation(Required=false)]
            public string OriginatorIdOnBehalf { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>AG3U12xWRFex63hxxxxx</para>
            /// </summary>
            [NameInMap("processInstanceId")]
            [Validation(Required=false)]
            public string ProcessInstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>agree</para>
            /// </summary>
            [NameInMap("processResult")]
            [Validation(Required=false)]
            public string ProcessResult { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>COMPLETED</para>
            /// </summary>
            [NameInMap("processStatus")]
            [Validation(Required=false)]
            public string ProcessStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>因公出差</para>
            /// </summary>
            [NameInMap("remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            [NameInMap("tasks")]
            [Validation(Required=false)]
            public List<GetTravelProcessDetailResponseBodyResultTasks> Tasks { get; set; }
            public class GetTravelProcessDetailResponseBodyResultTasks : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1918_5cd3</para>
                /// </summary>
                [NameInMap("activityId")]
                [Validation(Required=false)]
                public string ActivityId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-07-01 00:00:00</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-07-01 01:00:00</para>
                /// </summary>
                [NameInMap("finishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12374</para>
                /// </summary>
                [NameInMap("originUserId")]
                [Validation(Required=false)]
                public string OriginUserId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>e7fh112WTTawy6dLtiIlqQ10051721014983</para>
                /// </summary>
                [NameInMap("processInstanceId")]
                [Validation(Required=false)]
                public string ProcessInstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>AGREE</para>
                /// </summary>
                [NameInMap("result")]
                [Validation(Required=false)]
                public string Result { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>COMPLETED</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>87882310449</para>
                /// </summary>
                [NameInMap("taskId")]
                [Validation(Required=false)]
                public long? TaskId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>aflow.dingtalk.com?procInsId=xxx&amp;taskId=yyy&amp;businessId=zzz</para>
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2220314</para>
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>费用归属部门</para>
            /// </summary>
            [NameInMap("travelCategory")]
            [Validation(Required=false)]
            public string TravelCategory { get; set; }

            [NameInMap("travelers")]
            [Validation(Required=false)]
            public List<string> Travelers { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("tripDays")]
            [Validation(Required=false)]
            public string TripDays { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
