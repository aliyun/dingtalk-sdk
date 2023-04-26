// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkalitrip_1_0.Models
{
    public class GetHotelExceedApplyResponseBody : TeaModel {
        [NameInMap("applyId")]
        [Validation(Required=false)]
        public long? ApplyId { get; set; }

        [NameInMap("applyIntentionInfoDO")]
        [Validation(Required=false)]
        public GetHotelExceedApplyResponseBodyApplyIntentionInfoDO ApplyIntentionInfoDO { get; set; }
        public class GetHotelExceedApplyResponseBodyApplyIntentionInfoDO : TeaModel {
            [NameInMap("checkIn")]
            [Validation(Required=false)]
            public string CheckIn { get; set; }

            [NameInMap("checkOut")]
            [Validation(Required=false)]
            public string CheckOut { get; set; }

            [NameInMap("cityCode")]
            [Validation(Required=false)]
            public string CityCode { get; set; }

            [NameInMap("cityName")]
            [Validation(Required=false)]
            public string CityName { get; set; }

            [NameInMap("price")]
            [Validation(Required=false)]
            public long? Price { get; set; }

            [NameInMap("together")]
            [Validation(Required=false)]
            public bool? Together { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

        }

        [NameInMap("btripCause")]
        [Validation(Required=false)]
        public string BtripCause { get; set; }

        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("exceedReason")]
        [Validation(Required=false)]
        public string ExceedReason { get; set; }

        [NameInMap("exceedType")]
        [Validation(Required=false)]
        public int? ExceedType { get; set; }

        [NameInMap("originStandard")]
        [Validation(Required=false)]
        public string OriginStandard { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("submitTime")]
        [Validation(Required=false)]
        public string SubmitTime { get; set; }

        [NameInMap("thirdpartApplyId")]
        [Validation(Required=false)]
        public string ThirdpartApplyId { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
