// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcard_1_0.Models
{
    public class UpdateCardWithDelegateRequest : TeaModel {
        [NameInMap("cardData")]
        [Validation(Required=false)]
        public UpdateCardWithDelegateRequestCardData CardData { get; set; }
        public class UpdateCardWithDelegateRequestCardData : TeaModel {
            [NameInMap("cardParamMap")]
            [Validation(Required=false)]
            public Dictionary<string, string> CardParamMap { get; set; }

        }

        [NameInMap("cardUpdateOptions")]
        [Validation(Required=false)]
        public UpdateCardWithDelegateRequestCardUpdateOptions CardUpdateOptions { get; set; }
        public class UpdateCardWithDelegateRequestCardUpdateOptions : TeaModel {
            [NameInMap("updateCardDataByKey")]
            [Validation(Required=false)]
            public bool? UpdateCardDataByKey { get; set; }

            [NameInMap("updatePrivateDataByKey")]
            [Validation(Required=false)]
            public bool? UpdatePrivateDataByKey { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("outTrackId")]
        [Validation(Required=false)]
        public string OutTrackId { get; set; }

        [NameInMap("privateData")]
        [Validation(Required=false)]
        public Dictionary<string, PrivateDataValue> PrivateData { get; set; }

        [NameInMap("userIdType")]
        [Validation(Required=false)]
        public int? UserIdType { get; set; }

    }

}
