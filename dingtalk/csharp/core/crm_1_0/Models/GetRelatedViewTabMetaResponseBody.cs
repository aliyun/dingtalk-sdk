// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class GetRelatedViewTabMetaResponseBody : TeaModel {
        [NameInMap("results")]
        [Validation(Required=false)]
        public List<GetRelatedViewTabMetaResponseBodyResults> Results { get; set; }
        public class GetRelatedViewTabMetaResponseBodyResults : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>PROC-4EFE895D-A291-4A65-9FD6-99431604DF67</para>
            /// </summary>
            [NameInMap("formCode")]
            [Validation(Required=false)]
            public string FormCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>OpenDataField_K99RPMMRGJ40</para>
            /// </summary>
            [NameInMap("relateComponentId")]
            [Validation(Required=false)]
            public string RelateComponentId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>212</para>
            /// </summary>
            [NameInMap("tabTitle")]
            [Validation(Required=false)]
            public string TabTitle { get; set; }

        }

    }

}
