// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class ChangeMainAdminRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("effectCorpId")]
        [Validation(Required=false)]
        public string EffectCorpId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("sourceUserId")]
        [Validation(Required=false)]
        public string SourceUserId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("targetUserId")]
        [Validation(Required=false)]
        public string TargetUserId { get; set; }

    }

}
