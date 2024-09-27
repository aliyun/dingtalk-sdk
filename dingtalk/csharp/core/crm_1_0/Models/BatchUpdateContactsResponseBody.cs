// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class BatchUpdateContactsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("results")]
        [Validation(Required=false)]
        public List<BatchUpdateContactsResponseBodyResults> Results { get; set; }
        public class BatchUpdateContactsResponseBodyResults : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1002</para>
            /// </summary>
            [NameInMap("errorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>查重失败</para>
            /// </summary>
            [NameInMap("errorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>gads1ag-sfgasdfxcvxb</para>
            /// </summary>
            [NameInMap("relationId")]
            [Validation(Required=false)]
            public string RelationId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

    }

}
