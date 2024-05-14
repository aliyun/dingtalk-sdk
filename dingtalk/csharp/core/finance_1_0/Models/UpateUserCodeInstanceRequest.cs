// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0.Models
{
    public class UpateUserCodeInstanceRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("availableTimes")]
        [Validation(Required=false)]
        public List<UpateUserCodeInstanceRequestAvailableTimes> AvailableTimes { get; set; }
        public class UpateUserCodeInstanceRequestAvailableTimes : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("gmtEnd")]
            [Validation(Required=false)]
            public string GmtEnd { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("gmtStart")]
            [Validation(Required=false)]
            public string GmtStart { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("codeId")]
        [Validation(Required=false)]
        public string CodeId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("codeIdentity")]
        [Validation(Required=false)]
        public string CodeIdentity { get; set; }

        [NameInMap("codeValue")]
        [Validation(Required=false)]
        public string CodeValue { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("extInfo")]
        [Validation(Required=false)]
        public Dictionary<string, object> ExtInfo { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("gmtExpired")]
        [Validation(Required=false)]
        public string GmtExpired { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("userCorpRelationType")]
        [Validation(Required=false)]
        public string UserCorpRelationType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("userIdentity")]
        [Validation(Required=false)]
        public string UserIdentity { get; set; }

    }

}
