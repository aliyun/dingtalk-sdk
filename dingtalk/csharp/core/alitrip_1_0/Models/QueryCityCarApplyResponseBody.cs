// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkalitrip_1_0.Models
{
    public class QueryCityCarApplyResponseBody : TeaModel {
        /// <summary>
        /// 审批单列表
        /// </summary>
        [NameInMap("applyList")]
        [Validation(Required=false)]
        public List<QueryCityCarApplyResponseBodyApplyList> ApplyList { get; set; }
        public class QueryCityCarApplyResponseBodyApplyList : TeaModel {
            /// <summary>
            /// 审批单列表
            /// </summary>
            [NameInMap("approverList")]
            [Validation(Required=false)]
            public List<QueryCityCarApplyResponseBodyApplyListApproverList> ApproverList { get; set; }
            public class QueryCityCarApplyResponseBodyApplyListApproverList : TeaModel {
                /// <summary>
                /// 审批备注
                /// </summary>
                [NameInMap("note")]
                [Validation(Required=false)]
                public string Note { get; set; }

                /// <summary>
                /// 审批时间
                /// </summary>
                [NameInMap("operateTime")]
                [Validation(Required=false)]
                public string OperateTime { get; set; }

                /// <summary>
                /// 审批人排序值
                /// </summary>
                [NameInMap("order")]
                [Validation(Required=false)]
                public long? Order { get; set; }

                /// <summary>
                /// 审批状态枚举：审批状态：0-审批中，1-已同意，2-已拒绝
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public long? Status { get; set; }

                /// <summary>
                /// 审批状态描述
                /// </summary>
                [NameInMap("statusDesc")]
                [Validation(Required=false)]
                public string StatusDesc { get; set; }

                /// <summary>
                /// 审批员工ID
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// 审批员工名
                /// </summary>
                [NameInMap("userName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

            /// <summary>
            /// 员工所在部门ID
            /// </summary>
            [NameInMap("departId")]
            [Validation(Required=false)]
            public string DepartId { get; set; }

            /// <summary>
            /// 员工所在部门名
            /// </summary>
            [NameInMap("departName")]
            [Validation(Required=false)]
            public string DepartName { get; set; }

            /// <summary>
            /// 创建时间
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// 最近修改时间
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// 审批单关联的行程
            /// </summary>
            [NameInMap("itineraryList")]
            [Validation(Required=false)]
            public List<QueryCityCarApplyResponseBodyApplyListItineraryList> ItineraryList { get; set; }
            public class QueryCityCarApplyResponseBodyApplyListItineraryList : TeaModel {
                /// <summary>
                /// 目的地城市
                /// </summary>
                [NameInMap("arrCity")]
                [Validation(Required=false)]
                public string ArrCity { get; set; }

                /// <summary>
                /// 目的地城市三字码
                /// </summary>
                [NameInMap("arrCityCode")]
                [Validation(Required=false)]
                public string ArrCityCode { get; set; }

                /// <summary>
                /// 到达目的地城市时间
                /// </summary>
                [NameInMap("arrDate")]
                [Validation(Required=false)]
                public string ArrDate { get; set; }

                /// <summary>
                /// 商旅内部成本中心ID
                /// </summary>
                [NameInMap("costCenterId")]
                [Validation(Required=false)]
                public long? CostCenterId { get; set; }

                /// <summary>
                /// 成本中心名称
                /// </summary>
                [NameInMap("costCenterName")]
                [Validation(Required=false)]
                public string CostCenterName { get; set; }

                /// <summary>
                /// 出发城市
                /// </summary>
                [NameInMap("depCity")]
                [Validation(Required=false)]
                public string DepCity { get; set; }

                /// <summary>
                /// 出发城市三字码
                /// </summary>
                [NameInMap("depCityCode")]
                [Validation(Required=false)]
                public string DepCityCode { get; set; }

                /// <summary>
                /// 出发时间
                /// </summary>
                [NameInMap("depDate")]
                [Validation(Required=false)]
                public string DepDate { get; set; }

                /// <summary>
                /// 商旅内部发票抬头ID
                /// </summary>
                [NameInMap("invoiceId")]
                [Validation(Required=false)]
                public long? InvoiceId { get; set; }

                /// <summary>
                /// 发票抬头名称
                /// </summary>
                [NameInMap("invoiceName")]
                [Validation(Required=false)]
                public string InvoiceName { get; set; }

                /// <summary>
                /// 商旅内部行程单ID
                /// </summary>
                [NameInMap("itineraryId")]
                [Validation(Required=false)]
                public string ItineraryId { get; set; }

                /// <summary>
                /// 项目code
                /// </summary>
                [NameInMap("projectCode")]
                [Validation(Required=false)]
                public string ProjectCode { get; set; }

                /// <summary>
                /// 项目名称
                /// </summary>
                [NameInMap("projectTitle")]
                [Validation(Required=false)]
                public string ProjectTitle { get; set; }

                /// <summary>
                /// 交通方式：4-市内交通
                /// </summary>
                [NameInMap("trafficType")]
                [Validation(Required=false)]
                public long? TrafficType { get; set; }

            }

            /// <summary>
            /// 审批单状态：0-申请，1-同意，2-拒绝
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

            /// <summary>
            /// 审批单状态：0-申请，1-同意，2-拒绝
            /// </summary>
            [NameInMap("statusDesc")]
            [Validation(Required=false)]
            public string StatusDesc { get; set; }

            /// <summary>
            /// 三方审批单ID
            /// </summary>
            [NameInMap("thirdPartApplyId")]
            [Validation(Required=false)]
            public string ThirdPartApplyId { get; set; }

            /// <summary>
            /// 申请事由
            /// </summary>
            [NameInMap("tripCause")]
            [Validation(Required=false)]
            public string TripCause { get; set; }

            /// <summary>
            /// 审批单标题
            /// </summary>
            [NameInMap("tripTitle")]
            [Validation(Required=false)]
            public string TripTitle { get; set; }

            /// <summary>
            /// 发起审批员工ID
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// 发起审批员工名
            /// </summary>
            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// 总数
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
