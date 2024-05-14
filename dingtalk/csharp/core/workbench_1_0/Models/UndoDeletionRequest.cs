// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkbench_1_0.Models
{
    public class UndoDeletionRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("bizIdList")]
        [Validation(Required=false)]
        public List<string> BizIdList { get; set; }

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
