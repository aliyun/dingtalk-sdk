// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class PageQueryDevicesResponseBody : TeaModel {
        [NameInMap("list")]
        [Validation(Required=false)]
        public List<PageQueryDevicesResponseBodyList> List { get; set; }
        public class PageQueryDevicesResponseBodyList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1696753792000</para>
            /// </summary>
            [NameInMap("gmtExpiry")]
            [Validation(Required=false)]
            public long? GmtExpiry { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>model1</para>
            /// </summary>
            [NameInMap("model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>三年级1班班牌</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>fadf-8008</para>
            /// </summary>
            [NameInMap("sn")]
            [Validation(Required=false)]
            public string Sn { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>VIDEO_CALL</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1300</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
