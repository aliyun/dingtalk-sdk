// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_2_0.Models
{
    public class UpdateAgentTaskRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ALL</para>
        /// </summary>
        [NameInMap("agentRangeType")]
        [Validation(Required=false)]
        public string AgentRangeType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[{&quot;appType&quot;:&quot;APP_xxx&quot;,&quot;formUuid&quot;:&quot;FORM-xxx&quot;}]</para>
        /// </summary>
        [NameInMap("agentRangeValue")]
        [Validation(Required=false)]
        public string AgentRangeValue { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("agentUserId")]
        [Validation(Required=false)]
        public string AgentUserId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Agent--xxxxx</para>
        /// </summary>
        [NameInMap("agentUuid")]
        [Validation(Required=false)]
        public string AgentUuid { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dingxxxx</para>
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1761204600404</para>
        /// </summary>
        [NameInMap("endTimestamp")]
        [Validation(Required=false)]
        public string EndTimestamp { get; set; }

        [NameInMap("needNoticePrincipal")]
        [Validation(Required=false)]
        public string NeedNoticePrincipal { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1761204600404</para>
        /// </summary>
        [NameInMap("startTimestamp")]
        [Validation(Required=false)]
        public string StartTimestamp { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>501453</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
