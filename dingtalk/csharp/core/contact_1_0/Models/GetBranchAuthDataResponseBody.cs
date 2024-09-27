// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class GetBranchAuthDataResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetBranchAuthDataResponseBodyResult> Result { get; set; }
        public class GetBranchAuthDataResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>teacherCnt</para>
            /// </summary>
            [NameInMap("fieldCode")]
            [Validation(Required=false)]
            public string FieldCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>老师数量</para>
            /// </summary>
            [NameInMap("fieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("fieldValue")]
            [Validation(Required=false)]
            public string FieldValue { get; set; }

        }

    }

}
