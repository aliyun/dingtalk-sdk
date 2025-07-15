// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class CopyDocRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("param")]
        [Validation(Required=false)]
        public CopyDocRequestParam Param { get; set; }
        public class CopyDocRequestParam : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dentryUuid</para>
            /// </summary>
            [NameInMap("sourceDentryUuid")]
            [Validation(Required=false)]
            public string SourceDentryUuid { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dentryUuid</para>
            /// </summary>
            [NameInMap("targetParentDentryUuid")]
            [Validation(Required=false)]
            public string TargetParentDentryUuid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dentryUuid</para>
            /// </summary>
            [NameInMap("targetPreDentryUuid")]
            [Validation(Required=false)]
            public string TargetPreDentryUuid { get; set; }

        }

    }

}
