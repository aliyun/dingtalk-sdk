// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktrip_1_0.Models
{
    public class SyncSecretKeyRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("actionType")]
        [Validation(Required=false)]
        public string ActionType { get; set; }

        [NameInMap("secretString")]
        [Validation(Required=false)]
        public string SecretString { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("targetCorpId")]
        [Validation(Required=false)]
        public string TargetCorpId { get; set; }

        [NameInMap("tripAppKey")]
        [Validation(Required=false)]
        public string TripAppKey { get; set; }

        [NameInMap("tripAppSecurity")]
        [Validation(Required=false)]
        public string TripAppSecurity { get; set; }

        [NameInMap("tripCorpId")]
        [Validation(Required=false)]
        public string TripCorpId { get; set; }

    }

}
