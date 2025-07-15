// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class CreateShortcutRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("param")]
        [Validation(Required=false)]
        public CreateShortcutRequestParam Param { get; set; }
        public class CreateShortcutRequestParam : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dentryUuid</para>
            /// </summary>
            [NameInMap("sourceResourceId")]
            [Validation(Required=false)]
            public string SourceResourceId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DENTRY</para>
            /// </summary>
            [NameInMap("sourceResourceType")]
            [Validation(Required=false)]
            public string SourceResourceType { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dentryUuid</para>
            /// </summary>
            [NameInMap("targetResourceId")]
            [Validation(Required=false)]
            public string TargetResourceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123test</para>
            /// </summary>
            [NameInMap("targetResourceName")]
            [Validation(Required=false)]
            public string TargetResourceName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DENTRY</para>
            /// </summary>
            [NameInMap("targetResourceType")]
            [Validation(Required=false)]
            public string TargetResourceType { get; set; }

        }

    }

}
