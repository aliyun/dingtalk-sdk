// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class GetRecycleBinResponseBody : TeaModel {
        [NameInMap("recycleBin")]
        [Validation(Required=false)]
        public GetRecycleBinResponseBodyRecycleBin RecycleBin { get; set; }
        public class GetRecycleBinResponseBodyRecycleBin : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>recyclebin_id</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SPACE</para>
            /// </summary>
            [NameInMap("scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>scope_id</para>
            /// </summary>
            [NameInMap("scopeId")]
            [Validation(Required=false)]
            public string ScopeId { get; set; }

        }

    }

}
