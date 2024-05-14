// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkvillage_1_0.Models
{
    public class ListSubCorpsRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("isOnlyDirect")]
        [Validation(Required=false)]
        public bool? IsOnlyDirect { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("subCorpId")]
        [Validation(Required=false)]
        public string SubCorpId { get; set; }

        [NameInMap("types")]
        [Validation(Required=false)]
        public string Types { get; set; }

    }

}
