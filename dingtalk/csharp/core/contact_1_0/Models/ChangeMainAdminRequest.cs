// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class ChangeMainAdminRequest : TeaModel {
        /// <summary>
        /// effectCorpId
        /// </summary>
        [NameInMap("effectCorpId")]
        [Validation(Required=false)]
        public string EffectCorpId { get; set; }

        /// <summary>
        /// sourceUserId
        /// </summary>
        [NameInMap("sourceUserId")]
        [Validation(Required=false)]
        public string SourceUserId { get; set; }

        /// <summary>
        /// targetUserId
        /// </summary>
        [NameInMap("targetUserId")]
        [Validation(Required=false)]
        public string TargetUserId { get; set; }

    }

}
