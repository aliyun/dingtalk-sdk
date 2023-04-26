// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkalitrip_1_0.Models
{
    public class GetFlightExceedApplyResponseBody : TeaModel {
        [NameInMap("applyId")]
        [Validation(Required=false)]
        public long? ApplyId { get; set; }

        [NameInMap("applyIntentionInfoDO")]
        [Validation(Required=false)]
        public GetFlightExceedApplyResponseBodyApplyIntentionInfoDO ApplyIntentionInfoDO { get; set; }
        public class GetFlightExceedApplyResponseBodyApplyIntentionInfoDO : TeaModel {
            [NameInMap("arrCity")]
            [Validation(Required=false)]
            public string ArrCity { get; set; }

            [NameInMap("arrCityName")]
            [Validation(Required=false)]
            public string ArrCityName { get; set; }

            [NameInMap("arrTime")]
            [Validation(Required=false)]
            public string ArrTime { get; set; }

            [NameInMap("cabin")]
            [Validation(Required=false)]
            public string Cabin { get; set; }

            [NameInMap("cabinClass")]
            [Validation(Required=false)]
            public int? CabinClass { get; set; }

            [NameInMap("cabinClassStr")]
            [Validation(Required=false)]
            public string CabinClassStr { get; set; }

            [NameInMap("depCity")]
            [Validation(Required=false)]
            public string DepCity { get; set; }

            [NameInMap("depCityName")]
            [Validation(Required=false)]
            public string DepCityName { get; set; }

            [NameInMap("depTime")]
            [Validation(Required=false)]
            public string DepTime { get; set; }

            [NameInMap("discount")]
            [Validation(Required=false)]
            public double? Discount { get; set; }

            [NameInMap("flightNo")]
            [Validation(Required=false)]
            public string FlightNo { get; set; }

            [NameInMap("price")]
            [Validation(Required=false)]
            public long? Price { get; set; }

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
