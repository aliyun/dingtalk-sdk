// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class CopyDocWithAppAuthRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("sourceDentryUuid")]
        [Validation(Required=false)]
        public string SourceDentryUuid { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("targetParentDentryUuid")]
        [Validation(Required=false)]
        public string TargetParentDentryUuid { get; set; }

        [NameInMap("targetPreDentryUuid")]
        [Validation(Required=false)]
        public string TargetPreDentryUuid { get; set; }

    }

}
