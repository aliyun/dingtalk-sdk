// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconnector_1_0.Models
{
    public class SearchActionsResponseBody : TeaModel {
        /// <summary>
        /// 是否有更多记录
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// 执行动作列表
        /// </summary>
        [NameInMap("list")]
        [Validation(Required=false)]
        public List<SearchActionsResponseBodyList> List { get; set; }
        public class SearchActionsResponseBodyList : TeaModel {
            /// <summary>
            /// 授权页地址
            /// </summary>
            [NameInMap("authorityUrl")]
            [Validation(Required=false)]
            public string AuthorityUrl { get; set; }

            /// <summary>
            /// 是否已授权
            /// </summary>
            [NameInMap("authorized")]
            [Validation(Required=false)]
            public bool? Authorized { get; set; }

            /// <summary>
            /// 连接资产唯一标识
            /// </summary>
            [NameInMap("connectAssetUri")]
            [Validation(Required=false)]
            public string ConnectAssetUri { get; set; }

            /// <summary>
            /// 执行动作所属连接器ID
            /// </summary>
            [NameInMap("connectorId")]
            [Validation(Required=false)]
            public string ConnectorId { get; set; }

            /// <summary>
            /// 描述
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// 图标
            /// </summary>
            [NameInMap("icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            /// <summary>
            /// 执行动作的ID
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// 集成类型
            /// </summary>
            [NameInMap("integrationType")]
            [Validation(Required=false)]
            public string IntegrationType { get; set; }

            /// <summary>
            /// 名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 提供组织
            /// </summary>
            [NameInMap("providerCorpId")]
            [Validation(Required=false)]
            public string ProviderCorpId { get; set; }

        }

        /// <summary>
        /// 下一页位置
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
