// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkalitrip_1_0.Models
{
    public class GetHotelExceedApplyResponseBody : TeaModel {
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
        public GetHotelExceedApplyResponseBodyApplyIntentionInfoDO ApplyIntentionInfoDO { get; set; }
        public class GetHotelExceedApplyResponseBodyApplyIntentionInfoDO : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("checkIn")]
            [Validation(Required=false)]
            public string CheckIn { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("checkOut")]
            [Validation(Required=false)]
            public string CheckOut { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("cityCode")]
            [Validation(Required=false)]
            public string CityCode { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("cityName")]
            [Validation(Required=false)]
            public string CityName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("price")]
            [Validation(Required=false)]
            public long? Price { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("together")]
            [Validation(Required=false)]
            public bool? Together { get; set; }

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
