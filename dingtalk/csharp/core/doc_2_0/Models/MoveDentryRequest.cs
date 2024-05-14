// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class MoveDentryRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("targetSpaceId")]
        [Validation(Required=false)]
        public string TargetSpaceId { get; set; }

        [NameInMap("toNextDentryId")]
        [Validation(Required=false)]
        public string ToNextDentryId { get; set; }

        [NameInMap("toParentDentryId")]
        [Validation(Required=false)]
        public string ToParentDentryId { get; set; }

        [NameInMap("toPrevDentryId")]
        [Validation(Required=false)]
        public string ToPrevDentryId { get; set; }

    }

}
