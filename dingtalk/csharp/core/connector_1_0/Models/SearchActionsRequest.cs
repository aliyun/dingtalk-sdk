// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconnector_1_0.Models
{
    public class SearchActionsRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>G-CONN-1015BC8093540B01B8D0000Q</para>
        /// </summary>
        [NameInMap("connectorId")]
        [Validation(Required=false)]
        public string ConnectorId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ding32fff839a3e0105d</para>
        /// </summary>
        [NameInMap("connectorProviderCorpId")]
        [Validation(Required=false)]
        public string ConnectorProviderCorpId { get; set; }

        /// <summary>
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("integrationTypes")]
        [Validation(Required=false)]
        public List<string> IntegrationTypes { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
