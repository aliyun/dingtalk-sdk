// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_2_0.Models
{
    public class GetDefineDataResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetDefineDataResponseBodyResult> Result { get; set; }
        public class GetDefineDataResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>DA_123456</para>
            /// </summary>
            [NameInMap("dataCode")]
            [Validation(Required=false)]
            public string DataCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DEF_123456</para>
            /// </summary>
            [NameInMap("defineCode")]
            [Validation(Required=false)]
            public string DefineCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xx路1号门店</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>-1</para>
            /// </summary>
            [NameInMap("parentDataCode")]
            [Validation(Required=false)]
            public string ParentDataCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>valid</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
