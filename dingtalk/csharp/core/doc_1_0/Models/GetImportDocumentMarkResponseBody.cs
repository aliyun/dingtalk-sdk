// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class GetImportDocumentMarkResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetImportDocumentMarkResponseBodyResult Result { get; set; }
        public class GetImportDocumentMarkResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>doc_id</para>
            /// </summary>
            [NameInMap("docId")]
            [Validation(Required=false)]
            public string DocId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>mark_map</para>
            /// </summary>
            [NameInMap("markMap")]
            [Validation(Required=false)]
            public Dictionary<string, string> MarkMap { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
