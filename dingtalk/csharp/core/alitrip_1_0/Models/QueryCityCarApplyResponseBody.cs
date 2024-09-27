// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkalitrip_1_0.Models
{
    public class QueryCityCarApplyResponseBody : TeaModel {
        [NameInMap("applyList")]
        [Validation(Required=false)]
        public List<QueryCityCarApplyResponseBodyApplyList> ApplyList { get; set; }
        public class QueryCityCarApplyResponseBodyApplyList : TeaModel {
            [NameInMap("approverList")]
            [Validation(Required=false)]
            public List<QueryCityCarApplyResponseBodyApplyListApproverList> ApproverList { get; set; }
            public class QueryCityCarApplyResponseBodyApplyListApproverList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>同意</para>
                /// </summary>
                [NameInMap("note")]
                [Validation(Required=false)]
                public string Note { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2021-03-18 20:26:56</para>
                /// </summary>
                [NameInMap("operateTime")]
                [Validation(Required=false)]
                public string OperateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("order")]
                [Validation(Required=false)]
                public long? Order { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public long? Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>同意</para>
                /// </summary>
                [NameInMap("statusDesc")]
                [Validation(Required=false)]
                public string StatusDesc { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>user1</para>
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>员工1</para>
                /// </summary>
                [NameInMap("userName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("departId")]
            [Validation(Required=false)]
            public string DepartId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>部门1</para>
            /// </summary>
            [NameInMap("departName")]
            [Validation(Required=false)]
            public string DepartName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-03-18 20:26:56</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-03-18 20:26:56</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("itineraryList")]
            [Validation(Required=false)]
            public List<QueryCityCarApplyResponseBodyApplyListItineraryList> ItineraryList { get; set; }
            public class QueryCityCarApplyResponseBodyApplyListItineraryList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>杭州</para>
                /// </summary>
                [NameInMap("arrCity")]
                [Validation(Required=false)]
                public string ArrCity { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>HGH</para>
                /// </summary>
                [NameInMap("arrCityCode")]
                [Validation(Required=false)]
                public string ArrCityCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2021-03-18 20:26:56</para>
                /// </summary>
                [NameInMap("arrDate")]
                [Validation(Required=false)]
                public string ArrDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("costCenterId")]
                [Validation(Required=false)]
                public long? CostCenterId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>成本中心1</para>
                /// </summary>
                [NameInMap("costCenterName")]
                [Validation(Required=false)]
                public string CostCenterName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>杭州</para>
                /// </summary>
                [NameInMap("depCity")]
                [Validation(Required=false)]
                public string DepCity { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>HGH</para>
                /// </summary>
                [NameInMap("depCityCode")]
                [Validation(Required=false)]
                public string DepCityCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2021-03-18 20:26:56</para>
                /// </summary>
                [NameInMap("depDate")]
                [Validation(Required=false)]
                public string DepDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("invoiceId")]
                [Validation(Required=false)]
                public long? InvoiceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>发票抬头1</para>
                /// </summary>
                [NameInMap("invoiceName")]
                [Validation(Required=false)]
                public string InvoiceName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("itineraryId")]
                [Validation(Required=false)]
                public string ItineraryId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>projectx</para>
                /// </summary>
                [NameInMap("projectCode")]
                [Validation(Required=false)]
                public string ProjectCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>项目x</para>
                /// </summary>
                [NameInMap("projectTitle")]
                [Validation(Required=false)]
                public string ProjectTitle { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("trafficType")]
                [Validation(Required=false)]
                public long? TrafficType { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>申请</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("statusDesc")]
            [Validation(Required=false)]
            public string StatusDesc { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>apply1</para>
            /// </summary>
            [NameInMap("thirdPartApplyId")]
            [Validation(Required=false)]
            public string ThirdPartApplyId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>杭州出差</para>
            /// </summary>
            [NameInMap("tripCause")]
            [Validation(Required=false)]
            public string TripCause { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>杭州出差</para>
            /// </summary>
            [NameInMap("tripTitle")]
            [Validation(Required=false)]
            public string TripTitle { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>user1</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>员工1</para>
            /// </summary>
            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
