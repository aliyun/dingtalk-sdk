// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconnector_1_0.Models
{
    public class SearchConnectorsResponseBody : TeaModel {
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("list")]
        [Validation(Required=false)]
        public List<SearchConnectorsResponseBodyList> List { get; set; }
        public class SearchConnectorsResponseBodyList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>【钉钉官方】通讯录</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://static.dingtalk.com/media/lALPDfJ6WadAG1dgYA_96_96.png">https://static.dingtalk.com/media/lALPDfJ6WadAG1dgYA_96_96.png</a></para>
            /// </summary>
            [NameInMap("icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>G-CONN-1015BC8093540B01B8D0000Q</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>通讯录</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ding32fff839a3e0105d</para>
            /// </summary>
            [NameInMap("providerCorpId")]
            [Validation(Required=false)]
            public string ProviderCorpId { get; set; }

        }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
