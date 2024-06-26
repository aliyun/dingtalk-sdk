// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkbench_1_0.Models
{
    public class ModifyWorkbenchBadgeRequest : TeaModel {
        [NameInMap("bizIdList")]
        [Validation(Required=false)]
        public List<string> BizIdList { get; set; }

        [NameInMap("isAdded")]
        [Validation(Required=false)]
        public bool? IsAdded { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("modifyMode")]
        [Validation(Required=false)]
        public string ModifyMode { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("redDotRelationId")]
        [Validation(Required=false)]
        public string RedDotRelationId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("redDotType")]
        [Validation(Required=false)]
        public string RedDotType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
