// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconnector_1_0.Models
{
    public class SearchActionsRequest : TeaModel {
        /// <summary>
        /// 连接器的ID
        /// </summary>
        [NameInMap("connectorId")]
        [Validation(Required=false)]
        public string ConnectorId { get; set; }

        /// <summary>
        /// 连接器提供组织ID
        /// </summary>
        [NameInMap("connectorProviderCorpId")]
        [Validation(Required=false)]
        public string ConnectorProviderCorpId { get; set; }

        /// <summary>
        /// 集成类型，默认只有basic-基础类型
        /// </summary>
        [NameInMap("integrationTypes")]
        [Validation(Required=false)]
        public List<string> IntegrationTypes { get; set; }

        /// <summary>
        /// 最大返回记录数
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 查询位置，为空表示从头开始
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
