// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalksns_storage_1_0.Models
{
    public class ListExpiredRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>open_conversation_id</para>
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        [NameInMap("option")]
        [Validation(Required=false)]
        public ListExpiredRequestOption Option { get; set; }
        public class ListExpiredRequestOption : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("maxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>next_token</para>
            /// </summary>
            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>union_id</para>
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
