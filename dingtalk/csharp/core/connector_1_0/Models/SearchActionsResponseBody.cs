// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconnector_1_0.Models
{
    public class SearchActionsResponseBody : TeaModel {
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("list")]
        [Validation(Required=false)]
        public List<SearchActionsResponseBodyList> List { get; set; }
        public class SearchActionsResponseBodyList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>dingtalk://dingtalkclient/page/link?pc_slide=true&amp;url=https%3A%2F%2Fn.dingtalk.com%2Fdingding%2Fh5-common-authority%2Fconnector%2Findex.html%3FcorpId%3Dding32fff839a3e0105d%26accessorUuid%3DAPP-505001%26oPaths%3D%252Fding5b2a0b7e9677128935c2f4657eb6378f%252Fconnector%252FG-CONN-1017AF27C1B20B0FFD490005</para>
            /// </summary>
            [NameInMap("authorityUrl")]
            [Validation(Required=false)]
            public string AuthorityUrl { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("authorized")]
            [Validation(Required=false)]
            public bool? Authorized { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dca://ding32fff839a3e0105d.connect.dingtalk.com/ding32fff839a3e0105d/action/G-ACT-101FDEBD3C6E213DB474000P</para>
            /// </summary>
            [NameInMap("connectAssetUri")]
            [Validation(Required=false)]
            public string ConnectAssetUri { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>G-CONN-XXCONNECTOR</para>
            /// </summary>
            [NameInMap("connectorId")]
            [Validation(Required=false)]
            public string ConnectorId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例描述</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://example.com/icon.jpg">http://example.com/icon.jpg</a></para>
            /// </summary>
            [NameInMap("icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>G-ACT-XXXACTION</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>basic</para>
            /// </summary>
            [NameInMap("integrationType")]
            [Validation(Required=false)]
            public string IntegrationType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例连接器</para>
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

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
