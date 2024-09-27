// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class GetAllSheetsResponseBody : TeaModel {
        [NameInMap("value")]
        [Validation(Required=false)]
        public List<GetAllSheetsResponseBodyValue> Value { get; set; }
        public class GetAllSheetsResponseBodyValue : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>sheet_id</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sheet_name</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
