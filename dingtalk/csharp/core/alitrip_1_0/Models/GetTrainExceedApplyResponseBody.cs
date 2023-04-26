// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkalitrip_1_0.Models
{
    public class GetTrainExceedApplyResponseBody : TeaModel {
        [NameInMap("applyId")]
        [Validation(Required=false)]
        public long? ApplyId { get; set; }

        [NameInMap("applyIntentionInfoDO")]
        [Validation(Required=false)]
        public GetTrainExceedApplyResponseBodyApplyIntentionInfoDO ApplyIntentionInfoDO { get; set; }
        public class GetTrainExceedApplyResponseBodyApplyIntentionInfoDO : TeaModel {
            [NameInMap("arrCity")]
            [Validation(Required=false)]
            public string ArrCity { get; set; }

            [NameInMap("arrCityName")]
            [Validation(Required=false)]
            public string ArrCityName { get; set; }

            [NameInMap("arrStation")]
            [Validation(Required=false)]
            public string ArrStation { get; set; }

            [NameInMap("arrTime")]
            [Validation(Required=false)]
            public string ArrTime { get; set; }

            [NameInMap("depCity")]
            [Validation(Required=false)]
            public string DepCity { get; set; }

            [NameInMap("depCityName")]
            [Validation(Required=false)]
            public string DepCityName { get; set; }

            [NameInMap("depStation")]
            [Validation(Required=false)]
            public string DepStation { get; set; }

            [NameInMap("depTime")]
            [Validation(Required=false)]
            public string DepTime { get; set; }

            [NameInMap("price")]
            [Validation(Required=false)]
            public long? Price { get; set; }

            [NameInMap("seatName")]
            [Validation(Required=false)]
            public string SeatName { get; set; }

            [NameInMap("trainNo")]
            [Validation(Required=false)]
            public string TrainNo { get; set; }

            [NameInMap("trainTypeDesc")]
            [Validation(Required=false)]
            public string TrainTypeDesc { get; set; }

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
