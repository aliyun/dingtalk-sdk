// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class RosterMetaAvailableFieldListResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<RosterMetaAvailableFieldListResponseBodyResult> Result { get; set; }
        public class RosterMetaAvailableFieldListResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>sys01-employeeType</para>
            /// </summary>
            [NameInMap("fieldCode")]
            [Validation(Required=false)]
            public string FieldCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>员工类型</para>
            /// </summary>
            [NameInMap("fieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DDSelectField</para>
            /// </summary>
            [NameInMap("fieldType")]
            [Validation(Required=false)]
            public string FieldType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[{&quot;value&quot;:&quot;1&quot;,&quot;label&quot;:&quot;男&quot;},{&quot;value&quot;:&quot;2&quot;,&quot;label&quot;:&quot;女&quot;}]</para>
            /// </summary>
            [NameInMap("optionText")]
            [Validation(Required=false)]
            public string OptionText { get; set; }

        }

    }

}
