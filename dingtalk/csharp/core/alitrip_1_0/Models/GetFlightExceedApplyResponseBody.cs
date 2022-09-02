// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkalitrip_1_0.Models
{
    public class GetFlightExceedApplyResponseBody : TeaModel {
        /// <summary>
        /// 商旅超标审批单id
        /// </summary>
        [NameInMap("applyId")]
        [Validation(Required=false)]
        public long? ApplyId { get; set; }

        /// <summary>
        /// 意向出行信息
        /// </summary>
        [NameInMap("applyIntentionInfoDO")]
        [Validation(Required=false)]
        public GetFlightExceedApplyResponseBodyApplyIntentionInfoDO ApplyIntentionInfoDO { get; set; }
        public class GetFlightExceedApplyResponseBodyApplyIntentionInfoDO : TeaModel {
            /// <summary>
            /// 到达城市三字码
            /// </summary>
            [NameInMap("arrCity")]
            [Validation(Required=false)]
            public string ArrCity { get; set; }

            /// <summary>
            /// 到达城市名称
            /// </summary>
            [NameInMap("arrCityName")]
            [Validation(Required=false)]
            public string ArrCityName { get; set; }

            /// <summary>
            /// 到达时间
            /// </summary>
            [NameInMap("arrTime")]
            [Validation(Required=false)]
            public string ArrTime { get; set; }

            /// <summary>
            /// 超标的舱位，F：头等舱 C：商务舱 Y：经济舱 P：超值经济舱
            /// </summary>
            [NameInMap("cabin")]
            [Validation(Required=false)]
            public string Cabin { get; set; }

            /// <summary>
            /// 申请超标的舱等 0：头等舱 1：商务舱 2：经济舱 3：超值经济舱
            /// </summary>
            [NameInMap("cabinClass")]
            [Validation(Required=false)]
            public int? CabinClass { get; set; }

            /// <summary>
            /// 舱等描述，头等舱，商务舱，经济舱，超值经济舱
            /// </summary>
            [NameInMap("cabinClassStr")]
            [Validation(Required=false)]
            public string CabinClassStr { get; set; }

            /// <summary>
            /// 出发城市三字码
            /// </summary>
            [NameInMap("depCity")]
            [Validation(Required=false)]
            public string DepCity { get; set; }

            /// <summary>
            /// 出发城市名称
            /// </summary>
            [NameInMap("depCityName")]
            [Validation(Required=false)]
            public string DepCityName { get; set; }

            /// <summary>
            /// 出发时间
            /// </summary>
            [NameInMap("depTime")]
            [Validation(Required=false)]
            public string DepTime { get; set; }

            /// <summary>
            /// 折扣
            /// </summary>
            [NameInMap("discount")]
            [Validation(Required=false)]
            public double? Discount { get; set; }

            /// <summary>
            /// 航班号
            /// </summary>
            [NameInMap("flightNo")]
            [Validation(Required=false)]
            public string FlightNo { get; set; }

            /// <summary>
            /// 意向航班价格（元）
            /// </summary>
            [NameInMap("price")]
            [Validation(Required=false)]
            public long? Price { get; set; }

            /// <summary>
            /// 超标类型，1:折扣 2,8,10:时间 3,9,11:折扣和时间
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

        }

        /// <summary>
        /// 出差原因
        /// </summary>
        [NameInMap("btripCause")]
        [Validation(Required=false)]
        public string BtripCause { get; set; }

        /// <summary>
        /// 第三方企业id
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// 超标原因
        /// </summary>
        [NameInMap("exceedReason")]
        [Validation(Required=false)]
        public string ExceedReason { get; set; }

        /// <summary>
        /// 超标类型，1:折扣 2,8,10:时间 3,9,11:折扣和时间
        /// </summary>
        [NameInMap("exceedType")]
        [Validation(Required=false)]
        public int? ExceedType { get; set; }

        /// <summary>
        /// 原差旅标准
        /// </summary>
        [NameInMap("originStandard")]
        [Validation(Required=false)]
        public string OriginStandard { get; set; }

        /// <summary>
        /// 审批单状态 0:审批中 1:已同意 2:已拒绝
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// 审批单提交时间
        /// </summary>
        [NameInMap("submitTime")]
        [Validation(Required=false)]
        public string SubmitTime { get; set; }

        /// <summary>
        /// 第三方出差审批单号
        /// </summary>
        [NameInMap("thirdpartApplyId")]
        [Validation(Required=false)]
        public string ThirdpartApplyId { get; set; }

        /// <summary>
        /// 第三方用户id
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
