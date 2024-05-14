// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkalitrip_1_0.Models
{
    public class GetFlightExceedApplyResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("applyId")]
        [Validation(Required=false)]
        public long? ApplyId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("applyIntentionInfoDO")]
        [Validation(Required=false)]
        public GetFlightExceedApplyResponseBodyApplyIntentionInfoDO ApplyIntentionInfoDO { get; set; }
        public class GetFlightExceedApplyResponseBodyApplyIntentionInfoDO : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("arrCity")]
            [Validation(Required=false)]
            public string ArrCity { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("arrCityName")]
            [Validation(Required=false)]
            public string ArrCityName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("arrTime")]
            [Validation(Required=false)]
            public string ArrTime { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("cabin")]
            [Validation(Required=false)]
            public string Cabin { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("cabinClass")]
            [Validation(Required=false)]
            public int? CabinClass { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("cabinClassStr")]
            [Validation(Required=false)]
            public string CabinClassStr { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("depCity")]
            [Validation(Required=false)]
            public string DepCity { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("depCityName")]
            [Validation(Required=false)]
            public string DepCityName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("depTime")]
            [Validation(Required=false)]
            public string DepTime { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("discount")]
            [Validation(Required=false)]
            public double? Discount { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("flightNo")]
            [Validation(Required=false)]
            public string FlightNo { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("price")]
            [Validation(Required=false)]
            public long? Price { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("btripCause")]
        [Validation(Required=false)]
        public string BtripCause { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("exceedReason")]
        [Validation(Required=false)]
        public string ExceedReason { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("exceedType")]
        [Validation(Required=false)]
        public int? ExceedType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("originStandard")]
        [Validation(Required=false)]
        public string OriginStandard { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("submitTime")]
        [Validation(Required=false)]
        public string SubmitTime { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("thirdpartApplyId")]
        [Validation(Required=false)]
        public string ThirdpartApplyId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
