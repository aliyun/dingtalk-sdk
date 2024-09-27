// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkapaas_1_0.Models
{
    public class RecallAuditTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("recallResult")]
        [Validation(Required=false)]
        public List<RecallAuditTemplateResponseBodyRecallResult> RecallResult { get; set; }
        public class RecallAuditTemplateResponseBodyRecallResult : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>template_key_1</para>
            /// </summary>
            [NameInMap("templateKey")]
            [Validation(Required=false)]
            public string TemplateKey { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>recall_success</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
